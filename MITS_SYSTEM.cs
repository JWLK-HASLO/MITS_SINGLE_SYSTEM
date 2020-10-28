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


    }

}
