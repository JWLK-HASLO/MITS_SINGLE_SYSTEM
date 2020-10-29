using System;
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
            motor_timer_initialize();
            MotorControlInit();
            StageControlInit();

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


        StreamWriter streamWriter;

        private void button_data_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (timer.Enabled == false)
                {
                    if (MessageBox.Show("데이터를 저장 하시겠습니까?", "데이터 저장", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        streamWriter.Flush();
                        streamWriter.Close();
                        SaveFileDialog savefile = new SaveFileDialog();
                        savefile.InitialDirectory = Application.StartupPath + @"\data\";
                        savefile.Title = "파일 저장";
                        savefile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                        savefile.DefaultExt = "txt";
                        savefile.AddExtension = true;

                        if (savefile.ShowDialog() == DialogResult.OK)
                        {
                            File.Move(Application.StartupPath + @"\data\temp_data.txt", savefile.FileName);
                            MessageBox.Show("저장을 완료하였습니다.", "완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("저장하는데 문제가 발생하였습니다.", "완료", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                }
                else
                {
                    Console.WriteLine("STOP!!!");
                    MessageBox.Show("데이터 스트림을 멈춘 후 다시 시도해 주시기 바랍니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //button_record_play.Focus();
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(exception.Message);
            }
        }
    }

}
