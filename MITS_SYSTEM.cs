using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MITS_SINGLE_SYSTEM
{
    public partial class MITS_SYSTEM : Form
    {
        public MITS_SYSTEM()
        {
            InitializeComponent();
            initDevice();
        }

        private void MITS_SYSTEM_Load(object sender, EventArgs e)
        {
            CH1_ParameterInit();
            SendParameterReset();
            SendParameterTestReset();
            FormChangedInit();
            GraphicConvertInit();
            color_initialize();
            timer_initialize();

        }

        private void MITS_SYSTEM_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (HV_Loop)
            {
                MessageBox.Show("HV Not Disabled.\nPlease Click HV OFF Button", "Warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        /* MAIN Tab Button Control */

        //*/Mode Select Changed
        private void CH1_Mode_Imaging_CheckedChanged(object sender, EventArgs e)
        {
            CH1_ModeSelect(CH1_Mode_Imaging.Checked);
            Console.WriteLine(String.Format("CH1_Mode_Imaging: {0}", CH1_Mode_Imaging.Checked));
        }
        private void CH1_Mode_Stimul_CheckedChanged(object sender, EventArgs e)
        {
            CH1_ModeSelect(!CH1_Mode_Stimul.Checked);
            Console.WriteLine(String.Format("CH1_Mode_Stimul: {0}", CH1_Mode_Stimul.Checked));
        }
        //*/
            
            
            

        //*/N of Scanline Changed
        private void CH1_Scanline_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CH1_Scanline_data = int.Parse(string.Format("{0:D}", CH1_Scanline.Text), styleInteger);
                Console.WriteLine(String.Format("CH1_Scanline_data: {0}", CH1_Scanline_data));
            } 
            catch(Exception ex)
            {
                Console.WriteLine("Exepction : {0}", ex);
            }
            

        }
        //*/

        //*/PRF Changed
        private void CH1_PRF_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CH1_PRF_data = int.Parse(string.Format("{0:D}", CH1_PRF.Text), styleInteger);
                Console.WriteLine(String.Format("CH1_PRF_data: {0}", CH1_PRF_data));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exepction : {0}", ex);
            }
        }
        //*/Center Frequency Changed
        double CalDuration = 0.0;
        private void CH1_CF_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                CH1_CF_data = int.Parse(string.Format("{0:D}", CH1_CF.Text), styleInteger);
                Console.WriteLine(String.Format("CH1_CF_data: {0}", CH1_CF_data));

                //CalDuration = ((double)1 / (double)CH1_CF_data) * CH1_PulseCycles_data;
                //CH1_PulseDuration_data = CalDuration;
                //CH1_PulseDuration.Text = CH1_PulseDuration_data.ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exepction : {0}", ex);
            }
        }
        //*/

        //*/Pulse Cycle & Pulse Dulation Changed
        private void CH1_PulseCycles_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                CH1_PulseCycles_data = int.Parse(string.Format("{0:D}", CH1_PulseCycles.Text), styleInteger);
                Console.WriteLine(String.Format("CH1_PulseCycles_data: {0}", CH1_PulseCycles_data));

                //CalDuration = ((double)1 / (double)CH1_CF_data) * CH1_PulseCycles_data;
                //CH1_PulseDuration_data = CalDuration;
                //CH1_PulseDuration.Text = CH1_PulseDuration_data.ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exepction : {0}", ex);
            }

        }
        private void CH1_PulseDuration_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CH1_PulseDuration_data = int.Parse(string.Format("{0:D}", CH1_PulseDuration.Text), styleInteger);

                Console.WriteLine(String.Format("CH1_PulseDuration_data: {0}", CH1_PulseDuration_data));
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception : {0}", ex);
            }
        }
        //*/

        //*/Dynamic Range Changed
        private void CH1_DynamicRange_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CH1_DynamicRange_data = int.Parse(string.Format("{0:D}", CH1_DynamicRange.Text), styleInteger);
                Console.WriteLine(String.Format("CH1_DynamicRange_data: {0}", CH1_DynamicRange_data));

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exepction : {0}", ex);
            }
        }
        //*/

        //*/View Depth Changed
        private void CH1_ViewDepth_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                CH1_ViewDepth_data = string.Format("{0:D}", CH1_ViewDepth.Text);
                Console.WriteLine(String.Format("CH1_ViewDepth_data: {0}", CH1_ViewDepth_data));

                switch (CH1_ViewDepth_data)
                {
                    case "None":
                        CH1_Rx_data = 0;
                        CH1_CM_Length = 0;
                        CH1_CM_Divider = 1;
                        break;
                    case "~1cm":
                        CH1_Rx_data = 4096;
                        CH1_CM_Length = 1331;
                        CH1_CM_Divider = 1;
                        break;
                    case "~2cm":
                        CH1_Rx_data = 4096;
                        CH1_CM_Length = 1331 * 2;
                        CH1_CM_Divider = 2;
                        break;
                    case "~3cm":
                        CH1_Rx_data = 4096;
                        CH1_CM_Length = 1331 * 3;
                        CH1_CM_Divider = 3;
                        break;
                    case "~4cm":

                        CH1_Rx_data = 8192;
                        CH1_CM_Length = 1331 * 4;
                        CH1_CM_Divider = 4;
                        break;
                }
                Console.WriteLine(String.Format("CH1_Rx_data: {0} / CH1_CM_Length: {1} / CH1_CM_Divider: {2} ", CH1_Rx_data, CH1_CM_Length, CH1_CM_Divider));

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exepction : {0}", ex);
            }
        }
        //*/



        //*/AFE - LPF, PGA Gain, ADC Gain Changed
        private void CH1_LPF_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                CH1_LPF_data = string.Format("{0:D}", CH1_LPF.Text);
                CH1_PGA_data = string.Format("{0:D}", CH1_PGAGain.Text);
                Console.WriteLine(String.Format("CH1_LPF_data: {0}", CH1_LPF_data));

                switch (CH1_LPF_data)
                {
                    case "60MHz":
                        switch (CH1_PGA_data)
                        {
                            case "0dB":
                                _A0A3_AFE_Reg_3B = "A0A300E0";
                                break;
                            case "3dB":
                                _A0A3_AFE_Reg_3B = "A0A300D0";
                                break;
                            case "6dB":
                                _A0A3_AFE_Reg_3B = "A0A300C0";
                                break;
                            case "9dB":
                                _A0A3_AFE_Reg_3B = "A0A300B0";
                                break;
                            case "12dB":
                                _A0A3_AFE_Reg_3B = "A0A300A0";
                                break;
                            case "15dB":
                                _A0A3_AFE_Reg_3B = "A0A30090";
                                break;
                            case "18dB":
                                _A0A3_AFE_Reg_3B = "A0A30080";
                                break;
                        }
                        break;
                    case "75MHz":
                        switch (CH1_PGA_data)
                        {
                            case "0dB":
                                _A0A3_AFE_Reg_3B = "A0A30060";
                                break;
                            case "3dB":
                                _A0A3_AFE_Reg_3B = "A0A30050";
                                break;
                            case "6dB":
                                _A0A3_AFE_Reg_3B = "A0A30040";
                                break;
                            case "9dB":
                                _A0A3_AFE_Reg_3B = "A0A30030";
                                break;
                            case "12dB":
                                _A0A3_AFE_Reg_3B = "A0A30020";
                                break;
                            case "15dB":
                                _A0A3_AFE_Reg_3B = "A0A30010";
                                break;
                            case "18dB":
                                _A0A3_AFE_Reg_3B = "A0A30000";
                                break;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exepction : {0}", ex);
            }

        }

        private void CH1_PGAGain_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                CH1_LPF_data = string.Format("{0:D}", CH1_LPF.Text);
                CH1_PGA_data = string.Format("{0:D}", CH1_PGAGain.Text);
                Console.WriteLine(String.Format("CH1_PGA_data: {0}", CH1_PGA_data));

                switch (CH1_LPF_data)
                {
                    case "60MHz":
                        switch (CH1_PGA_data)
                        {
                            case "0dB":
                                _A0A3_AFE_Reg_3B = "A0A300E0";
                                break;
                            case "3dB":
                                _A0A3_AFE_Reg_3B = "A0A300D0";
                                break;
                            case "6dB":
                                _A0A3_AFE_Reg_3B = "A0A300C0";
                                break;
                            case "9dB":
                                _A0A3_AFE_Reg_3B = "A0A300B0";
                                break;
                            case "12dB":
                                _A0A3_AFE_Reg_3B = "A0A300A0";
                                break;
                            case "15dB":
                                _A0A3_AFE_Reg_3B = "A0A30090";
                                break;
                            case "18dB":
                                _A0A3_AFE_Reg_3B = "A0A30080";
                                break;
                        }
                        break;
                    case "75MHz":
                        switch (CH1_PGA_data)
                        {
                            case "0dB":
                                _A0A3_AFE_Reg_3B = "A0A30060";
                                break;
                            case "3dB":
                                _A0A3_AFE_Reg_3B = "A0A30050";
                                break;
                            case "6dB":
                                _A0A3_AFE_Reg_3B = "A0A30040";
                                break;
                            case "9dB":
                                _A0A3_AFE_Reg_3B = "A0A30030";
                                break;
                            case "12dB":
                                _A0A3_AFE_Reg_3B = "A0A30020";
                                break;
                            case "15dB":
                                _A0A3_AFE_Reg_3B = "A0A30010";
                                break;
                            case "18dB":
                                _A0A3_AFE_Reg_3B = "A0A30000";
                                break;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exepction : {0}", ex);
            }
        }

        private void CH1_ADCGain_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                CH1_ADC_data = string.Format("{0:D}", CH1_ADCGain.Text);
                Console.WriteLine(String.Format("CH1_ADC_data: {0}", CH1_ADC_data));

                switch (CH1_ADC_data)
                {
                    case "0dB":
                        _A022_ADC_Reg_25 = "A0222500";
                        break;
                    case "0.5dB":
                        _A022_ADC_Reg_25 = "A0222510";
                        break;
                    case "1dB":
                        _A022_ADC_Reg_25 = "A0222520";
                        break;
                    case "1.5dB":
                        _A022_ADC_Reg_25 = "A0222530";
                        break;
                    case "2dB":
                        _A022_ADC_Reg_25 = "A0222540";
                        break;
                    case "2.5dB":
                        _A022_ADC_Reg_25 = "A0222550";
                        break;
                    case "3dB":
                        _A022_ADC_Reg_25 = "A0222560";
                        break;
                    case "3.5dB":
                        _A022_ADC_Reg_25 = "A0222570";
                        break;
                    case "4dB":
                        _A022_ADC_Reg_25 = "A0222580";
                        break;
                    case "4.5dB":
                        _A022_ADC_Reg_25 = "A0222590";
                        break;
                    case "5dB":
                        _A022_ADC_Reg_25 = "A02225A0";
                        break;
                    case "5.5dB":
                        _A022_ADC_Reg_25 = "A02225B0";
                        break;
                    case "6dB":
                        _A022_ADC_Reg_25 = "A02225C0";
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exepction : {0}", ex);
            }
        }
        //*/

        //*/High Voltage Changed
        int inputHVData = 0;
        double CalHV = 0.0;
        private void CH1_HVLevel_TextChanged(object sender, EventArgs e)
        {
            try
            {
                inputHVData = int.Parse(string.Format("{0:D}", CH1_HVLevel.Text), styleInteger);
                CalHV = ((double)inputHVData * 2.933) + 0.063;
                Console.WriteLine(String.Format("inputHVData: {0} / Cal_HV_data: {1}", inputHVData, CalHV));

                CH1_HV_data = (int)CalHV;
                Console.WriteLine(String.Format("CH1_HV_data: {0}", CH1_HV_data));

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exepction : {0}", ex);
            }

        }

        private void CH1_VolatageControl_Click(object sender, EventArgs e)
        {
            try
            {
                CH1_HVInterface(HV_Loop);
                if (HV_Loop)
                {
                    SendParameterReset();
                    CH1_HVLoad();
                    writeSendFlag = true;
                }
                else
                {
                    SendParameterReset();
                    _8801_DAC_ON = "88010000";
                    Tx_data[RegisterSequencyCounter] = int.Parse(_8801_DAC_ON, styleHex); RegisterSequencyCounter++;
                    writeSendFlag = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exepction : {0}", ex);
            }
        }
        //*/


        //*/Pulse Control Changed
        private void CH1_PulseControl_Click(object sender, EventArgs e)
        {
            try
            {
                CH1_PulserInterface(Pulser_Loop);
                //CH1_HVInterface(HV_Loop);
                if (Pulser_Loop)
                {
                    SendParameterReset();
                    //CH1_HVLoad();
                    CH1_StimulParameterLoad();
                    RegisterSequencyCounter++;
                    RegisterSequencyCounter++;
                    RegisterSequencyCounter++;
                    RegisterSequencyCounter++;
                    RegisterSequencyCounter++;

                    _8400_System_On = "84000001";
                    Tx_data[RegisterSequencyCounter] = int.Parse(_8400_System_On, styleHex); RegisterSequencyCounter++;
                    writeSendFlag = true;

                }
                else
                {
                    SendParameterReset();
                    //_8801_DAC_ON = "88010000";
                    //Tx_data[RegisterSequencyCounter] = int.Parse(_8801_DAC_ON, styleHex); RegisterSequencyCounter++;
                    _8400_System_On = "84000000";
                    Tx_data[RegisterSequencyCounter] = int.Parse(_8400_System_On, styleHex); RegisterSequencyCounter++;
                    writeSendFlag = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exepction : {0}", ex);
            }
        }

        private void CH1_ScanControl_Click(object sender, EventArgs e)
        {
            try
            {
                CH1_SCANInterface(SCAN_Loop);

                if (SCAN_Loop)
                {
                    SendParameterReset();
                    CH1_ReisterSet();
                    //*/ Test Data
                    //*/
                    writeSendFlag = true;


                    //*/ DrawThread Star
                    if (graphicDrawThread == null)
                    {
                        graphicDrawThread = new Thread(new ThreadStart(DrawThread));
                        graphicDrawThread.IsBackground = true;
                        graphicDrawThread.Priority = ThreadPriority.Highest;
                        graphicDrawThread.Start();
                    }
                    //*/
                }
                else
                {
                    SendParameterReset();
                    setSaveDataFlag = true;
                    _8400_System_On = "84000001";
                    Tx_data[RegisterSequencyCounter] = int.Parse(_8400_System_On, styleHex); RegisterSequencyCounter++;
                    _8400_System_On = "84000000";
                    Tx_data[RegisterSequencyCounter] = int.Parse(_8400_System_On, styleHex); RegisterSequencyCounter++;
                    writeSendFlag = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exepction : {0}", ex);
            }
        }

        private void CH1_Reset_Click(object sender, EventArgs e)
        {
            SendParameterReset();
            GraphicImagingDataReset();
        }


    }
}
