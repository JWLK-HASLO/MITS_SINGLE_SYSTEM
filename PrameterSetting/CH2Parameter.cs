using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MITS_SINGLE_SYSTEM
{
    public partial class MITS_SYSTEM
    {
        //*/Register String 
        string _8404_System_On = null;
        string _8405_Rx_Data = null;

        string _8406_PRF_L = null;
        string _8407_PRF_H = null;
        string _8408_Delay = null;

        string _9000_PulseLength = null;
        string _9001_DampLength = null;
        string _9002_CycleLength = null;
        //*/ 


        //*/Set Value
        //*/Mode Select
        bool CH2_Mode_Select = true;
        //*/

        //*/Tx Parameter
        int CH2_Scanline_data = 0;
        int CH2_PRF_data = 0;
        int CH2_CF_data = 0;
        int CH2_PulseDamp_data = 2;
        int CH2_PulseCycles_data = 0;
        int CH2_PulseDuration_data = 0;
        int CH2_DynamicRange_data = 0;
        string CH2_ViewDepth_data = null;
        //*/

        //*/View Depth Factor
        int CH2_Rx_data = 0;
        int CH2_CM_Length = 0;
        int CH2_CM_Divider = 0;
        //*/



        //*/AFE Parameter
        string CH2_LPF_data = null;
        string CH2_PGA_data = null;
        string CH2_ADC_data = null;
        //*/

        //*/High Volatage Parameter
        bool CH2_HV_Select = true;
        int CH2_HV_data = 0;
        //*/

        public void CH2_ParameterInit()
        {
            //*/TxParameter Init
            CH2_ModeSelect(false);
            CH2_Scanline.Text = "400";
            CH2_PRF.Text = "500";
            CH2_CF.Text = "5";
            CH2_PulseCycles.Text = "20";
            CH2_PulseDuration.Text = "2";
            CH2_DynamicRange.Text = "50";
            CH2_ViewDepth.Text = "~2cm";

            //*/AFE Parameter Init
            CH2_LPF.Text = "60Mhz";
            CH2_PGAGain.Text = "18dB";
            CH2_ADCGain.Text = "6dB";

            //*/High Voltage Parameter Init
            HV_ModeSelect(true);
            CH2_HVLevel.Text = "30";
        }


        public void CH2_ModeSelect(bool Checked)
        {
            if (Checked)
            {
                CH2_Mode_Select = true;
                CH2_Mode_Imaging.Checked = true;
                CH2_Mode_Stimul.Checked = false;

                CH2_PulseCycles.Enabled = true;
                CH2_PulseDuration.Enabled = false;
                groupBox_CH2_AFE.Enabled = true;
                CH2_DynamicRange.Enabled = true;
                CH2_ViewDepth.Enabled = true;

                CH2_ScanControl.Enabled = true;
                CH2_PulseControl.Enabled = false;
            }
            else
            {
                CH2_Mode_Select = false;
                CH2_Mode_Imaging.Checked = false;
                CH2_Mode_Stimul.Checked = true;

                CH2_PulseCycles.Enabled = false;
                CH2_PulseDuration.Enabled = true;
                groupBox_CH2_AFE.Enabled = false;
                CH2_DynamicRange.Enabled = false;
                CH2_ViewDepth.Enabled = false;

                CH2_ScanControl.Enabled = false;
                CH2_PulseControl.Enabled = true;
            }
        }

        public void CH2_StimulParameterLoad()
        {
            _8407_PRF_H = String.Format("8407{0}", ((100000000 / CH2_PRF_data - 1).ToString("X8")).Substring(0, 4));
            _8406_PRF_L = String.Format("8406{0}", ((100000000 / CH2_PRF_data - 1).ToString("X8")).Substring(4, 4));

            Tx_data[RegisterSequencyCounter] = int.Parse(_8407_PRF_H, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_8406_PRF_L, styleHex); RegisterSequencyCounter++;

            _9000_PulseLength = String.Format("9000{0}", (250 / (CH2_CF_data * 2) - 3).ToString("X4"));
            _9001_DampLength = String.Format("9001{0}", (CH2_PulseDamp_data - 1).ToString("X4"));
            _9002_CycleLength = String.Format("9002{0}", (CH2_CF_data * CH2_PulseDuration_data - 1).ToString("X4"));

            Tx_data[RegisterSequencyCounter] = int.Parse(_9000_PulseLength, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_9001_DampLength, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_9002_CycleLength, styleHex); RegisterSequencyCounter++;


        }

        public void HV_ModeSelect_CH2(bool Checked)
        {
            if (Checked)
            {
                CH2_HV_Select = true;
                CH2_HV_Internal.Checked = true;
                CH2_HV_External.Checked = false;

            }
            else
            {
                CH2_HV_Select = false;
                CH2_HV_Internal.Checked = false;
                CH2_HV_External.Checked = true;

            }
        }

        public void CH2_HVLoad()
        {
            _8800_DAC_Conf = "88000001";
            _8802_DAC_Data = String.Format("88020{0}0", CH2_HV_data.ToString("X2"));
            //Console.WriteLine("_8802_DAC_Data : " + _8802_DAC_Data);

            Tx_data[RegisterSequencyCounter] = int.Parse(_8800_DAC_Conf, styleHex); RegisterSequencyCounter++;
            //Delay 1 Clock
            RegisterSequencyCounter++;

            Tx_data[RegisterSequencyCounter] = int.Parse(_8802_DAC_Data, styleHex); RegisterSequencyCounter++;

            _8800_DAC_Conf = "88000000";
            Tx_data[RegisterSequencyCounter] = int.Parse(_8800_DAC_Conf, styleHex); RegisterSequencyCounter++;

            _8801_DAC_ON = "88010001";
            Tx_data[RegisterSequencyCounter] = int.Parse(_8801_DAC_ON, styleHex); RegisterSequencyCounter++;

        }



        bool HV_Loop_CH2 = false;
        public void CH2_HVInterface(bool ClickCheck)
        {
            if (ClickCheck == false)
            {
                CH2_VolatageControl.Text = "HV OFF";
                CH2_VolatageControl.BackColor = Color.CornflowerBlue;
                HV_Loop_CH2 = true;
            }
            else if (ClickCheck == true)
            {
                CH2_VolatageControl.Text = "HV ON";
                CH2_VolatageControl.BackColor = Color.Brown;
                HV_Loop_CH2 = false;
            }
        }

        bool Pulser_Loop_CH2 = false;
        public void CH2_PulserInterface(bool ClickCheck)
        {
            if (ClickCheck == false)
            {
                CH2_PulseControl.Text = "Pulser OFF";
                CH2_PulseControl.BackColor = Color.CornflowerBlue;
                Pulser_Loop_CH2 = true;
            }
            else if (ClickCheck == true)
            {
                CH2_PulseControl.Text = "Pulser ON";
                CH2_PulseControl.BackColor = Color.DarkSlateBlue;
                Pulser_Loop_CH2 = false;
            }
        }



    }

}
