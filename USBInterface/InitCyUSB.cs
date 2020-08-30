using CyUSB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MITS_SINGLE_SYSTEM
{
    public partial class MITS_SYSTEM
    {
        CyUSBDevice loopDevice = null;
        USBDeviceList usbDevices = null;
        CyBulkEndPoint inEndpoint = null;
        CyBulkEndPoint outEndpoint = null;

        Thread tXfers_Read;
        Thread tXfers_Write;

        const int XFERSIZE = 4096*4;             // Maximium 32bit * 16384 transfer(4bulk)

        byte[] outData = new byte[XFERSIZE];  // for out bulk transfer
        byte[] inData = new byte[XFERSIZE];  // for in  bulk transfer

        int xferLen_Write;                            // for bulk trasfer size set
        int xferLen_Read;                         // for bulk trasfer size set


        int[][] CH1_DataArray;

        int[] Tx_data = new int[4096];       // for Tx data buffer. 
        int[] Rx_data = new int[4096];       // for Tx data buffer. 

        int RegisterSequencyCounter = 0;

        public void initDevice()
        {
            usbDevices = new USBDeviceList(CyConst.DEVICES_CYUSB);
            Console.WriteLine("usbDevices : " + usbDevices);
            //Adding event handlers for device attachment and device removal
            usbDevices.DeviceAttached += new EventHandler(usbDevices_DeviceAttached);
            usbDevices.DeviceRemoved += new EventHandler(usbDevices_DeviceRemoved);
            setDevice();
        }

        void usbDevices_DeviceAttached(object sender, EventArgs e)
        {
            Console.WriteLine("USB Connected");
            SystemLogBox.AppendText("USB Connected" + "\r\n");
            setDevice();
        }

        void usbDevices_DeviceRemoved(object sender, EventArgs e)
        {
            Console.WriteLine("USB Remove");
            SystemLogBox.AppendText("USB Remove" + "\r\n");
            //when device is removed, rd/rw thread will be shutdown.
            tXfers_Read.Abort();
            tXfers_Read.Join();
            tXfers_Read = null;
            outEndpoint.Reset();

            tXfers_Write.Abort();
            tXfers_Write.Join();
            tXfers_Write = null;
            inEndpoint.Reset();
            setDevice();
        }

        public void setDevice()
        {
            int nCurSelection = 0;
            if (SystemBoardConnection.Items.Count > 0)
            {
                nCurSelection = SystemBoardConnection.SelectedIndex;
                SystemBoardConnection.Items.Clear();
                SystemBoardINEndpoint.Items.Clear();
                SystemBoardOUTEndpoint.Items.Clear();
            }
            int nDeviceList = usbDevices.Count;
            for (int nCount = 0; nCount < nDeviceList; nCount++)
            {
                USBDevice fxDevice = usbDevices[nCount];
                String strmsg;
                strmsg = "(0x" + fxDevice.ProductID.ToString("X4") + ") " + "MITS_US_BOARD Rev1.0";
                SystemBoardConnection.Items.Add(strmsg);
            }

            if (SystemBoardConnection.Items.Count > 0)
                SystemBoardConnection.SelectedIndex = nCurSelection;

            loopDevice = usbDevices[SystemBoardConnection.SelectedIndex] as CyUSBDevice;

            if (loopDevice != null) GetEndpointsOfNode(loopDevice.Tree);
            if (SystemBoardINEndpoint.Items.Count > 0) SystemBoardINEndpoint.SelectedIndex = 0;
            if (SystemBoardOUTEndpoint.Items.Count > 0) SystemBoardOUTEndpoint.SelectedIndex = 0;
            // Set the IN and OUT endpoints per the selected radio buttons.
            ConstructEndpoints();

            if ((outEndpoint != null) && (inEndpoint != null) && (SystemBoardConnection.Items.Count > 0))
            {
                if (loopDevice.bSuperSpeed)
                {
                    xferLen_Write = 16384;
                    xferLen_Read = 16384;
                }
                else if (loopDevice.bHighSpeed)
                {
                    xferLen_Write = 512;
                    xferLen_Read = 512;
                }
                Console.WriteLine("Data Spped Write : {0} / Read {1}", xferLen_Write, xferLen_Read);


                tXfers_Read = new Thread(new ThreadStart(ReadThread));
                tXfers_Read.IsBackground = true;
                tXfers_Read.Priority = ThreadPriority.Highest;

                tXfers_Write = new Thread(new ThreadStart(WriteThread));
                tXfers_Write.IsBackground = true;
                tXfers_Write.Priority = ThreadPriority.Lowest;

                tXfers_Read.Start();
                tXfers_Write.Start();
                Console.WriteLine("Comunication Thread RX/TX Started");


            }

        }

        private void GetEndpointsOfNode(TreeNode devTree)
        {
            SystemBoardINEndpoint.Items.Clear();
            SystemBoardOUTEndpoint.Items.Clear();

            foreach (TreeNode node in devTree.Nodes)
            {
                if (node.Nodes.Count > 0)
                    GetEndpointsOfNode(node);
                else
                {
                    CyUSBEndPoint ept = node.Tag as CyUSBEndPoint;
                    if (ept == null)
                    {
                        //return;
                    }
                    else if (node.Text.Contains("Bulk in"))
                    {
                        CyUSBInterface ifc = node.Parent.Tag as CyUSBInterface;
                        string s = string.Format("ALT-{0}, {1} Byte {2}", ifc.bAlternateSetting, ept.MaxPktSize, node.Text);
                        SystemBoardINEndpoint.Items.Add(s);
                    }
                    else if (node.Text.Contains("Bulk out"))
                    {
                        CyUSBInterface ifc = node.Parent.Tag as CyUSBInterface;
                        string s = string.Format("ALT-{0}, {1} Byte {2}", ifc.bAlternateSetting, ept.MaxPktSize, node.Text);
                        SystemBoardOUTEndpoint.Items.Add(s);
                    }

                }
            }

        }

        private void ConstructEndpoints()
        {
            if (loopDevice != null && SystemBoardOUTEndpoint.Items.Count > 0 && SystemBoardINEndpoint.Items.Count > 0)
            {

                string sAltOut = SystemBoardOUTEndpoint.Text.Substring(4, 1);
                byte outAltInferface = Convert.ToByte(sAltOut);

                string sAltIn = SystemBoardINEndpoint.Text.Substring(4, 1);
                byte inAltInferface = Convert.ToByte(sAltIn);

                if (outAltInferface != inAltInferface)
                {
                    Console.WriteLine("Output Endpoint and Input Endpoint should present in the same ALT interface");

                    return;
                }

                // Get the endpoint
                int aX = SystemBoardINEndpoint.Text.LastIndexOf("0x");
                string sAddr = SystemBoardINEndpoint.Text.Substring(aX, 4);
                byte addrIn = (byte)Util.HexToInt(sAddr);

                aX = SystemBoardOUTEndpoint.Text.LastIndexOf("0x");
                sAddr = SystemBoardOUTEndpoint.Text.Substring(aX, 4);
                byte addrOut = (byte)Util.HexToInt(sAddr);

                outEndpoint = loopDevice.EndPointOf(0x01) as CyBulkEndPoint;
                inEndpoint = loopDevice.EndPointOf(0x81) as CyBulkEndPoint;

                if ((outEndpoint != null) && (inEndpoint != null))
                {
                    //make sure that the device configuration doesn't contain the other than bulk endpoint

                    if ((outEndpoint.Attributes & 0x03/*0,1 bit for type of transfer*/) != 0x02/*Bulk endpoint*/)
                    {
                        Console.WriteLine("Device Configuration mismatch");
                        return;

                    }
                    if ((inEndpoint.Attributes & 0x03) != 0x02)
                    {
                        Console.WriteLine("Device Configuration mismatch");
                        return;
                    }
                    outEndpoint.TimeOut = 1;
                    inEndpoint.TimeOut = 1;
                }
                else
                {

                    Console.WriteLine("Device Configuration mismatch");
                    return;
                }

            }
        }


    }
}
