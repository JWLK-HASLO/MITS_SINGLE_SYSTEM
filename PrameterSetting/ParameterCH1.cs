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
        static System.Globalization.NumberStyles styleInteger = System.Globalization.NumberStyles.Integer;
        static System.Globalization.NumberStyles styleHex = System.Globalization.NumberStyles.HexNumber;


        //*/Register String 
        string _8400_System_On = null;
        string _8401_Rx_Data = null;

        string _8402_PRF_L = null;
        string _8403_PRF_H = null;
        string _8413_ScanLine_Data = null;
        string _8414_ScanLine_Reset = null;

        string _8C00_PulseLength = null;
        string _8C01_DampLength = null;
        string _8C02_CycleLength = null;


        //*/ AFE
        string _A000_AFE_EN = null;
        string _A0A1_AFE_Reg_00 = null;
        string _A0A2_AFE_Reg_35 = null;
        string _A0A3_AFE_Reg_3B = null;

        string _A004_AFE_Pulse_EN = null;


        //*/ ADC
        string _A007_ADC_Reg_03 = null;
        string _A022_ADC_Reg_25 = null;
        string _A009_ADC_Reg_29 = null;

        string _A00A_ADC_Reg_2B = null;
        string _A00B_ADC_Reg_3D = null;
        string _A00C_ADC_Reg_3F = null;
        string _A00D_ADC_Reg_40 = null;
        string _A00E_ADC_Reg_41 = null;

        string _A021_ADC_Reg_42 = null;
        string _A010_ADC_Reg_45 = null;

        string _A011_ADC_Reg_4A = null;
        string _A012_ADC_Reg_58 = null;
        string _A013_ADC_Reg_BF = null;
        string _A014_ADC_Reg_C1 = null;
        string _A015_ADC_Reg_CF = null;
        string _A016_ADC_Reg_EF = null;
        string _A017_ADC_Reg_F1 = null;
        string _A018_ADC_Reg_F2 = null;
        string _A019_ADC_Reg_02 = null;
        string _A01A_ADC_Reg_D5 = null;
        string _A01B_ADC_Reg_D7 = null;
        string _A01C_ADC_Reg_DB = null;

        string _A01D_ADC_EN = null;
        string _A01E_ADC_Pulse_EN = null;

        string _A02F_ADC_Reg_00 = null;
        string _A02A_ADC_Reg_01 = null;


        //*/ DAC
        string _8800_DAC_Conf = null;
        string _8801_DAC_ON = null;
        string _8802_DAC_Data = null;

        //*/ Clock
        string _9400_Clock_EN = null;
        string _9401_Reg_07 = null;
        string _9402_Reg_08 = null;
        string _9403_Reg_09 = null;
        string _9404_Reg_10 = null;
        string _9405_Reg_11 = null;
        string _9406_Reg_12 = null;

        string _940F_I2C_EN = null;



        //*/Mode Select
        bool CH1_Mode_Select = true;
        //*/

        //*/Tx Parameter
        int CH1_Scanline_data = 0;
        int CH1_PRF_data = 0;
        int CH1_CF_data = 0;
        int CH1_PulseDamp_data = 2;
        int CH1_PulseCycles_data = 0;
        int CH1_PulseDuration_data = 0;
        int CH1_DynamicRange_data = 0;
        string CH1_ViewDepth_data = null;
        //*/

        //*/View Depth Factor
        int CH1_Rx_data = 0;
        int CH1_CM_Length = 0;
        int CH1_CM_Divider = 0;
        //*/



        //*/AFE Parameter
        string CH1_LPF_data = null;
        string CH1_PGA_data = null;
        string CH1_ADC_data = null;
        //*/

        //*/High Volatage Parameter
        bool CH1_HV_Select = true;
        int CH1_HV_data = 0;
        //*/
        
        public void CH1_ParameterInit()
        {
            //*/TxParameter Init
            CH1_ModeSelect(true);
            CH1_Scanline.Text = "10";
            CH1_PRF.Text = "100";
            CH1_CF.Text = "20";
            CH1_PulseCycles.Text = "2";
            CH1_PulseDuration.Text = "10";
            CH1_DynamicRange.Text = "50";
            CH1_ViewDepth.Text = "~2cm";

            //*/AFE Parameter Init
            CH1_LPF.Text = "60Mhz";
            CH1_PGAGain.Text = "18dB";
            CH1_ADCGain.Text = "6dB";

            //*/High Voltage Parameter Init
            HV_ModeSelect(true);
            CH1_HVLevel.Text = "30";

        }

        public void CH1_ModeSelect(bool Checked)
        {
            if (Checked)
            {
                CH1_Mode_Select = true;
                CH1_Mode_Imaging.Checked = true;
                CH1_Mode_Stimul.Checked = false;

                CH1_PulseCycles.Enabled = true;
                CH1_PulseDuration.Enabled = false;
                groupBox_CH1_AFE.Enabled = true;
                CH1_ViewDepth.Enabled = true;

                CH1_ScanControl.Enabled = true;
                CH1_PulseControl.Enabled = false;
            } 
            else
            {
                CH1_Mode_Select = false;
                CH1_Mode_Imaging.Checked = false;
                CH1_Mode_Stimul.Checked = true;

                CH1_PulseCycles.Enabled = false;
                CH1_PulseDuration.Enabled = true;
                groupBox_CH1_AFE.Enabled = false;
                CH1_ViewDepth.Enabled = false;

                CH1_ScanControl.Enabled = false;
                CH1_PulseControl.Enabled = true;
            }
        }

        public void CH1_StimulParameterLoad()
        {
            _8403_PRF_H = String.Format("8403{0}", ((100000000 / CH1_PRF_data - 1).ToString("X8")).Substring(0, 4));
            _8402_PRF_L = String.Format("8402{0}", ((100000000 / CH1_PRF_data - 1).ToString("X8")).Substring(4, 4));

            Tx_data[RegisterSequencyCounter] = int.Parse(_8403_PRF_H, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_8402_PRF_L, styleHex); RegisterSequencyCounter++;

            _8C00_PulseLength = String.Format("8C00{0}", (250 / (CH1_CF_data * 2) - 3).ToString("X4"));
            _8C01_DampLength = String.Format("8C01{0}", (CH1_PulseDamp_data - 1).ToString("X4"));
            _8C02_CycleLength = String.Format("8C02{0}", (CH1_CF_data * CH1_PulseDuration_data - 1).ToString("X4"));

            Tx_data[RegisterSequencyCounter] = int.Parse(_8C00_PulseLength, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_8C01_DampLength, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_8C02_CycleLength, styleHex); RegisterSequencyCounter++;


        }

        public void CH1_TxParameterLoad()
        {
            _8413_ScanLine_Data = String.Format("8413{0}", (CH1_Scanline_data - 1).ToString("X4"));
            Tx_data[RegisterSequencyCounter] = int.Parse(_8413_ScanLine_Data, styleHex); RegisterSequencyCounter++;

            _8403_PRF_H = String.Format("8403{0}", ((100000000 / CH1_PRF_data - 1).ToString("X8")).Substring(0,4));
            _8402_PRF_L = String.Format("8402{0}", ((100000000 / CH1_PRF_data - 1).ToString("X8")).Substring(4, 4));

            Tx_data[RegisterSequencyCounter] = int.Parse(_8403_PRF_H, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_8402_PRF_L, styleHex); RegisterSequencyCounter++;
            
            _8C00_PulseLength = String.Format("8C00{0}", (250 / (CH1_CF_data * 2) - 3).ToString("X4"));
            _8C01_DampLength = String.Format("8C01{0}", (CH1_PulseDamp_data - 1).ToString("X4"));
            _8C02_CycleLength = String.Format("8C02{0}", (CH1_PulseCycles_data - 1).ToString("X4"));

            Tx_data[RegisterSequencyCounter] = int.Parse(_8C00_PulseLength, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_8C01_DampLength, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_8C02_CycleLength, styleHex); RegisterSequencyCounter++;

            _8401_Rx_Data = String.Format("8401{0}", (CH1_Rx_data - 1).ToString("X4"));
            Tx_data[RegisterSequencyCounter] = int.Parse(_8401_Rx_Data, styleHex); RegisterSequencyCounter++;
        }

        public void CH1_AFELoad()
        {
            _A0A1_AFE_Reg_00 = "A0A10000";
            _A0A2_AFE_Reg_35 = "A0A20000";
            Tx_data[RegisterSequencyCounter] = int.Parse(_A0A1_AFE_Reg_00, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_A0A2_AFE_Reg_35, styleHex); RegisterSequencyCounter++;

            //AFE SET From MITS_SYSTEM FILE
            Tx_data[RegisterSequencyCounter] = int.Parse(_A0A3_AFE_Reg_3B, styleHex); RegisterSequencyCounter++;

            _A004_AFE_Pulse_EN = "A004001";
            Tx_data[RegisterSequencyCounter] = int.Parse(_A004_AFE_Pulse_EN, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_A004_AFE_Pulse_EN, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_A004_AFE_Pulse_EN, styleHex); RegisterSequencyCounter++;
            _A004_AFE_Pulse_EN = "A004000";
            Tx_data[RegisterSequencyCounter] = int.Parse(_A004_AFE_Pulse_EN, styleHex); RegisterSequencyCounter++;

        }

        public void CH1_ADCLoad()
        {
            _A02F_ADC_Reg_00 = "A02F0001"; /// ?
            _A02A_ADC_Reg_01 = "A02A0100";
            _A007_ADC_Reg_03 = "A0070303";
            Tx_data[RegisterSequencyCounter] = int.Parse(_A02F_ADC_Reg_00, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_A02A_ADC_Reg_01, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_A007_ADC_Reg_03, styleHex); RegisterSequencyCounter++;

            //ADC SET From MITS_SYSTEM FILE
            Tx_data[RegisterSequencyCounter] = int.Parse(_A022_ADC_Reg_25, styleHex); RegisterSequencyCounter++;
           
            //Delay 1 Clock
            RegisterSequencyCounter++;

            _A009_ADC_Reg_29 = "A0092918";
            Tx_data[RegisterSequencyCounter] = int.Parse(_A009_ADC_Reg_29, styleHex); RegisterSequencyCounter++;

            _A00B_ADC_Reg_3D = "A00B3D00";
            _A00C_ADC_Reg_3F = "A00C3F00";
            _A00D_ADC_Reg_40 = "A00D4000";
            _A00E_ADC_Reg_41 = "A00E41C0";
            _A021_ADC_Reg_42 = "A0214208";
            Tx_data[RegisterSequencyCounter] = int.Parse(_A00B_ADC_Reg_3D, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_A00C_ADC_Reg_3F, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_A00D_ADC_Reg_40, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_A00E_ADC_Reg_41, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_A021_ADC_Reg_42, styleHex); RegisterSequencyCounter++;

            _A010_ADC_Reg_45 = "A0104500";
            _A011_ADC_Reg_4A = "A0114A00";
            _A012_ADC_Reg_58 = "A0125800";
            _A013_ADC_Reg_BF = "A013BF00";
            _A014_ADC_Reg_C1 = "A014C100";
            _A015_ADC_Reg_CF = "A015CF00";
            _A016_ADC_Reg_EF = "A016EF00";
            _A017_ADC_Reg_F1 = "A017F101";
            _A018_ADC_Reg_F2 = "A018F200";
            Tx_data[RegisterSequencyCounter] = int.Parse(_A010_ADC_Reg_45, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_A011_ADC_Reg_4A, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_A012_ADC_Reg_58, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_A013_ADC_Reg_BF, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_A014_ADC_Reg_C1, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_A015_ADC_Reg_CF, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_A016_ADC_Reg_EF, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_A017_ADC_Reg_F1, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_A018_ADC_Reg_F2, styleHex); RegisterSequencyCounter++;


            // Hipefo ?
            _A019_ADC_Reg_02 = "A0190200";
            _A01A_ADC_Reg_D5 = "A01AD500";
            _A01B_ADC_Reg_D7 = "A01BD700";
            _A01C_ADC_Reg_DB = "A01CDB00";
            Tx_data[RegisterSequencyCounter] = int.Parse(_A019_ADC_Reg_02, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_A01A_ADC_Reg_D5, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_A01B_ADC_Reg_D7, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_A01C_ADC_Reg_DB, styleHex); RegisterSequencyCounter++;

            _A01E_ADC_Pulse_EN = "A01E0001";
            Tx_data[RegisterSequencyCounter] = int.Parse(_A01E_ADC_Pulse_EN, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_A01E_ADC_Pulse_EN, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_A01E_ADC_Pulse_EN, styleHex); RegisterSequencyCounter++;

            //Delay 1 Clock
            RegisterSequencyCounter++;

            _A01E_ADC_Pulse_EN = "A01E0000";
            Tx_data[RegisterSequencyCounter] = int.Parse(_A01E_ADC_Pulse_EN, styleHex); RegisterSequencyCounter++;

        }

        private void CH1_ClockLoad()
        {
            _9400_Clock_EN = "94000000";
            _9401_Reg_07   = "94010022";
            _9402_Reg_08   = "94020042";
            _9403_Reg_09   = "940300BC";
            _9404_Reg_10   = "94040001";
            _9405_Reg_11   = "9405001E";
            _9406_Reg_12   = "940600B8";
            _940F_I2C_EN   = "940F0001";

            Tx_data[RegisterSequencyCounter] = int.Parse(_9400_Clock_EN, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_9401_Reg_07, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_9402_Reg_08, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_9403_Reg_09, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_9404_Reg_10, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_9405_Reg_11, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_9406_Reg_12, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_940F_I2C_EN, styleHex); RegisterSequencyCounter++;

            //Delay 1 Clock
            RegisterSequencyCounter+=10;

            _940F_I2C_EN   = "940F0000";
            _9400_Clock_EN = "94000001";
            Tx_data[RegisterSequencyCounter] = int.Parse(_9400_Clock_EN, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_940F_I2C_EN, styleHex); RegisterSequencyCounter++;


        }

        public void HV_ModeSelect(bool Checked)
        {
            if(Checked)
            {
                CH1_HV_Select = true;
                CH1_HV_Internal.Checked = true;
                CH1_HV_External.Checked = false;

            }
            else
            {
                CH1_HV_Select = false;
                CH1_HV_Internal.Checked = false;
                CH1_HV_External.Checked = true;

            }
        }

        public void CH1_HVLoad()
        {
            _8800_DAC_Conf = "88000001";
            _8802_DAC_Data = String.Format("88020{0}0", CH1_HV_data.ToString("X2"));
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

        
        public void CH1_ReisterSet()
        {
            SendParameterReset();

            CH1_HVLoad();
            CH1_HVInterface(false);

            /*/8005_DebugMode
            _8005_DebugMode = "80050001";
            Tx_data[RegisterSequencyCounter] = int.Parse(_8005_DebugMode, styleHex); RegisterSequencyCounter++;
            //*/

            CH1_TxParameterLoad();
            CH1_AFELoad();
            CH1_ADCLoad();
            CH1_ClockLoad();

            //Console.WriteLine(String.Format("RegisterSequencyCounter:{0}", RegisterSequencyCounter));
            SystemLogBox.AppendText(String.Format("RegisterSequencyCounter:{0}", RegisterSequencyCounter) + "\r\n");
        }


        bool HV_Loop = false;
        public void CH1_HVInterface(bool ClickCheck)
        {
            if(ClickCheck == false)
            {
                CH1_VolatageControl.Text = "HV OFF";
                CH1_VolatageControl.BackColor = Color.CornflowerBlue;
                HV_Loop = true;
            }
            else if(ClickCheck == true)
            {
                CH1_VolatageControl.Text = "HV ON";
                CH1_VolatageControl.BackColor = Color.Brown;
                HV_Loop = false;
            }
        }

        bool Pulser_Loop = false;
        public void CH1_PulserInterface(bool ClickCheck)
        {
            if (ClickCheck == false)
            {
                CH1_PulseControl.Text = "Pulser OFF";
                CH1_PulseControl.BackColor = Color.CornflowerBlue;
                Pulser_Loop = true;
            }
            else if (ClickCheck == true)
            {
                CH1_PulseControl.Text = "Pulser ON";
                CH1_PulseControl.BackColor = Color.DarkSlateBlue;
                Pulser_Loop = false;
            }
        }

        bool SCAN_Loop = false;
        public void CH1_SCANInterface(bool ClickCheck)
        {
            if (ClickCheck == false)
            {
                CH1_ScanControl.Text = "SCAN START";
                CH1_ScanControl.BackColor = Color.Black;
                SCAN_Loop = true;
            }
            else if (ClickCheck == true)
            {
                CH1_ScanControl.Text = "SCAN SET";
                CH1_ScanControl.BackColor = Color.FromArgb(64,64,64);
                SCAN_Loop = false;
            }
        }

    }
}
