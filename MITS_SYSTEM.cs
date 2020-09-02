﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            CH2_ParameterInit();
            SendParameterReset();
            SendParameterTestReset();
            FormChangedInit();
            ProcessingBaseToolInit();
            GraphicConvertInit();
            color_initialize();
            timer_initialize();
            MotorControlInit();

        }

        /* MAIN Tab Button Control */


        private void MITS_SYSTEM_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (HV_Loop)
            {
                MessageBox.Show("HV Not Disabled.\nPlease Click HV OFF Button", "Warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        //*/ Channel 2

        //*/Mode Select Changed
        private void CH2_Mode_Imaging_CheckedChanged(object sender, EventArgs e)
        {
            CH2_ModeSelect(CH2_Mode_Imaging.Checked);
            Console.WriteLine(String.Format("CH2_Mode_Imaging: {0}", CH2_Mode_Imaging.Checked));
        }

        private void CH2_Mode_Stimul_CheckedChanged(object sender, EventArgs e)
        {
            CH2_ModeSelect(!CH2_Mode_Stimul.Checked);
            Console.WriteLine(String.Format("CH2_Mode_Stimul: {0}", CH2_Mode_Stimul.Checked));
        }
        //*/

        //*/N of Scanline Changed
        private void CH2_Scanline_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CH2_Scanline_data = int.Parse(string.Format("{0:D}", CH2_Scanline.Text), styleInteger);
                Console.WriteLine(String.Format("CH2_Scanline_data: {0}", CH2_Scanline_data));
                ConvertSaveArray = new double[CH2_Scanline_data][];
                for (int i = 0; i < ConvertSaveArray.GetLength(0); i++)
                {
                    ConvertSaveArray[i] = new double[CH2_CM_Length / CH2_CM_Divider];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exepction : {0}", ex);
            }
        }
        //*/

        //*/PRF Changed
        private void CH2_PRF_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CH2_PRF_data = int.Parse(string.Format("{0:D}", CH2_PRF.Text), styleInteger);
                Console.WriteLine(String.Format("CH2_PRF_data: {0}", CH2_PRF_data));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exepction : {0}", ex);
            }
        }
        //*/

        //*/Center Frequency Changed
        private void CH2_CF_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                CH2_CF_data = int.Parse(string.Format("{0:D}", CH2_CF.Text), styleInteger);
                Console.WriteLine(String.Format("CH2_CF_data: {0}", CH2_CF_data));


            }
            catch (Exception ex)
            {
                Console.WriteLine("Exepction : {0}", ex);
            }
        }
        //*/

        //*/Pulse Cycle & Pulse Dulation Changed
        private void CH2_PulseCycles_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                CH2_PulseCycles_data = int.Parse(string.Format("{0:D}", CH2_PulseCycles.Text), styleInteger);
                Console.WriteLine(String.Format("CH2_PulseCycles_data: {0}", CH2_PulseCycles_data));

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exepction : {0}", ex);
            }

        }

        private void CH2_PulseDuration_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CH2_PulseDuration_data = int.Parse(string.Format("{0:D}", CH2_PulseDuration.Text), styleInteger);

                Console.WriteLine(String.Format("CH2_PulseDuration_data: {0}", CH2_PulseDuration_data));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception : {0}", ex);
            }
        }
        //*/

        //*/Dynamic Range Changed
        private void CH2_DynamicRange_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CH2_DynamicRange_data = int.Parse(string.Format("{0:D}", CH2_DynamicRange.Text), styleInteger);
                Console.WriteLine(String.Format("CH2_DynamicRange_data: {0}", CH2_DynamicRange_data));
                xMin = Math.Pow(10.0, (-CH2_DynamicRange_data / 20)) * xMax;
                LogRange = Math.Log10(xMax / xMin);
                Console.WriteLine("LogRange {0}", LogRange);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exepction : {0}", ex);
            }
        }
        //*/

        //*/View Depth Changed
        private void CH2_ViewDepth_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                CH2_ViewDepth_data = string.Format("{0:D}", CH2_ViewDepth.Text);
                Console.WriteLine(String.Format("CH2_ViewDepth_data: {0}", CH2_ViewDepth_data));

                switch (CH2_ViewDepth_data)
                {
                    case "None":
                        // ParameterCH2
                        CH2_Rx_data = 0;
                        CH2_CM_Divider = 1;
                        CH2_CM_Length = 0 * CH2_CM_Divider;
                        //BaseTool
                        LPF_DECI_Load = File.ReadAllLines("LPF_DECI2.txt");
                        // ProcessingTool
                        getData = new double[CH2_CM_Length];
                        ConvolveHPFLength = CH2_CM_Length + HPF_Length - 1;
                        ConvolveLPF_QD_Length = CH2_CM_Length + LPF_QD_Length - 1;
                        Envelope = new double[CH2_CM_Length / CH2_CM_Divider];
                        ScanlineConvertData = new double[CH2_CM_Length / CH2_CM_Divider];
                        ConvertSaveArray = new double[CH2_Scanline_data][];
                        for (int i = 0; i < ConvertSaveArray.GetLength(0); i++)
                        {
                            ConvertSaveArray[i] = new double[CH2_CM_Length / CH2_CM_Divider];
                        }
                        cos = new double[CH2_CM_Length];
                        sin = new double[CH2_CM_Length];
                        break;
                    case "~1cm":
                        // ParameterCH2
                        CH2_Rx_data = 4096;
                        CH2_CM_Divider = 1;
                        CH2_CM_Length = 1331 * CH2_CM_Divider;
                        //BaseTool
                        LPF_DECI_Load = File.ReadAllLines("LPF_DECI2.txt");
                        // ProcessingTool
                        getData = new double[CH2_CM_Length];
                        ConvolveHPFLength = CH2_CM_Length + HPF_Length - 1;
                        ConvolveLPF_QD_Length = CH2_CM_Length + LPF_QD_Length - 1;
                        ConvolveLPF_DECI_Length = CH2_CM_Length + LPF_DECI_Length - 1;
                        Envelope = new double[CH2_CM_Length / CH2_CM_Divider];
                        ScanlineConvertData = new double[CH2_CM_Length / CH2_CM_Divider];
                        ConvertSaveArray = new double[CH2_Scanline_data][];
                        for (int i = 0; i < ConvertSaveArray.GetLength(0); i++)
                        {
                            ConvertSaveArray[i] = new double[CH2_CM_Length / CH2_CM_Divider];
                        }
                        cos = new double[CH2_CM_Length];
                        sin = new double[CH2_CM_Length];
                        break;
                    case "~2cm":
                        // ParameterCH2
                        CH2_Rx_data = 4096;
                        CH2_CM_Divider = 2;
                        CH2_CM_Length = 1331 * CH2_CM_Divider;
                        //BaseTool
                        LPF_DECI_Load = File.ReadAllLines("LPF_DECI2.txt");
                        // ProcessingTool
                        getData = new double[CH2_CM_Length];
                        Envelope = new double[CH2_CM_Length / CH2_CM_Divider];
                        ScanlineConvertData = new double[CH2_CM_Length / CH2_CM_Divider];
                        ConvertSaveArray = new double[CH2_Scanline_data][];
                        for (int i = 0; i < ConvertSaveArray.GetLength(0); i++)
                        {
                            ConvertSaveArray[i] = new double[CH2_CM_Length / CH2_CM_Divider];
                        }
                        cos = new double[CH2_CM_Length];
                        sin = new double[CH2_CM_Length];
                        break;
                    case "~3cm":
                        // ParameterCH2
                        CH2_Rx_data = 4096;
                        CH2_CM_Divider = 3;
                        CH2_CM_Length = 1331 * CH2_CM_Divider;
                        //BaseTool
                        LPF_DECI_Load = File.ReadAllLines("LPF_DECI3.txt");
                        // ProcessingTool
                        getData = new double[CH2_CM_Length];
                        ConvolveHPFLength = CH2_CM_Length + HPF_Length - 1;
                        ConvolveLPF_QD_Length = CH2_CM_Length + LPF_QD_Length - 1;
                        ConvolveLPF_DECI_Length = CH2_CM_Length + LPF_DECI_Length - 1;
                        Envelope = new double[CH2_CM_Length / CH2_CM_Divider];
                        ScanlineConvertData = new double[CH2_CM_Length / CH2_CM_Divider];
                        ConvertSaveArray = new double[CH2_Scanline_data][];
                        for (int i = 0; i < ConvertSaveArray.GetLength(0); i++)
                        {
                            ConvertSaveArray[i] = new double[CH2_CM_Length / CH2_CM_Divider];
                        }
                        cos = new double[CH2_CM_Length];
                        sin = new double[CH2_CM_Length];
                        break;
                    case "~4cm":
                        // ParameterCH2
                        CH2_Rx_data = 8192;
                        CH2_CM_Divider = 4;
                        CH2_CM_Length = 1331 * CH2_CM_Divider;
                        //BaseTool
                        LPF_DECI_Load = File.ReadAllLines("LPF_DECI4.txt");
                        // ProcessingTool
                        getData = new double[CH2_CM_Length];
                        ConvolveHPFLength = CH2_CM_Length + HPF_Length - 1;
                        ConvolveLPF_QD_Length = CH2_CM_Length + LPF_QD_Length - 1;
                        ConvolveLPF_DECI_Length = CH2_CM_Length + LPF_DECI_Length - 1;
                        Envelope = new double[CH2_CM_Length / CH2_CM_Divider];
                        ScanlineConvertData = new double[CH2_CM_Length / CH2_CM_Divider];
                        ConvertSaveArray = new double[CH2_Scanline_data][];
                        for (int i = 0; i < ConvertSaveArray.GetLength(0); i++)
                        {
                            ConvertSaveArray[i] = new double[CH2_CM_Length / CH2_CM_Divider];
                        }
                        cos = new double[CH2_CM_Length];
                        sin = new double[CH2_CM_Length];
                        break;
                }
                Console.WriteLine(String.Format("CH2_Rx_data: {0} / CH2_CM_Length: {1} / CH2_CM_Divider: {2} ", CH2_Rx_data, CH2_CM_Length, CH2_CM_Divider));

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exepction : {0}", ex);
            }
        }
        //*/



        //*/AFE - LPF, PGA Gain, ADC Gain Changed
        private void CH2_LPF_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                CH2_LPF_data = string.Format("{0:D}", CH2_LPF.Text);
                CH2_PGA_data = string.Format("{0:D}", CH2_PGAGain.Text);
                Console.WriteLine(String.Format("CH2_LPF_data: {0}", CH2_LPF_data));

                switch (CH2_LPF_data)
                {
                    case "60MHz":
                        switch (CH2_PGA_data)
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
                        switch (CH2_PGA_data)
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

        private void CH2_PGAGain_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                CH2_LPF_data = string.Format("{0:D}", CH2_LPF.Text);
                CH2_PGA_data = string.Format("{0:D}", CH2_PGAGain.Text);
                Console.WriteLine(String.Format("CH2_PGA_data: {0}", CH2_PGA_data));

                switch (CH2_LPF_data)
                {
                    case "60MHz":
                        switch (CH2_PGA_data)
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
                        switch (CH2_PGA_data)
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

        private void CH2_ADCGain_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                CH2_ADC_data = string.Format("{0:D}", CH2_ADCGain.Text);
                Console.WriteLine(String.Format("CH2_ADC_data: {0}", CH2_ADC_data));

                switch (CH2_ADC_data)
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

        //*/High Voltage Changed
        int inputHVData_CH2 = 0;
        double CalHV_CH2 = 0.0;
        private void CH2_HVLevel_TextChanged(object sender, EventArgs e)
        {
            try
            {
                inputHVData_CH2 = int.Parse(string.Format("{0:D}", CH2_HVLevel.Text), styleInteger);
                CalHV_CH2 = ((double)inputHVData_CH2 * 2.933) + 0.063;
                Console.WriteLine(String.Format("inputHVData_CH2: {0} / Cal_HV_data_CH2: {1}", inputHVData_CH2, CalHV_CH2));

                CH2_HV_data = (int)CalHV_CH2;
                Console.WriteLine(String.Format("CH2_HV_data: {0}", CH2_HV_data));

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exepction : {0}", ex);
            }

        }

        private void CH2_VolatageControl_Click(object sender, EventArgs e)
        {

            try
            {
                CH2_HVInterface(HV_Loop_CH2);
                if (HV_Loop_CH2)
                {
                    SendParameterReset();
                    CH2_HVLoad();
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

        private void CH2_PulseControl_Click(object sender, EventArgs e)
        {

            try
            {
                CH2_PulserInterface(Pulser_Loop_CH2);
                //CH2_HVInterface(HV_Loop);
                if (Pulser_Loop_CH2)
                {
                    SendParameterReset();
                    //CH2_HVLoad();
                    CH2_StimulParameterLoad();
                    RegisterSequencyCounter++;
                    RegisterSequencyCounter++;
                    RegisterSequencyCounter++;
                    RegisterSequencyCounter++;
                    RegisterSequencyCounter++;

                    _8404_System_On = "84040001";
                    Tx_data[RegisterSequencyCounter] = int.Parse(_8404_System_On, styleHex); RegisterSequencyCounter++;
                    writeSendFlag = true;

                }
                else
                {
                    SendParameterReset();
                    //_8801_DAC_ON = "88010000";
                    //Tx_data[RegisterSequencyCounter] = int.Parse(_8801_DAC_ON, styleHex); RegisterSequencyCounter++;
                    _8404_System_On = "84040000";
                    Tx_data[RegisterSequencyCounter] = int.Parse(_8404_System_On, styleHex); RegisterSequencyCounter++;
                    writeSendFlag = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exepction : {0}", ex);
            }
        }

        private void CH2_Reset_Click(object sender, EventArgs e)
        {
            SendParameterReset();
            //CH2_SCANInterface(true);
            /*Draw Reset*/
            if (graphicDrawThread != null)
            {
                graphicDrawThread.Abort();
                graphicDrawThread.Join();
                graphicDrawThread = null;
                GraphicImagingDataReset();

            }

            MessageBox.Show("초기화 되었습니다.", "완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
