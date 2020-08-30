namespace MITS_SINGLE_SYSTEM
{
    partial class MITS_SYSTEM
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.GraphicGroup = new System.Windows.Forms.GroupBox();
            this.groupBox_ImagingView = new System.Windows.Forms.GroupBox();
            this.ImagingBox = new System.Windows.Forms.PictureBox();
            this.groupBox_BoardData = new System.Windows.Forms.GroupBox();
            this.SystemBoardOUTEndpoint = new System.Windows.Forms.ComboBox();
            this.SystemBoardINEndpoint = new System.Windows.Forms.ComboBox();
            this.SystemBoardConnection = new System.Windows.Forms.ComboBox();
            this.label_OutEndpoint = new System.Windows.Forms.Label();
            this.label_InEndpoint = new System.Windows.Forms.Label();
            this.label_SystemBoard = new System.Windows.Forms.Label();
            this.groupBox_SystemLog = new System.Windows.Forms.GroupBox();
            this.SystemLogBox = new System.Windows.Forms.TextBox();
            this.ParameterGroup = new System.Windows.Forms.GroupBox();
            this.tabMainControl = new System.Windows.Forms.TabControl();
            this.tabPage1_main = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox_CH1 = new System.Windows.Forms.GroupBox();
            this.CH1_Reset = new System.Windows.Forms.Button();
            this.CH1_ScanControl = new System.Windows.Forms.Button();
            this.CH1_PulseControl = new System.Windows.Forms.Button();
            this.groupBox_CH1_HV = new System.Windows.Forms.GroupBox();
            this.CH1_VolatageControl = new System.Windows.Forms.Button();
            this.CH1_label_VoltageLevel = new System.Windows.Forms.Label();
            this.CH1_HVLevel = new System.Windows.Forms.TextBox();
            this.CH1_HV_External = new System.Windows.Forms.RadioButton();
            this.CH1_HV_Internal = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox_CH1_ModeSelect = new System.Windows.Forms.GroupBox();
            this.CH1_Mode_Stimul = new System.Windows.Forms.RadioButton();
            this.CH1_Mode_Imaging = new System.Windows.Forms.RadioButton();
            this.groupBox_CH1_AFE = new System.Windows.Forms.GroupBox();
            this.CH1_label_ADCGain = new System.Windows.Forms.Label();
            this.CH1_label_PGAGain = new System.Windows.Forms.Label();
            this.CH1_label_LPF = new System.Windows.Forms.Label();
            this.CH1_ADCGain = new System.Windows.Forms.ComboBox();
            this.CH1_PGAGain = new System.Windows.Forms.ComboBox();
            this.CH1_LPF = new System.Windows.Forms.ComboBox();
            this.groupBox_ModeSelect = new System.Windows.Forms.GroupBox();
            this.groupBox_CH1_TxParameter = new System.Windows.Forms.GroupBox();
            this.CH1_DynamicRange = new System.Windows.Forms.TextBox();
            this.CH1_label_DynamicRange = new System.Windows.Forms.Label();
            this.CH1_PulseDuration = new System.Windows.Forms.TextBox();
            this.CH1_label_PulseDuration = new System.Windows.Forms.Label();
            this.CH1_PRF = new System.Windows.Forms.TextBox();
            this.CH1_label_PRF = new System.Windows.Forms.Label();
            this.CH1_label_ViewDepth = new System.Windows.Forms.Label();
            this.CH1_ViewDepth = new System.Windows.Forms.ComboBox();
            this.CH1_PulseCycles = new System.Windows.Forms.ComboBox();
            this.CH1_label_PulseCycles = new System.Windows.Forms.Label();
            this.CH1_CF = new System.Windows.Forms.ComboBox();
            this.CH1_Scanline = new System.Windows.Forms.TextBox();
            this.CH1_label_CF = new System.Windows.Forms.Label();
            this.CH1_label_Scanline = new System.Windows.Forms.Label();
            this.tabPage2_option = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.Param_ScanlineSelectTestDataView = new System.Windows.Forms.Button();
            this.Param_ScanlineTotalTestDataView = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.Param_ScanlineTestDataViewValue = new System.Windows.Forms.TextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_timer = new System.Windows.Forms.TextBox();
            this.Param_TestDataReset = new System.Windows.Forms.Button();
            this.Param_TestDataStart = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.Param_ScanlineSelectView = new System.Windows.Forms.Button();
            this.Param_ScanlineTotalView = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.Param_ScanlineViewValue = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.Param_ScanlineCounterSet = new System.Windows.Forms.Button();
            this.Param_ScanlineCounterSend = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.Param_ScanlineCounterValue = new System.Windows.Forms.TextBox();
            this.groupBox_HexToBinary = new System.Windows.Forms.GroupBox();
            this.Param_HexToBinarySend = new System.Windows.Forms.Button();
            this.label_ParamBinaryNumber = new System.Windows.Forms.Label();
            this.Param_BinaryNumber = new System.Windows.Forms.TextBox();
            this.label_ParamHexNumber = new System.Windows.Forms.Label();
            this.Param_HexNumber = new System.Windows.Forms.TextBox();
            this.GraphicGroup.SuspendLayout();
            this.groupBox_ImagingView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagingBox)).BeginInit();
            this.groupBox_BoardData.SuspendLayout();
            this.groupBox_SystemLog.SuspendLayout();
            this.ParameterGroup.SuspendLayout();
            this.tabMainControl.SuspendLayout();
            this.tabPage1_main.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox_CH1.SuspendLayout();
            this.groupBox_CH1_HV.SuspendLayout();
            this.groupBox_CH1_ModeSelect.SuspendLayout();
            this.groupBox_CH1_AFE.SuspendLayout();
            this.groupBox_CH1_TxParameter.SuspendLayout();
            this.tabPage2_option.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox_HexToBinary.SuspendLayout();
            this.SuspendLayout();
            // 
            // GraphicGroup
            // 
            this.GraphicGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GraphicGroup.BackColor = System.Drawing.Color.Transparent;
            this.GraphicGroup.Controls.Add(this.groupBox_ImagingView);
            this.GraphicGroup.Controls.Add(this.groupBox_BoardData);
            this.GraphicGroup.Controls.Add(this.groupBox_SystemLog);
            this.GraphicGroup.Location = new System.Drawing.Point(3, 0);
            this.GraphicGroup.Name = "GraphicGroup";
            this.GraphicGroup.Size = new System.Drawing.Size(822, 738);
            this.GraphicGroup.TabIndex = 1;
            this.GraphicGroup.TabStop = false;
            // 
            // groupBox_ImagingView
            // 
            this.groupBox_ImagingView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_ImagingView.Controls.Add(this.ImagingBox);
            this.groupBox_ImagingView.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox_ImagingView.ForeColor = System.Drawing.Color.White;
            this.groupBox_ImagingView.Location = new System.Drawing.Point(6, 13);
            this.groupBox_ImagingView.Name = "groupBox_ImagingView";
            this.groupBox_ImagingView.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox_ImagingView.Size = new System.Drawing.Size(810, 624);
            this.groupBox_ImagingView.TabIndex = 4;
            this.groupBox_ImagingView.TabStop = false;
            this.groupBox_ImagingView.Text = "ImagingView";
            // 
            // ImagingBox
            // 
            this.ImagingBox.BackColor = System.Drawing.Color.Transparent;
            this.ImagingBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagingBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImagingBox.Location = new System.Drawing.Point(5, 19);
            this.ImagingBox.Name = "ImagingBox";
            this.ImagingBox.Size = new System.Drawing.Size(800, 600);
            this.ImagingBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ImagingBox.TabIndex = 6;
            this.ImagingBox.TabStop = false;
            this.ImagingBox.SizeChanged += new System.EventHandler(this.ImagingBox_SizeChanged);
            // 
            // groupBox_BoardData
            // 
            this.groupBox_BoardData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_BoardData.Controls.Add(this.SystemBoardOUTEndpoint);
            this.groupBox_BoardData.Controls.Add(this.SystemBoardINEndpoint);
            this.groupBox_BoardData.Controls.Add(this.SystemBoardConnection);
            this.groupBox_BoardData.Controls.Add(this.label_OutEndpoint);
            this.groupBox_BoardData.Controls.Add(this.label_InEndpoint);
            this.groupBox_BoardData.Controls.Add(this.label_SystemBoard);
            this.groupBox_BoardData.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox_BoardData.ForeColor = System.Drawing.Color.White;
            this.groupBox_BoardData.Location = new System.Drawing.Point(6, 642);
            this.groupBox_BoardData.Name = "groupBox_BoardData";
            this.groupBox_BoardData.Size = new System.Drawing.Size(388, 90);
            this.groupBox_BoardData.TabIndex = 0;
            this.groupBox_BoardData.TabStop = false;
            this.groupBox_BoardData.Text = "System Connection INFO";
            // 
            // SystemBoardOUTEndpoint
            // 
            this.SystemBoardOUTEndpoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SystemBoardOUTEndpoint.Font = new System.Drawing.Font("D2Coding", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SystemBoardOUTEndpoint.FormattingEnabled = true;
            this.SystemBoardOUTEndpoint.Location = new System.Drawing.Point(89, 63);
            this.SystemBoardOUTEndpoint.Name = "SystemBoardOUTEndpoint";
            this.SystemBoardOUTEndpoint.Size = new System.Drawing.Size(289, 21);
            this.SystemBoardOUTEndpoint.TabIndex = 27;
            // 
            // SystemBoardINEndpoint
            // 
            this.SystemBoardINEndpoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SystemBoardINEndpoint.Font = new System.Drawing.Font("D2Coding", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SystemBoardINEndpoint.FormattingEnabled = true;
            this.SystemBoardINEndpoint.Location = new System.Drawing.Point(89, 41);
            this.SystemBoardINEndpoint.Name = "SystemBoardINEndpoint";
            this.SystemBoardINEndpoint.Size = new System.Drawing.Size(289, 21);
            this.SystemBoardINEndpoint.TabIndex = 26;
            // 
            // SystemBoardConnection
            // 
            this.SystemBoardConnection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SystemBoardConnection.Font = new System.Drawing.Font("D2Coding", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SystemBoardConnection.FormattingEnabled = true;
            this.SystemBoardConnection.Location = new System.Drawing.Point(89, 19);
            this.SystemBoardConnection.Name = "SystemBoardConnection";
            this.SystemBoardConnection.Size = new System.Drawing.Size(289, 21);
            this.SystemBoardConnection.TabIndex = 25;
            // 
            // label_OutEndpoint
            // 
            this.label_OutEndpoint.AutoSize = true;
            this.label_OutEndpoint.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_OutEndpoint.ForeColor = System.Drawing.Color.White;
            this.label_OutEndpoint.Location = new System.Drawing.Point(2, 66);
            this.label_OutEndpoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_OutEndpoint.Name = "label_OutEndpoint";
            this.label_OutEndpoint.Size = new System.Drawing.Size(82, 13);
            this.label_OutEndpoint.TabIndex = 21;
            this.label_OutEndpoint.Text = "OUT Endpoint";
            // 
            // label_InEndpoint
            // 
            this.label_InEndpoint.AutoSize = true;
            this.label_InEndpoint.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_InEndpoint.ForeColor = System.Drawing.Color.White;
            this.label_InEndpoint.Location = new System.Drawing.Point(13, 44);
            this.label_InEndpoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_InEndpoint.Name = "label_InEndpoint";
            this.label_InEndpoint.Size = new System.Drawing.Size(71, 13);
            this.label_InEndpoint.TabIndex = 20;
            this.label_InEndpoint.Text = "IN Endpoint";
            // 
            // label_SystemBoard
            // 
            this.label_SystemBoard.AutoSize = true;
            this.label_SystemBoard.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_SystemBoard.ForeColor = System.Drawing.Color.White;
            this.label_SystemBoard.Location = new System.Drawing.Point(5, 23);
            this.label_SystemBoard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_SystemBoard.Name = "label_SystemBoard";
            this.label_SystemBoard.Size = new System.Drawing.Size(79, 13);
            this.label_SystemBoard.TabIndex = 19;
            this.label_SystemBoard.Text = "System Board";
            this.label_SystemBoard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox_SystemLog
            // 
            this.groupBox_SystemLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_SystemLog.Controls.Add(this.SystemLogBox);
            this.groupBox_SystemLog.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox_SystemLog.ForeColor = System.Drawing.Color.White;
            this.groupBox_SystemLog.Location = new System.Drawing.Point(400, 642);
            this.groupBox_SystemLog.Name = "groupBox_SystemLog";
            this.groupBox_SystemLog.Size = new System.Drawing.Size(416, 89);
            this.groupBox_SystemLog.TabIndex = 1;
            this.groupBox_SystemLog.TabStop = false;
            this.groupBox_SystemLog.Text = "System Imaging Log Box";
            // 
            // SystemLogBox
            // 
            this.SystemLogBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SystemLogBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SystemLogBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SystemLogBox.Font = new System.Drawing.Font("D2Coding", 7F);
            this.SystemLogBox.ForeColor = System.Drawing.Color.White;
            this.SystemLogBox.Location = new System.Drawing.Point(3, 17);
            this.SystemLogBox.Multiline = true;
            this.SystemLogBox.Name = "SystemLogBox";
            this.SystemLogBox.ReadOnly = true;
            this.SystemLogBox.Size = new System.Drawing.Size(410, 69);
            this.SystemLogBox.TabIndex = 0;
            // 
            // ParameterGroup
            // 
            this.ParameterGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParameterGroup.BackColor = System.Drawing.Color.Transparent;
            this.ParameterGroup.Controls.Add(this.tabMainControl);
            this.ParameterGroup.Location = new System.Drawing.Point(830, 0);
            this.ParameterGroup.Name = "ParameterGroup";
            this.ParameterGroup.Size = new System.Drawing.Size(480, 738);
            this.ParameterGroup.TabIndex = 2;
            this.ParameterGroup.TabStop = false;
            // 
            // tabMainControl
            // 
            this.tabMainControl.Controls.Add(this.tabPage1_main);
            this.tabMainControl.Controls.Add(this.tabPage2_option);
            this.tabMainControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMainControl.ItemSize = new System.Drawing.Size(110, 30);
            this.tabMainControl.Location = new System.Drawing.Point(3, 17);
            this.tabMainControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabMainControl.Multiline = true;
            this.tabMainControl.Name = "tabMainControl";
            this.tabMainControl.Padding = new System.Drawing.Point(10, 5);
            this.tabMainControl.SelectedIndex = 0;
            this.tabMainControl.Size = new System.Drawing.Size(474, 718);
            this.tabMainControl.TabIndex = 0;
            // 
            // tabPage1_main
            // 
            this.tabPage1_main.BackColor = System.Drawing.Color.White;
            this.tabPage1_main.Controls.Add(this.groupBox1);
            this.tabPage1_main.Controls.Add(this.groupBox_CH1);
            this.tabPage1_main.Font = new System.Drawing.Font("D2Coding", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabPage1_main.Location = new System.Drawing.Point(4, 34);
            this.tabPage1_main.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1_main.Name = "tabPage1_main";
            this.tabPage1_main.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1_main.Size = new System.Drawing.Size(466, 680);
            this.tabPage1_main.TabIndex = 5;
            this.tabPage1_main.Text = "MAIN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(5, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 300);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Channel 2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(6, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 31);
            this.button1.TabIndex = 1030;
            this.button1.Text = "RESET";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(91, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 31);
            this.button2.TabIndex = 1029;
            this.button2.Text = "SCAN START";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(277, 263);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 31);
            this.button3.TabIndex = 1028;
            this.button3.Text = "Pulser ON";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(271, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 124);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "High Voltage";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Brown;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(6, 82);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 31);
            this.button4.TabIndex = 1027;
            this.button4.Text = "HV ON";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(5, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1026;
            this.label2.Text = "Voltage Level (V)";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(107, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(69, 14);
            this.textBox1.TabIndex = 1025;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Bold);
            this.radioButton1.Location = new System.Drawing.Point(85, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 15);
            this.radioButton1.TabIndex = 27;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "External";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Bold);
            this.radioButton2.Location = new System.Drawing.Point(6, 23);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 15);
            this.radioButton2.TabIndex = 26;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Internal";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(189, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mode Select";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton3);
            this.groupBox5.Controls.Add(this.radioButton4);
            this.groupBox5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox5.Location = new System.Drawing.Point(6, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(258, 46);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Mode Select";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(95, 20);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(116, 16);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.Text = "STIMULATION";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton4.Location = new System.Drawing.Point(8, 20);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(81, 16);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "IMAGING";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.comboBox1);
            this.groupBox6.Controls.Add(this.comboBox2);
            this.groupBox6.Controls.Add(this.comboBox3);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox6.Location = new System.Drawing.Point(270, 10);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(182, 117);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "AFE Parameter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "ADC Gain";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "PGA Gain";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "LPF SET";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0dB",
            "0.5dB",
            "1dB",
            "1.5dB",
            "2dB",
            "2.5dB",
            "3dB",
            "3.5dB",
            "4dB",
            "4.5dB",
            "5dB",
            "5.5dB",
            "6dB"});
            this.comboBox1.Location = new System.Drawing.Point(111, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(66, 20);
            this.comboBox1.TabIndex = 45;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "0dB",
            "3dB",
            "6dB",
            "9dB",
            "12dB",
            "15dB",
            "18dB"});
            this.comboBox2.Location = new System.Drawing.Point(111, 46);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(66, 20);
            this.comboBox2.TabIndex = 44;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "60MHz",
            "75MHz"});
            this.comboBox3.Location = new System.Drawing.Point(111, 20);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(66, 20);
            this.comboBox3.TabIndex = 43;
            // 
            // groupBox7
            // 
            this.groupBox7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox7.Location = new System.Drawing.Point(189, 139);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 100);
            this.groupBox7.TabIndex = 25;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Mode Select";
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.textBox2);
            this.groupBox8.Controls.Add(this.label6);
            this.groupBox8.Controls.Add(this.textBox3);
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Controls.Add(this.textBox4);
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.comboBox4);
            this.groupBox8.Controls.Add(this.comboBox5);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.comboBox6);
            this.groupBox8.Controls.Add(this.textBox5);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox8.Location = new System.Drawing.Point(6, 73);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(258, 184);
            this.groupBox8.TabIndex = 23;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Tx Parameter";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(166, 136);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(86, 14);
            this.textBox2.TabIndex = 1028;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(5, 136);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 1027;
            this.label6.Text = "Dynamic Range (dB)";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox3.Location = new System.Drawing.Point(166, 112);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(86, 14);
            this.textBox3.TabIndex = 1026;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(5, 112);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 13);
            this.label7.TabIndex = 1025;
            this.label7.Text = "Pulse Duration (micro sec)";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox4.Location = new System.Drawing.Point(166, 40);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(86, 14);
            this.textBox4.TabIndex = 1024;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(5, 41);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 1023;
            this.label8.Text = "PRF (Hz)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(5, 160);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 1022;
            this.label9.Text = "View Depth (cm)";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "No receive",
            "~1cm",
            "~2cm",
            "~3cm",
            "~4cm"});
            this.comboBox4.Location = new System.Drawing.Point(166, 156);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(86, 20);
            this.comboBox4.TabIndex = 1020;
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox5.Location = new System.Drawing.Point(166, 86);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(86, 20);
            this.comboBox5.TabIndex = 1021;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(5, 89);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 1019;
            this.label10.Text = "Pulse Cycles (N)";
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBox6.Location = new System.Drawing.Point(166, 60);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(86, 20);
            this.comboBox6.TabIndex = 1018;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox5.Location = new System.Drawing.Point(166, 20);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(86, 14);
            this.textBox5.TabIndex = 20;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(5, 63);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Center Frequency (MHz)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(5, 22);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "N of Scanline";
            // 
            // groupBox_CH1
            // 
            this.groupBox_CH1.Controls.Add(this.CH1_Reset);
            this.groupBox_CH1.Controls.Add(this.CH1_ScanControl);
            this.groupBox_CH1.Controls.Add(this.CH1_PulseControl);
            this.groupBox_CH1.Controls.Add(this.groupBox_CH1_HV);
            this.groupBox_CH1.Controls.Add(this.groupBox_CH1_ModeSelect);
            this.groupBox_CH1.Controls.Add(this.groupBox_CH1_AFE);
            this.groupBox_CH1.Controls.Add(this.groupBox_CH1_TxParameter);
            this.groupBox_CH1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox_CH1.Location = new System.Drawing.Point(5, 5);
            this.groupBox_CH1.Name = "groupBox_CH1";
            this.groupBox_CH1.Size = new System.Drawing.Size(456, 300);
            this.groupBox_CH1.TabIndex = 23;
            this.groupBox_CH1.TabStop = false;
            this.groupBox_CH1.Text = "Channel 1";
            // 
            // CH1_Reset
            // 
            this.CH1_Reset.BackColor = System.Drawing.Color.DimGray;
            this.CH1_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CH1_Reset.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.CH1_Reset.ForeColor = System.Drawing.Color.White;
            this.CH1_Reset.Location = new System.Drawing.Point(6, 263);
            this.CH1_Reset.Name = "CH1_Reset";
            this.CH1_Reset.Size = new System.Drawing.Size(79, 31);
            this.CH1_Reset.TabIndex = 1030;
            this.CH1_Reset.Text = "RESET";
            this.CH1_Reset.UseVisualStyleBackColor = false;
            this.CH1_Reset.Click += new System.EventHandler(this.CH1_Reset_Click);
            // 
            // CH1_ScanControl
            // 
            this.CH1_ScanControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CH1_ScanControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CH1_ScanControl.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.CH1_ScanControl.ForeColor = System.Drawing.Color.White;
            this.CH1_ScanControl.Location = new System.Drawing.Point(91, 263);
            this.CH1_ScanControl.Name = "CH1_ScanControl";
            this.CH1_ScanControl.Size = new System.Drawing.Size(173, 31);
            this.CH1_ScanControl.TabIndex = 1029;
            this.CH1_ScanControl.Text = "SCAN SET";
            this.CH1_ScanControl.UseVisualStyleBackColor = false;
            this.CH1_ScanControl.Click += new System.EventHandler(this.CH1_ScanControl_Click);
            // 
            // CH1_PulseControl
            // 
            this.CH1_PulseControl.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.CH1_PulseControl.Enabled = false;
            this.CH1_PulseControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CH1_PulseControl.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.CH1_PulseControl.ForeColor = System.Drawing.Color.White;
            this.CH1_PulseControl.Location = new System.Drawing.Point(277, 263);
            this.CH1_PulseControl.Name = "CH1_PulseControl";
            this.CH1_PulseControl.Size = new System.Drawing.Size(173, 31);
            this.CH1_PulseControl.TabIndex = 1028;
            this.CH1_PulseControl.Text = "Pulser ON";
            this.CH1_PulseControl.UseVisualStyleBackColor = false;
            this.CH1_PulseControl.Click += new System.EventHandler(this.CH1_PulseControl_Click);
            // 
            // groupBox_CH1_HV
            // 
            this.groupBox_CH1_HV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_CH1_HV.Controls.Add(this.CH1_VolatageControl);
            this.groupBox_CH1_HV.Controls.Add(this.CH1_label_VoltageLevel);
            this.groupBox_CH1_HV.Controls.Add(this.CH1_HVLevel);
            this.groupBox_CH1_HV.Controls.Add(this.CH1_HV_External);
            this.groupBox_CH1_HV.Controls.Add(this.CH1_HV_Internal);
            this.groupBox_CH1_HV.Controls.Add(this.groupBox4);
            this.groupBox_CH1_HV.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox_CH1_HV.Location = new System.Drawing.Point(271, 133);
            this.groupBox_CH1_HV.Name = "groupBox_CH1_HV";
            this.groupBox_CH1_HV.Size = new System.Drawing.Size(182, 124);
            this.groupBox_CH1_HV.TabIndex = 26;
            this.groupBox_CH1_HV.TabStop = false;
            this.groupBox_CH1_HV.Text = "High Voltage";
            // 
            // CH1_VolatageControl
            // 
            this.CH1_VolatageControl.BackColor = System.Drawing.Color.Brown;
            this.CH1_VolatageControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CH1_VolatageControl.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.CH1_VolatageControl.ForeColor = System.Drawing.Color.White;
            this.CH1_VolatageControl.Location = new System.Drawing.Point(6, 82);
            this.CH1_VolatageControl.Name = "CH1_VolatageControl";
            this.CH1_VolatageControl.Size = new System.Drawing.Size(173, 31);
            this.CH1_VolatageControl.TabIndex = 1027;
            this.CH1_VolatageControl.Text = "HV ON";
            this.CH1_VolatageControl.UseVisualStyleBackColor = false;
            this.CH1_VolatageControl.Click += new System.EventHandler(this.CH1_VolatageControl_Click);
            // 
            // CH1_label_VoltageLevel
            // 
            this.CH1_label_VoltageLevel.AutoSize = true;
            this.CH1_label_VoltageLevel.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CH1_label_VoltageLevel.ForeColor = System.Drawing.Color.DimGray;
            this.CH1_label_VoltageLevel.Location = new System.Drawing.Point(5, 54);
            this.CH1_label_VoltageLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CH1_label_VoltageLevel.Name = "CH1_label_VoltageLevel";
            this.CH1_label_VoltageLevel.Size = new System.Drawing.Size(97, 13);
            this.CH1_label_VoltageLevel.TabIndex = 1026;
            this.CH1_label_VoltageLevel.Text = "Voltage Level (V)";
            // 
            // CH1_HVLevel
            // 
            this.CH1_HVLevel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CH1_HVLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CH1_HVLevel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CH1_HVLevel.Location = new System.Drawing.Point(107, 54);
            this.CH1_HVLevel.Name = "CH1_HVLevel";
            this.CH1_HVLevel.Size = new System.Drawing.Size(69, 14);
            this.CH1_HVLevel.TabIndex = 1025;
            this.CH1_HVLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CH1_HVLevel.TextChanged += new System.EventHandler(this.CH1_HVLevel_TextChanged);
            // 
            // CH1_HV_External
            // 
            this.CH1_HV_External.AutoSize = true;
            this.CH1_HV_External.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Bold);
            this.CH1_HV_External.Location = new System.Drawing.Point(85, 23);
            this.CH1_HV_External.Name = "CH1_HV_External";
            this.CH1_HV_External.Size = new System.Drawing.Size(76, 15);
            this.CH1_HV_External.TabIndex = 27;
            this.CH1_HV_External.TabStop = true;
            this.CH1_HV_External.Text = "External";
            this.CH1_HV_External.UseVisualStyleBackColor = true;
            // 
            // CH1_HV_Internal
            // 
            this.CH1_HV_Internal.AutoSize = true;
            this.CH1_HV_Internal.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Bold);
            this.CH1_HV_Internal.Location = new System.Drawing.Point(6, 23);
            this.CH1_HV_Internal.Name = "CH1_HV_Internal";
            this.CH1_HV_Internal.Size = new System.Drawing.Size(73, 15);
            this.CH1_HV_Internal.TabIndex = 26;
            this.CH1_HV_Internal.TabStop = true;
            this.CH1_HV_Internal.Text = "Internal";
            this.CH1_HV_Internal.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.Location = new System.Drawing.Point(189, 139);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mode Select";
            // 
            // groupBox_CH1_ModeSelect
            // 
            this.groupBox_CH1_ModeSelect.Controls.Add(this.CH1_Mode_Stimul);
            this.groupBox_CH1_ModeSelect.Controls.Add(this.CH1_Mode_Imaging);
            this.groupBox_CH1_ModeSelect.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox_CH1_ModeSelect.Location = new System.Drawing.Point(6, 21);
            this.groupBox_CH1_ModeSelect.Name = "groupBox_CH1_ModeSelect";
            this.groupBox_CH1_ModeSelect.Size = new System.Drawing.Size(258, 46);
            this.groupBox_CH1_ModeSelect.TabIndex = 25;
            this.groupBox_CH1_ModeSelect.TabStop = false;
            this.groupBox_CH1_ModeSelect.Text = "Mode Select";
            // 
            // CH1_Mode_Stimul
            // 
            this.CH1_Mode_Stimul.AutoSize = true;
            this.CH1_Mode_Stimul.Location = new System.Drawing.Point(95, 20);
            this.CH1_Mode_Stimul.Name = "CH1_Mode_Stimul";
            this.CH1_Mode_Stimul.Size = new System.Drawing.Size(116, 16);
            this.CH1_Mode_Stimul.TabIndex = 1;
            this.CH1_Mode_Stimul.Text = "STIMULATION";
            this.CH1_Mode_Stimul.UseVisualStyleBackColor = true;
            this.CH1_Mode_Stimul.CheckedChanged += new System.EventHandler(this.CH1_Mode_Stimul_CheckedChanged);
            // 
            // CH1_Mode_Imaging
            // 
            this.CH1_Mode_Imaging.AutoSize = true;
            this.CH1_Mode_Imaging.Checked = true;
            this.CH1_Mode_Imaging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CH1_Mode_Imaging.Location = new System.Drawing.Point(8, 20);
            this.CH1_Mode_Imaging.Name = "CH1_Mode_Imaging";
            this.CH1_Mode_Imaging.Size = new System.Drawing.Size(81, 16);
            this.CH1_Mode_Imaging.TabIndex = 0;
            this.CH1_Mode_Imaging.TabStop = true;
            this.CH1_Mode_Imaging.Text = "IMAGING";
            this.CH1_Mode_Imaging.UseVisualStyleBackColor = true;
            this.CH1_Mode_Imaging.CheckedChanged += new System.EventHandler(this.CH1_Mode_Imaging_CheckedChanged);
            // 
            // groupBox_CH1_AFE
            // 
            this.groupBox_CH1_AFE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_CH1_AFE.Controls.Add(this.CH1_label_ADCGain);
            this.groupBox_CH1_AFE.Controls.Add(this.CH1_label_PGAGain);
            this.groupBox_CH1_AFE.Controls.Add(this.CH1_label_LPF);
            this.groupBox_CH1_AFE.Controls.Add(this.CH1_ADCGain);
            this.groupBox_CH1_AFE.Controls.Add(this.CH1_PGAGain);
            this.groupBox_CH1_AFE.Controls.Add(this.CH1_LPF);
            this.groupBox_CH1_AFE.Controls.Add(this.groupBox_ModeSelect);
            this.groupBox_CH1_AFE.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox_CH1_AFE.Location = new System.Drawing.Point(270, 10);
            this.groupBox_CH1_AFE.Name = "groupBox_CH1_AFE";
            this.groupBox_CH1_AFE.Size = new System.Drawing.Size(182, 117);
            this.groupBox_CH1_AFE.TabIndex = 24;
            this.groupBox_CH1_AFE.TabStop = false;
            this.groupBox_CH1_AFE.Text = "AFE Parameter";
            // 
            // CH1_label_ADCGain
            // 
            this.CH1_label_ADCGain.AutoSize = true;
            this.CH1_label_ADCGain.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CH1_label_ADCGain.ForeColor = System.Drawing.Color.DimGray;
            this.CH1_label_ADCGain.Location = new System.Drawing.Point(6, 78);
            this.CH1_label_ADCGain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CH1_label_ADCGain.Name = "CH1_label_ADCGain";
            this.CH1_label_ADCGain.Size = new System.Drawing.Size(58, 13);
            this.CH1_label_ADCGain.TabIndex = 49;
            this.CH1_label_ADCGain.Text = "ADC Gain";
            // 
            // CH1_label_PGAGain
            // 
            this.CH1_label_PGAGain.AutoSize = true;
            this.CH1_label_PGAGain.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CH1_label_PGAGain.ForeColor = System.Drawing.Color.DimGray;
            this.CH1_label_PGAGain.Location = new System.Drawing.Point(6, 49);
            this.CH1_label_PGAGain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CH1_label_PGAGain.Name = "CH1_label_PGAGain";
            this.CH1_label_PGAGain.Size = new System.Drawing.Size(58, 13);
            this.CH1_label_PGAGain.TabIndex = 48;
            this.CH1_label_PGAGain.Text = "PGA Gain";
            // 
            // CH1_label_LPF
            // 
            this.CH1_label_LPF.AutoSize = true;
            this.CH1_label_LPF.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CH1_label_LPF.ForeColor = System.Drawing.Color.DimGray;
            this.CH1_label_LPF.Location = new System.Drawing.Point(6, 23);
            this.CH1_label_LPF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CH1_label_LPF.Name = "CH1_label_LPF";
            this.CH1_label_LPF.Size = new System.Drawing.Size(48, 13);
            this.CH1_label_LPF.TabIndex = 47;
            this.CH1_label_LPF.Text = "LPF SET";
            // 
            // CH1_ADCGain
            // 
            this.CH1_ADCGain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CH1_ADCGain.FormattingEnabled = true;
            this.CH1_ADCGain.Items.AddRange(new object[] {
            "0dB",
            "0.5dB",
            "1dB",
            "1.5dB",
            "2dB",
            "2.5dB",
            "3dB",
            "3.5dB",
            "4dB",
            "4.5dB",
            "5dB",
            "5.5dB",
            "6dB"});
            this.CH1_ADCGain.Location = new System.Drawing.Point(111, 75);
            this.CH1_ADCGain.Name = "CH1_ADCGain";
            this.CH1_ADCGain.Size = new System.Drawing.Size(66, 20);
            this.CH1_ADCGain.TabIndex = 45;
            this.CH1_ADCGain.SelectedValueChanged += new System.EventHandler(this.CH1_ADCGain_SelectedValueChanged);
            // 
            // CH1_PGAGain
            // 
            this.CH1_PGAGain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CH1_PGAGain.FormattingEnabled = true;
            this.CH1_PGAGain.Items.AddRange(new object[] {
            "0dB",
            "3dB",
            "6dB",
            "9dB",
            "12dB",
            "15dB",
            "18dB"});
            this.CH1_PGAGain.Location = new System.Drawing.Point(111, 46);
            this.CH1_PGAGain.Name = "CH1_PGAGain";
            this.CH1_PGAGain.Size = new System.Drawing.Size(66, 20);
            this.CH1_PGAGain.TabIndex = 44;
            this.CH1_PGAGain.SelectedValueChanged += new System.EventHandler(this.CH1_PGAGain_SelectedValueChanged);
            // 
            // CH1_LPF
            // 
            this.CH1_LPF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CH1_LPF.FormattingEnabled = true;
            this.CH1_LPF.Items.AddRange(new object[] {
            "60MHz",
            "75MHz"});
            this.CH1_LPF.Location = new System.Drawing.Point(111, 20);
            this.CH1_LPF.Name = "CH1_LPF";
            this.CH1_LPF.Size = new System.Drawing.Size(66, 20);
            this.CH1_LPF.TabIndex = 43;
            this.CH1_LPF.SelectedValueChanged += new System.EventHandler(this.CH1_LPF_SelectedValueChanged);
            // 
            // groupBox_ModeSelect
            // 
            this.groupBox_ModeSelect.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox_ModeSelect.Location = new System.Drawing.Point(189, 139);
            this.groupBox_ModeSelect.Name = "groupBox_ModeSelect";
            this.groupBox_ModeSelect.Size = new System.Drawing.Size(200, 100);
            this.groupBox_ModeSelect.TabIndex = 25;
            this.groupBox_ModeSelect.TabStop = false;
            this.groupBox_ModeSelect.Text = "Mode Select";
            // 
            // groupBox_CH1_TxParameter
            // 
            this.groupBox_CH1_TxParameter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_CH1_TxParameter.Controls.Add(this.CH1_DynamicRange);
            this.groupBox_CH1_TxParameter.Controls.Add(this.CH1_label_DynamicRange);
            this.groupBox_CH1_TxParameter.Controls.Add(this.CH1_PulseDuration);
            this.groupBox_CH1_TxParameter.Controls.Add(this.CH1_label_PulseDuration);
            this.groupBox_CH1_TxParameter.Controls.Add(this.CH1_PRF);
            this.groupBox_CH1_TxParameter.Controls.Add(this.CH1_label_PRF);
            this.groupBox_CH1_TxParameter.Controls.Add(this.CH1_label_ViewDepth);
            this.groupBox_CH1_TxParameter.Controls.Add(this.CH1_ViewDepth);
            this.groupBox_CH1_TxParameter.Controls.Add(this.CH1_PulseCycles);
            this.groupBox_CH1_TxParameter.Controls.Add(this.CH1_label_PulseCycles);
            this.groupBox_CH1_TxParameter.Controls.Add(this.CH1_CF);
            this.groupBox_CH1_TxParameter.Controls.Add(this.CH1_Scanline);
            this.groupBox_CH1_TxParameter.Controls.Add(this.CH1_label_CF);
            this.groupBox_CH1_TxParameter.Controls.Add(this.CH1_label_Scanline);
            this.groupBox_CH1_TxParameter.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox_CH1_TxParameter.Location = new System.Drawing.Point(6, 73);
            this.groupBox_CH1_TxParameter.Name = "groupBox_CH1_TxParameter";
            this.groupBox_CH1_TxParameter.Size = new System.Drawing.Size(258, 184);
            this.groupBox_CH1_TxParameter.TabIndex = 23;
            this.groupBox_CH1_TxParameter.TabStop = false;
            this.groupBox_CH1_TxParameter.Text = "Tx Parameter";
            // 
            // CH1_DynamicRange
            // 
            this.CH1_DynamicRange.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CH1_DynamicRange.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CH1_DynamicRange.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CH1_DynamicRange.Location = new System.Drawing.Point(166, 136);
            this.CH1_DynamicRange.Name = "CH1_DynamicRange";
            this.CH1_DynamicRange.Size = new System.Drawing.Size(86, 14);
            this.CH1_DynamicRange.TabIndex = 1028;
            this.CH1_DynamicRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CH1_DynamicRange.TextChanged += new System.EventHandler(this.CH1_DynamicRange_TextChanged);
            // 
            // CH1_label_DynamicRange
            // 
            this.CH1_label_DynamicRange.AutoSize = true;
            this.CH1_label_DynamicRange.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CH1_label_DynamicRange.ForeColor = System.Drawing.Color.DimGray;
            this.CH1_label_DynamicRange.Location = new System.Drawing.Point(5, 136);
            this.CH1_label_DynamicRange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CH1_label_DynamicRange.Name = "CH1_label_DynamicRange";
            this.CH1_label_DynamicRange.Size = new System.Drawing.Size(115, 13);
            this.CH1_label_DynamicRange.TabIndex = 1027;
            this.CH1_label_DynamicRange.Text = "Dynamic Range (dB)";
            // 
            // CH1_PulseDuration
            // 
            this.CH1_PulseDuration.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CH1_PulseDuration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CH1_PulseDuration.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CH1_PulseDuration.Location = new System.Drawing.Point(166, 112);
            this.CH1_PulseDuration.Name = "CH1_PulseDuration";
            this.CH1_PulseDuration.Size = new System.Drawing.Size(86, 14);
            this.CH1_PulseDuration.TabIndex = 1026;
            this.CH1_PulseDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CH1_PulseDuration.TextChanged += new System.EventHandler(this.CH1_PulseDuration_TextChanged);
            // 
            // CH1_label_PulseDuration
            // 
            this.CH1_label_PulseDuration.AutoSize = true;
            this.CH1_label_PulseDuration.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CH1_label_PulseDuration.ForeColor = System.Drawing.Color.DimGray;
            this.CH1_label_PulseDuration.Location = new System.Drawing.Point(5, 112);
            this.CH1_label_PulseDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CH1_label_PulseDuration.Name = "CH1_label_PulseDuration";
            this.CH1_label_PulseDuration.Size = new System.Drawing.Size(146, 13);
            this.CH1_label_PulseDuration.TabIndex = 1025;
            this.CH1_label_PulseDuration.Text = "Pulse Duration (micro sec)";
            // 
            // CH1_PRF
            // 
            this.CH1_PRF.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CH1_PRF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CH1_PRF.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CH1_PRF.Location = new System.Drawing.Point(166, 40);
            this.CH1_PRF.Name = "CH1_PRF";
            this.CH1_PRF.Size = new System.Drawing.Size(86, 14);
            this.CH1_PRF.TabIndex = 1024;
            this.CH1_PRF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CH1_PRF.TextChanged += new System.EventHandler(this.CH1_PRF_TextChanged);
            // 
            // CH1_label_PRF
            // 
            this.CH1_label_PRF.AutoSize = true;
            this.CH1_label_PRF.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CH1_label_PRF.ForeColor = System.Drawing.Color.DimGray;
            this.CH1_label_PRF.Location = new System.Drawing.Point(5, 41);
            this.CH1_label_PRF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CH1_label_PRF.Name = "CH1_label_PRF";
            this.CH1_label_PRF.Size = new System.Drawing.Size(52, 13);
            this.CH1_label_PRF.TabIndex = 1023;
            this.CH1_label_PRF.Text = "PRF (Hz)";
            // 
            // CH1_label_ViewDepth
            // 
            this.CH1_label_ViewDepth.AutoSize = true;
            this.CH1_label_ViewDepth.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CH1_label_ViewDepth.ForeColor = System.Drawing.Color.DimGray;
            this.CH1_label_ViewDepth.Location = new System.Drawing.Point(5, 160);
            this.CH1_label_ViewDepth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CH1_label_ViewDepth.Name = "CH1_label_ViewDepth";
            this.CH1_label_ViewDepth.Size = new System.Drawing.Size(95, 13);
            this.CH1_label_ViewDepth.TabIndex = 1022;
            this.CH1_label_ViewDepth.Text = "View Depth (cm)";
            // 
            // CH1_ViewDepth
            // 
            this.CH1_ViewDepth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CH1_ViewDepth.FormattingEnabled = true;
            this.CH1_ViewDepth.Items.AddRange(new object[] {
            "None",
            "~1cm",
            "~2cm",
            "~3cm",
            "~4cm"});
            this.CH1_ViewDepth.Location = new System.Drawing.Point(166, 156);
            this.CH1_ViewDepth.Name = "CH1_ViewDepth";
            this.CH1_ViewDepth.Size = new System.Drawing.Size(86, 20);
            this.CH1_ViewDepth.TabIndex = 1020;
            this.CH1_ViewDepth.SelectedValueChanged += new System.EventHandler(this.CH1_ViewDepth_SelectedValueChanged);
            // 
            // CH1_PulseCycles
            // 
            this.CH1_PulseCycles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CH1_PulseCycles.FormattingEnabled = true;
            this.CH1_PulseCycles.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.CH1_PulseCycles.Location = new System.Drawing.Point(166, 86);
            this.CH1_PulseCycles.Name = "CH1_PulseCycles";
            this.CH1_PulseCycles.Size = new System.Drawing.Size(86, 20);
            this.CH1_PulseCycles.TabIndex = 1021;
            this.CH1_PulseCycles.SelectedValueChanged += new System.EventHandler(this.CH1_PulseCycles_SelectedValueChanged);
            // 
            // CH1_label_PulseCycles
            // 
            this.CH1_label_PulseCycles.AutoSize = true;
            this.CH1_label_PulseCycles.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CH1_label_PulseCycles.ForeColor = System.Drawing.Color.DimGray;
            this.CH1_label_PulseCycles.Location = new System.Drawing.Point(5, 89);
            this.CH1_label_PulseCycles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CH1_label_PulseCycles.Name = "CH1_label_PulseCycles";
            this.CH1_label_PulseCycles.Size = new System.Drawing.Size(92, 13);
            this.CH1_label_PulseCycles.TabIndex = 1019;
            this.CH1_label_PulseCycles.Text = "Pulse Cycles (N)";
            // 
            // CH1_CF
            // 
            this.CH1_CF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CH1_CF.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CH1_CF.FormattingEnabled = true;
            this.CH1_CF.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.CH1_CF.Location = new System.Drawing.Point(166, 60);
            this.CH1_CF.Name = "CH1_CF";
            this.CH1_CF.Size = new System.Drawing.Size(86, 20);
            this.CH1_CF.TabIndex = 1018;
            this.CH1_CF.SelectedValueChanged += new System.EventHandler(this.CH1_CF_SelectedValueChanged);
            // 
            // CH1_Scanline
            // 
            this.CH1_Scanline.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CH1_Scanline.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CH1_Scanline.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CH1_Scanline.Location = new System.Drawing.Point(166, 20);
            this.CH1_Scanline.Name = "CH1_Scanline";
            this.CH1_Scanline.Size = new System.Drawing.Size(86, 14);
            this.CH1_Scanline.TabIndex = 20;
            this.CH1_Scanline.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CH1_Scanline.TextChanged += new System.EventHandler(this.CH1_Scanline_TextChanged);
            // 
            // CH1_label_CF
            // 
            this.CH1_label_CF.AutoSize = true;
            this.CH1_label_CF.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CH1_label_CF.ForeColor = System.Drawing.Color.DimGray;
            this.CH1_label_CF.Location = new System.Drawing.Point(5, 63);
            this.CH1_label_CF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CH1_label_CF.Name = "CH1_label_CF";
            this.CH1_label_CF.Size = new System.Drawing.Size(135, 13);
            this.CH1_label_CF.TabIndex = 19;
            this.CH1_label_CF.Text = "Center Frequency (MHz)";
            // 
            // CH1_label_Scanline
            // 
            this.CH1_label_Scanline.AutoSize = true;
            this.CH1_label_Scanline.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CH1_label_Scanline.ForeColor = System.Drawing.Color.DimGray;
            this.CH1_label_Scanline.Location = new System.Drawing.Point(5, 22);
            this.CH1_label_Scanline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CH1_label_Scanline.Name = "CH1_label_Scanline";
            this.CH1_label_Scanline.Size = new System.Drawing.Size(78, 13);
            this.CH1_label_Scanline.TabIndex = 18;
            this.CH1_label_Scanline.Text = "N of Scanline";
            // 
            // tabPage2_option
            // 
            this.tabPage2_option.BackColor = System.Drawing.Color.White;
            this.tabPage2_option.Controls.Add(this.groupBox11);
            this.tabPage2_option.Controls.Add(this.groupBox10);
            this.tabPage2_option.Controls.Add(this.groupBox9);
            this.tabPage2_option.Controls.Add(this.groupBox_HexToBinary);
            this.tabPage2_option.ForeColor = System.Drawing.Color.Black;
            this.tabPage2_option.Location = new System.Drawing.Point(4, 34);
            this.tabPage2_option.Name = "tabPage2_option";
            this.tabPage2_option.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2_option.Size = new System.Drawing.Size(466, 680);
            this.tabPage2_option.TabIndex = 6;
            this.tabPage2_option.Text = "Option";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.groupBox13);
            this.groupBox11.Controls.Add(this.groupBox12);
            this.groupBox11.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox11.Location = new System.Drawing.Point(6, 228);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(454, 180);
            this.groupBox11.TabIndex = 3;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Prameter Scanline TestData";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.Param_ScanlineSelectTestDataView);
            this.groupBox13.Controls.Add(this.Param_ScanlineTotalTestDataView);
            this.groupBox13.Controls.Add(this.label15);
            this.groupBox13.Controls.Add(this.Param_ScanlineTestDataViewValue);
            this.groupBox13.Location = new System.Drawing.Point(6, 99);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(445, 76);
            this.groupBox13.TabIndex = 22;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Checking the test data";
            // 
            // Param_ScanlineSelectTestDataView
            // 
            this.Param_ScanlineSelectTestDataView.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Param_ScanlineSelectTestDataView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Param_ScanlineSelectTestDataView.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.Param_ScanlineSelectTestDataView.ForeColor = System.Drawing.Color.Transparent;
            this.Param_ScanlineSelectTestDataView.Location = new System.Drawing.Point(182, 24);
            this.Param_ScanlineSelectTestDataView.Name = "Param_ScanlineSelectTestDataView";
            this.Param_ScanlineSelectTestDataView.Size = new System.Drawing.Size(123, 39);
            this.Param_ScanlineSelectTestDataView.TabIndex = 24;
            this.Param_ScanlineSelectTestDataView.Text = "Select View";
            this.Param_ScanlineSelectTestDataView.UseVisualStyleBackColor = false;
            this.Param_ScanlineSelectTestDataView.Click += new System.EventHandler(this.Param_ScanlineSelectTestDataView_Click);
            // 
            // Param_ScanlineTotalTestDataView
            // 
            this.Param_ScanlineTotalTestDataView.BackColor = System.Drawing.Color.Black;
            this.Param_ScanlineTotalTestDataView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Param_ScanlineTotalTestDataView.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.Param_ScanlineTotalTestDataView.ForeColor = System.Drawing.Color.Transparent;
            this.Param_ScanlineTotalTestDataView.Location = new System.Drawing.Point(311, 24);
            this.Param_ScanlineTotalTestDataView.Name = "Param_ScanlineTotalTestDataView";
            this.Param_ScanlineTotalTestDataView.Size = new System.Drawing.Size(130, 39);
            this.Param_ScanlineTotalTestDataView.TabIndex = 21;
            this.Param_ScanlineTotalTestDataView.Text = "Total View";
            this.Param_ScanlineTotalTestDataView.UseVisualStyleBackColor = false;
            this.Param_ScanlineTotalTestDataView.Click += new System.EventHandler(this.Param_ScanlineTotalTestDataView_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.ForeColor = System.Drawing.Color.DimGray;
            this.label15.Location = new System.Drawing.Point(3, 26);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "N of Scanlie";
            // 
            // Param_ScanlineTestDataViewValue
            // 
            this.Param_ScanlineTestDataViewValue.Font = new System.Drawing.Font("D2Coding", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Param_ScanlineTestDataViewValue.Location = new System.Drawing.Point(5, 42);
            this.Param_ScanlineTestDataViewValue.Name = "Param_ScanlineTestDataViewValue";
            this.Param_ScanlineTestDataViewValue.Size = new System.Drawing.Size(128, 21);
            this.Param_ScanlineTestDataViewValue.TabIndex = 22;
            this.Param_ScanlineTestDataViewValue.Text = "0";
            this.Param_ScanlineTestDataViewValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.label16);
            this.groupBox12.Controls.Add(this.textBox_timer);
            this.groupBox12.Controls.Add(this.Param_TestDataReset);
            this.groupBox12.Controls.Add(this.Param_TestDataStart);
            this.groupBox12.Location = new System.Drawing.Point(5, 17);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(446, 76);
            this.groupBox12.TabIndex = 21;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Test Data SET :: For parameters, refer to the Main page.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.ForeColor = System.Drawing.Color.DimGray;
            this.label16.Location = new System.Drawing.Point(3, 26);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 1038;
            this.label16.Text = "TEST Timer";
            // 
            // textBox_timer
            // 
            this.textBox_timer.BackColor = System.Drawing.Color.White;
            this.textBox_timer.Font = new System.Drawing.Font("D2Coding", 9F);
            this.textBox_timer.ForeColor = System.Drawing.Color.Black;
            this.textBox_timer.Location = new System.Drawing.Point(6, 43);
            this.textBox_timer.Name = "textBox_timer";
            this.textBox_timer.ReadOnly = true;
            this.textBox_timer.Size = new System.Drawing.Size(128, 21);
            this.textBox_timer.TabIndex = 1037;
            // 
            // Param_TestDataReset
            // 
            this.Param_TestDataReset.BackColor = System.Drawing.Color.DimGray;
            this.Param_TestDataReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Param_TestDataReset.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.Param_TestDataReset.ForeColor = System.Drawing.Color.White;
            this.Param_TestDataReset.Location = new System.Drawing.Point(183, 25);
            this.Param_TestDataReset.Name = "Param_TestDataReset";
            this.Param_TestDataReset.Size = new System.Drawing.Size(123, 39);
            this.Param_TestDataReset.TabIndex = 1036;
            this.Param_TestDataReset.Text = "RESET";
            this.Param_TestDataReset.UseVisualStyleBackColor = false;
            this.Param_TestDataReset.Click += new System.EventHandler(this.Param_TestDataReset_Click);
            // 
            // Param_TestDataStart
            // 
            this.Param_TestDataStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Param_TestDataStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Param_TestDataStart.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.Param_TestDataStart.ForeColor = System.Drawing.Color.White;
            this.Param_TestDataStart.Location = new System.Drawing.Point(312, 25);
            this.Param_TestDataStart.Name = "Param_TestDataStart";
            this.Param_TestDataStart.Size = new System.Drawing.Size(130, 39);
            this.Param_TestDataStart.TabIndex = 1035;
            this.Param_TestDataStart.Text = "TEST START";
            this.Param_TestDataStart.UseVisualStyleBackColor = false;
            this.Param_TestDataStart.Click += new System.EventHandler(this.Param_TestDataStart_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.Param_ScanlineSelectView);
            this.groupBox10.Controls.Add(this.Param_ScanlineTotalView);
            this.groupBox10.Controls.Add(this.label13);
            this.groupBox10.Controls.Add(this.Param_ScanlineViewValue);
            this.groupBox10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox10.Location = new System.Drawing.Point(3, 154);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(454, 68);
            this.groupBox10.TabIndex = 2;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Prameter Scanline View";
            // 
            // Param_ScanlineSelectView
            // 
            this.Param_ScanlineSelectView.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Param_ScanlineSelectView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Param_ScanlineSelectView.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.Param_ScanlineSelectView.ForeColor = System.Drawing.Color.Transparent;
            this.Param_ScanlineSelectView.Location = new System.Drawing.Point(189, 18);
            this.Param_ScanlineSelectView.Name = "Param_ScanlineSelectView";
            this.Param_ScanlineSelectView.Size = new System.Drawing.Size(125, 39);
            this.Param_ScanlineSelectView.TabIndex = 20;
            this.Param_ScanlineSelectView.Text = "Select View";
            this.Param_ScanlineSelectView.UseVisualStyleBackColor = false;
            this.Param_ScanlineSelectView.Click += new System.EventHandler(this.Param_ScanlineSelectView_Click);
            // 
            // Param_ScanlineTotalView
            // 
            this.Param_ScanlineTotalView.BackColor = System.Drawing.Color.Black;
            this.Param_ScanlineTotalView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Param_ScanlineTotalView.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.Param_ScanlineTotalView.ForeColor = System.Drawing.Color.Transparent;
            this.Param_ScanlineTotalView.Location = new System.Drawing.Point(318, 18);
            this.Param_ScanlineTotalView.Name = "Param_ScanlineTotalView";
            this.Param_ScanlineTotalView.Size = new System.Drawing.Size(130, 39);
            this.Param_ScanlineTotalView.TabIndex = 1;
            this.Param_ScanlineTotalView.Text = "Total View";
            this.Param_ScanlineTotalView.UseVisualStyleBackColor = false;
            this.Param_ScanlineTotalView.Click += new System.EventHandler(this.Param_ScanlineTotalView_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(5, 20);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "N of Scanlie";
            // 
            // Param_ScanlineViewValue
            // 
            this.Param_ScanlineViewValue.Font = new System.Drawing.Font("D2Coding", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Param_ScanlineViewValue.Location = new System.Drawing.Point(8, 36);
            this.Param_ScanlineViewValue.Name = "Param_ScanlineViewValue";
            this.Param_ScanlineViewValue.Size = new System.Drawing.Size(128, 21);
            this.Param_ScanlineViewValue.TabIndex = 4;
            this.Param_ScanlineViewValue.Text = "0";
            this.Param_ScanlineViewValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.Param_ScanlineCounterSet);
            this.groupBox9.Controls.Add(this.Param_ScanlineCounterSend);
            this.groupBox9.Controls.Add(this.label14);
            this.groupBox9.Controls.Add(this.Param_ScanlineCounterValue);
            this.groupBox9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox9.Location = new System.Drawing.Point(6, 80);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(454, 68);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Prameter Scanline Counter Test";
            // 
            // Param_ScanlineCounterSet
            // 
            this.Param_ScanlineCounterSet.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Param_ScanlineCounterSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Param_ScanlineCounterSet.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.Param_ScanlineCounterSet.ForeColor = System.Drawing.Color.Transparent;
            this.Param_ScanlineCounterSet.Location = new System.Drawing.Point(323, 20);
            this.Param_ScanlineCounterSet.Name = "Param_ScanlineCounterSet";
            this.Param_ScanlineCounterSet.Size = new System.Drawing.Size(58, 39);
            this.Param_ScanlineCounterSet.TabIndex = 20;
            this.Param_ScanlineCounterSet.Text = "SET";
            this.Param_ScanlineCounterSet.UseVisualStyleBackColor = false;
            this.Param_ScanlineCounterSet.Click += new System.EventHandler(this.Param_ScanlineCounterSet_Click);
            // 
            // Param_ScanlineCounterSend
            // 
            this.Param_ScanlineCounterSend.BackColor = System.Drawing.Color.Black;
            this.Param_ScanlineCounterSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Param_ScanlineCounterSend.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.Param_ScanlineCounterSend.ForeColor = System.Drawing.Color.Transparent;
            this.Param_ScanlineCounterSend.Location = new System.Drawing.Point(387, 20);
            this.Param_ScanlineCounterSend.Name = "Param_ScanlineCounterSend";
            this.Param_ScanlineCounterSend.Size = new System.Drawing.Size(58, 39);
            this.Param_ScanlineCounterSend.TabIndex = 1;
            this.Param_ScanlineCounterSend.Text = "SEND";
            this.Param_ScanlineCounterSend.UseVisualStyleBackColor = false;
            this.Param_ScanlineCounterSend.Click += new System.EventHandler(this.Param_ScanlineCounterSend_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(5, 20);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "N of Scanlie";
            // 
            // Param_ScanlineCounterValue
            // 
            this.Param_ScanlineCounterValue.Font = new System.Drawing.Font("D2Coding", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Param_ScanlineCounterValue.Location = new System.Drawing.Point(8, 36);
            this.Param_ScanlineCounterValue.Name = "Param_ScanlineCounterValue";
            this.Param_ScanlineCounterValue.Size = new System.Drawing.Size(128, 21);
            this.Param_ScanlineCounterValue.TabIndex = 4;
            this.Param_ScanlineCounterValue.Text = "0";
            this.Param_ScanlineCounterValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox_HexToBinary
            // 
            this.groupBox_HexToBinary.Controls.Add(this.Param_HexToBinarySend);
            this.groupBox_HexToBinary.Controls.Add(this.label_ParamBinaryNumber);
            this.groupBox_HexToBinary.Controls.Add(this.Param_BinaryNumber);
            this.groupBox_HexToBinary.Controls.Add(this.label_ParamHexNumber);
            this.groupBox_HexToBinary.Controls.Add(this.Param_HexNumber);
            this.groupBox_HexToBinary.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox_HexToBinary.Location = new System.Drawing.Point(6, 6);
            this.groupBox_HexToBinary.Name = "groupBox_HexToBinary";
            this.groupBox_HexToBinary.Size = new System.Drawing.Size(454, 68);
            this.groupBox_HexToBinary.TabIndex = 0;
            this.groupBox_HexToBinary.TabStop = false;
            this.groupBox_HexToBinary.Text = "Prameter Hex To Binary";
            // 
            // Param_HexToBinarySend
            // 
            this.Param_HexToBinarySend.BackColor = System.Drawing.Color.Black;
            this.Param_HexToBinarySend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Param_HexToBinarySend.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.Param_HexToBinarySend.ForeColor = System.Drawing.Color.Transparent;
            this.Param_HexToBinarySend.Location = new System.Drawing.Point(387, 20);
            this.Param_HexToBinarySend.Name = "Param_HexToBinarySend";
            this.Param_HexToBinarySend.Size = new System.Drawing.Size(58, 39);
            this.Param_HexToBinarySend.TabIndex = 1;
            this.Param_HexToBinarySend.Text = "SEND";
            this.Param_HexToBinarySend.UseVisualStyleBackColor = false;
            this.Param_HexToBinarySend.Click += new System.EventHandler(this.Param_HexToBinarySend_Click);
            // 
            // label_ParamBinaryNumber
            // 
            this.label_ParamBinaryNumber.AutoSize = true;
            this.label_ParamBinaryNumber.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_ParamBinaryNumber.ForeColor = System.Drawing.Color.DimGray;
            this.label_ParamBinaryNumber.Location = new System.Drawing.Point(140, 20);
            this.label_ParamBinaryNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ParamBinaryNumber.Name = "label_ParamBinaryNumber";
            this.label_ParamBinaryNumber.Size = new System.Drawing.Size(144, 13);
            this.label_ParamBinaryNumber.TabIndex = 21;
            this.label_ParamBinaryNumber.Text = "Parameter Binary Number";
            // 
            // Param_BinaryNumber
            // 
            this.Param_BinaryNumber.Font = new System.Drawing.Font("D2Coding", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Param_BinaryNumber.Location = new System.Drawing.Point(142, 36);
            this.Param_BinaryNumber.Name = "Param_BinaryNumber";
            this.Param_BinaryNumber.ReadOnly = true;
            this.Param_BinaryNumber.Size = new System.Drawing.Size(242, 23);
            this.Param_BinaryNumber.TabIndex = 20;
            this.Param_BinaryNumber.Text = "10000100000101010000000011111111";
            this.Param_BinaryNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_ParamHexNumber
            // 
            this.label_ParamHexNumber.AutoSize = true;
            this.label_ParamHexNumber.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_ParamHexNumber.ForeColor = System.Drawing.Color.DimGray;
            this.label_ParamHexNumber.Location = new System.Drawing.Point(5, 20);
            this.label_ParamHexNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ParamHexNumber.Name = "label_ParamHexNumber";
            this.label_ParamHexNumber.Size = new System.Drawing.Size(131, 13);
            this.label_ParamHexNumber.TabIndex = 19;
            this.label_ParamHexNumber.Text = "Parameter Hex Number";
            // 
            // Param_HexNumber
            // 
            this.Param_HexNumber.Font = new System.Drawing.Font("D2Coding", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Param_HexNumber.Location = new System.Drawing.Point(8, 36);
            this.Param_HexNumber.Name = "Param_HexNumber";
            this.Param_HexNumber.Size = new System.Drawing.Size(128, 21);
            this.Param_HexNumber.TabIndex = 4;
            this.Param_HexNumber.Text = "841500FF";
            this.Param_HexNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MITS_SYSTEM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1314, 738);
            this.Controls.Add(this.ParameterGroup);
            this.Controls.Add(this.GraphicGroup);
            this.Name = "MITS_SYSTEM";
            this.Text = "MITS_SINGLE_SYSTEM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MITS_SYSTEM_FormClosing);
            this.Load += new System.EventHandler(this.MITS_SYSTEM_Load);
            this.GraphicGroup.ResumeLayout(false);
            this.groupBox_ImagingView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImagingBox)).EndInit();
            this.groupBox_BoardData.ResumeLayout(false);
            this.groupBox_BoardData.PerformLayout();
            this.groupBox_SystemLog.ResumeLayout(false);
            this.groupBox_SystemLog.PerformLayout();
            this.ParameterGroup.ResumeLayout(false);
            this.tabMainControl.ResumeLayout(false);
            this.tabPage1_main.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox_CH1.ResumeLayout(false);
            this.groupBox_CH1_HV.ResumeLayout(false);
            this.groupBox_CH1_HV.PerformLayout();
            this.groupBox_CH1_ModeSelect.ResumeLayout(false);
            this.groupBox_CH1_ModeSelect.PerformLayout();
            this.groupBox_CH1_AFE.ResumeLayout(false);
            this.groupBox_CH1_AFE.PerformLayout();
            this.groupBox_CH1_TxParameter.ResumeLayout(false);
            this.groupBox_CH1_TxParameter.PerformLayout();
            this.tabPage2_option.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox_HexToBinary.ResumeLayout(false);
            this.groupBox_HexToBinary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GraphicGroup;
        private System.Windows.Forms.GroupBox ParameterGroup;
        private System.Windows.Forms.GroupBox groupBox_SystemLog;
        private System.Windows.Forms.TabControl tabMainControl;
        private System.Windows.Forms.TabPage tabPage1_main;
        private System.Windows.Forms.TabPage tabPage2_option;
        private System.Windows.Forms.GroupBox groupBox_CH1;
        private System.Windows.Forms.GroupBox groupBox_CH1_ModeSelect;
        private System.Windows.Forms.RadioButton CH1_Mode_Stimul;
        private System.Windows.Forms.RadioButton CH1_Mode_Imaging;
        private System.Windows.Forms.GroupBox groupBox_CH1_AFE;
        private System.Windows.Forms.GroupBox groupBox_ModeSelect;
        private System.Windows.Forms.GroupBox groupBox_CH1_TxParameter;
        private System.Windows.Forms.TextBox CH1_PulseDuration;
        private System.Windows.Forms.Label CH1_label_PulseDuration;
        private System.Windows.Forms.TextBox CH1_PRF;
        private System.Windows.Forms.Label CH1_label_PRF;
        private System.Windows.Forms.Label CH1_label_ViewDepth;
        private System.Windows.Forms.ComboBox CH1_ViewDepth;
        private System.Windows.Forms.ComboBox CH1_PulseCycles;
        private System.Windows.Forms.Label CH1_label_PulseCycles;
        private System.Windows.Forms.ComboBox CH1_CF;
        private System.Windows.Forms.TextBox CH1_Scanline;
        private System.Windows.Forms.Label CH1_label_CF;
        private System.Windows.Forms.Label CH1_label_Scanline;
        private System.Windows.Forms.GroupBox groupBox_CH1_HV;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button CH1_VolatageControl;
        private System.Windows.Forms.Label CH1_label_VoltageLevel;
        private System.Windows.Forms.TextBox CH1_HVLevel;
        private System.Windows.Forms.RadioButton CH1_HV_External;
        private System.Windows.Forms.RadioButton CH1_HV_Internal;
        private System.Windows.Forms.Label CH1_label_ADCGain;
        private System.Windows.Forms.Label CH1_label_PGAGain;
        private System.Windows.Forms.Label CH1_label_LPF;
        private System.Windows.Forms.ComboBox CH1_ADCGain;
        private System.Windows.Forms.ComboBox CH1_PGAGain;
        private System.Windows.Forms.ComboBox CH1_LPF;
        private System.Windows.Forms.Button CH1_PulseControl;
        private System.Windows.Forms.Button CH1_Reset;
        private System.Windows.Forms.Button CH1_ScanControl;
        private System.Windows.Forms.GroupBox groupBox_BoardData;
        private System.Windows.Forms.Label label_OutEndpoint;
        private System.Windows.Forms.Label label_InEndpoint;
        private System.Windows.Forms.Label label_SystemBoard;
        private System.Windows.Forms.ComboBox SystemBoardOUTEndpoint;
        private System.Windows.Forms.ComboBox SystemBoardINEndpoint;
        private System.Windows.Forms.ComboBox SystemBoardConnection;
        private System.Windows.Forms.TextBox SystemLogBox;
        private System.Windows.Forms.GroupBox groupBox_HexToBinary;
        private System.Windows.Forms.Button Param_HexToBinarySend;
        private System.Windows.Forms.Label label_ParamBinaryNumber;
        private System.Windows.Forms.TextBox Param_BinaryNumber;
        private System.Windows.Forms.Label label_ParamHexNumber;
        private System.Windows.Forms.TextBox Param_HexNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox CH1_DynamicRange;
        private System.Windows.Forms.Label CH1_label_DynamicRange;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button Param_ScanlineCounterSend;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Param_ScanlineCounterValue;
        private System.Windows.Forms.Button Param_ScanlineCounterSet;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button Param_ScanlineSelectView;
        private System.Windows.Forms.Button Param_ScanlineTotalView;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Param_ScanlineViewValue;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Button Param_ScanlineSelectTestDataView;
        private System.Windows.Forms.Button Param_ScanlineTotalTestDataView;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Param_ScanlineTestDataViewValue;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_timer;
        private System.Windows.Forms.Button Param_TestDataReset;
        private System.Windows.Forms.Button Param_TestDataStart;
        private System.Windows.Forms.GroupBox groupBox_ImagingView;
        private System.Windows.Forms.PictureBox ImagingBox;
    }
}

