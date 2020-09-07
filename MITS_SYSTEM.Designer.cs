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
            this.groupBox_Roatation_Motor_Control = new System.Windows.Forms.GroupBox();
            this.RotationMotorControl_Imaging = new System.Windows.Forms.Button();
            this.RotationMotorControl_HIFU = new System.Windows.Forms.Button();
            this.groupBox_LinearMotorControl = new System.Windows.Forms.GroupBox();
            this.linear_loopMode = new System.Windows.Forms.CheckBox();
            this.linear_positionMove = new System.Windows.Forms.Button();
            this.groupBox_CH2 = new System.Windows.Forms.GroupBox();
            this.CH2_Reset = new System.Windows.Forms.Button();
            this.CH2_ScanControl = new System.Windows.Forms.Button();
            this.CH2_PulseControl = new System.Windows.Forms.Button();
            this.groupBox_CH2_HV = new System.Windows.Forms.GroupBox();
            this.CH2_VolatageControl = new System.Windows.Forms.Button();
            this.CH2_label_VoltageLevel = new System.Windows.Forms.Label();
            this.CH2_HVLevel = new System.Windows.Forms.TextBox();
            this.CH2_HV_External = new System.Windows.Forms.RadioButton();
            this.CH2_HV_Internal = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox_CH2_ModeSelect = new System.Windows.Forms.GroupBox();
            this.CH2_Mode_Stimul = new System.Windows.Forms.RadioButton();
            this.CH2_Mode_Imaging = new System.Windows.Forms.RadioButton();
            this.groupBox_CH2_AFE = new System.Windows.Forms.GroupBox();
            this.CH2_label_ADCGain = new System.Windows.Forms.Label();
            this.CH2_label_PGAGain = new System.Windows.Forms.Label();
            this.CH2_label_LPF = new System.Windows.Forms.Label();
            this.CH2_ADCGain = new System.Windows.Forms.ComboBox();
            this.CH2_PGAGain = new System.Windows.Forms.ComboBox();
            this.CH2_LPF = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox_CH2_TxParameter = new System.Windows.Forms.GroupBox();
            this.CH2_DynamicRange = new System.Windows.Forms.TextBox();
            this.CH2_label_DynamicRange = new System.Windows.Forms.Label();
            this.CH2_PulseDuration = new System.Windows.Forms.TextBox();
            this.CH2_label_PulseDuration = new System.Windows.Forms.Label();
            this.CH2_PRF = new System.Windows.Forms.TextBox();
            this.CH2_label_PRF = new System.Windows.Forms.Label();
            this.CH2_label_ViewDepth = new System.Windows.Forms.Label();
            this.CH2_ViewDepth = new System.Windows.Forms.ComboBox();
            this.CH2_PulseCycles = new System.Windows.Forms.ComboBox();
            this.CH2_label_PulseCycles = new System.Windows.Forms.Label();
            this.CH2_CF = new System.Windows.Forms.ComboBox();
            this.CH2_Scanline = new System.Windows.Forms.TextBox();
            this.CH2_label_CF = new System.Windows.Forms.Label();
            this.CH2_label_Scanline = new System.Windows.Forms.Label();
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
            this.tabPage_motorControl = new System.Windows.Forms.TabPage();
            this.groupBox_motorMovingInterface = new System.Windows.Forms.GroupBox();
            this.motor_PositionFlag = new System.Windows.Forms.TextBox();
            this.label_position_flag = new System.Windows.Forms.Label();
            this.motor_1Way = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.motor_RepeatControl = new System.Windows.Forms.Button();
            this.motor_timer_box = new System.Windows.Forms.TextBox();
            this.label_motor_timer = new System.Windows.Forms.Label();
            this.groupBox_motorPositionInfo = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.motor_PositionCheck = new System.Windows.Forms.Button();
            this.motor_PositionReset = new System.Windows.Forms.Button();
            this.motor_PositionSet = new System.Windows.Forms.Button();
            this.motor_MovingPosition = new System.Windows.Forms.TextBox();
            this.motor_PresentPosition = new System.Windows.Forms.TextBox();
            this.label_moving_position = new System.Windows.Forms.Label();
            this.label_present_position = new System.Windows.Forms.Label();
            this.groupBox_motorConnectionInfo = new System.Windows.Forms.GroupBox();
            this.motor_ConnectionControl = new System.Windows.Forms.Button();
            this.motor_ServoID = new System.Windows.Forms.TextBox();
            this.motor_Comport = new System.Windows.Forms.ComboBox();
            this.label_servo_id = new System.Windows.Forms.Label();
            this.label_motor_comport = new System.Windows.Forms.Label();
            this.GraphicGroup.SuspendLayout();
            this.groupBox_ImagingView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagingBox)).BeginInit();
            this.groupBox_BoardData.SuspendLayout();
            this.groupBox_SystemLog.SuspendLayout();
            this.ParameterGroup.SuspendLayout();
            this.tabMainControl.SuspendLayout();
            this.tabPage1_main.SuspendLayout();
            this.groupBox_Roatation_Motor_Control.SuspendLayout();
            this.groupBox_LinearMotorControl.SuspendLayout();
            this.groupBox_CH2.SuspendLayout();
            this.groupBox_CH2_HV.SuspendLayout();
            this.groupBox_CH2_ModeSelect.SuspendLayout();
            this.groupBox_CH2_AFE.SuspendLayout();
            this.groupBox_CH2_TxParameter.SuspendLayout();
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
            this.tabPage_motorControl.SuspendLayout();
            this.groupBox_motorMovingInterface.SuspendLayout();
            this.groupBox_motorPositionInfo.SuspendLayout();
            this.groupBox_motorConnectionInfo.SuspendLayout();
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
            this.SystemBoardOUTEndpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SystemBoardOUTEndpoint.FormattingEnabled = true;
            this.SystemBoardOUTEndpoint.Location = new System.Drawing.Point(89, 63);
            this.SystemBoardOUTEndpoint.Name = "SystemBoardOUTEndpoint";
            this.SystemBoardOUTEndpoint.Size = new System.Drawing.Size(289, 21);
            this.SystemBoardOUTEndpoint.TabIndex = 27;
            // 
            // SystemBoardINEndpoint
            // 
            this.SystemBoardINEndpoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SystemBoardINEndpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SystemBoardINEndpoint.FormattingEnabled = true;
            this.SystemBoardINEndpoint.Location = new System.Drawing.Point(89, 41);
            this.SystemBoardINEndpoint.Name = "SystemBoardINEndpoint";
            this.SystemBoardINEndpoint.Size = new System.Drawing.Size(289, 21);
            this.SystemBoardINEndpoint.TabIndex = 26;
            // 
            // SystemBoardConnection
            // 
            this.SystemBoardConnection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SystemBoardConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.SystemLogBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
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
            this.tabMainControl.Controls.Add(this.tabPage_motorControl);
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
            this.tabPage1_main.Controls.Add(this.groupBox_Roatation_Motor_Control);
            this.tabPage1_main.Controls.Add(this.groupBox_LinearMotorControl);
            this.tabPage1_main.Controls.Add(this.groupBox_CH2);
            this.tabPage1_main.Controls.Add(this.groupBox_CH1);
            this.tabPage1_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabPage1_main.Location = new System.Drawing.Point(4, 34);
            this.tabPage1_main.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1_main.Name = "tabPage1_main";
            this.tabPage1_main.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1_main.Size = new System.Drawing.Size(466, 680);
            this.tabPage1_main.TabIndex = 5;
            this.tabPage1_main.Text = "MAIN";
            // 
            // groupBox_Roatation_Motor_Control
            // 
            this.groupBox_Roatation_Motor_Control.Controls.Add(this.RotationMotorControl_Imaging);
            this.groupBox_Roatation_Motor_Control.Controls.Add(this.RotationMotorControl_HIFU);
            this.groupBox_Roatation_Motor_Control.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox_Roatation_Motor_Control.Location = new System.Drawing.Point(239, 614);
            this.groupBox_Roatation_Motor_Control.Name = "groupBox_Roatation_Motor_Control";
            this.groupBox_Roatation_Motor_Control.Size = new System.Drawing.Size(222, 63);
            this.groupBox_Roatation_Motor_Control.TabIndex = 26;
            this.groupBox_Roatation_Motor_Control.TabStop = false;
            this.groupBox_Roatation_Motor_Control.Text = "Roatation Motor Control";
            // 
            // RotationMotorControl_Imaging
            // 
            this.RotationMotorControl_Imaging.BackColor = System.Drawing.Color.Navy;
            this.RotationMotorControl_Imaging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RotationMotorControl_Imaging.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.RotationMotorControl_Imaging.ForeColor = System.Drawing.Color.Transparent;
            this.RotationMotorControl_Imaging.Location = new System.Drawing.Point(113, 21);
            this.RotationMotorControl_Imaging.Name = "RotationMotorControl_Imaging";
            this.RotationMotorControl_Imaging.Size = new System.Drawing.Size(103, 35);
            this.RotationMotorControl_Imaging.TabIndex = 35;
            this.RotationMotorControl_Imaging.Text = "IMAGING";
            this.RotationMotorControl_Imaging.UseVisualStyleBackColor = false;
            this.RotationMotorControl_Imaging.Click += new System.EventHandler(this.RotationMotorControl_Imaging_Click);
            // 
            // RotationMotorControl_HIFU
            // 
            this.RotationMotorControl_HIFU.BackColor = System.Drawing.Color.Red;
            this.RotationMotorControl_HIFU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RotationMotorControl_HIFU.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.RotationMotorControl_HIFU.ForeColor = System.Drawing.Color.Transparent;
            this.RotationMotorControl_HIFU.Location = new System.Drawing.Point(6, 21);
            this.RotationMotorControl_HIFU.Name = "RotationMotorControl_HIFU";
            this.RotationMotorControl_HIFU.Size = new System.Drawing.Size(103, 35);
            this.RotationMotorControl_HIFU.TabIndex = 34;
            this.RotationMotorControl_HIFU.Text = "HIFU";
            this.RotationMotorControl_HIFU.UseVisualStyleBackColor = false;
            this.RotationMotorControl_HIFU.Click += new System.EventHandler(this.RotationMotorControl_HIFU_Click);
            // 
            // groupBox_LinearMotorControl
            // 
            this.groupBox_LinearMotorControl.Controls.Add(this.linear_loopMode);
            this.groupBox_LinearMotorControl.Controls.Add(this.linear_positionMove);
            this.groupBox_LinearMotorControl.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox_LinearMotorControl.Location = new System.Drawing.Point(11, 614);
            this.groupBox_LinearMotorControl.Name = "groupBox_LinearMotorControl";
            this.groupBox_LinearMotorControl.Size = new System.Drawing.Size(222, 63);
            this.groupBox_LinearMotorControl.TabIndex = 25;
            this.groupBox_LinearMotorControl.TabStop = false;
            this.groupBox_LinearMotorControl.Text = "Linear Motor Control";
            // 
            // linear_loopMode
            // 
            this.linear_loopMode.AutoSize = true;
            this.linear_loopMode.Location = new System.Drawing.Point(6, 30);
            this.linear_loopMode.Name = "linear_loopMode";
            this.linear_loopMode.Size = new System.Drawing.Size(105, 17);
            this.linear_loopMode.TabIndex = 35;
            this.linear_loopMode.Text = "Loop Mode";
            this.linear_loopMode.UseVisualStyleBackColor = true;
            this.linear_loopMode.CheckedChanged += new System.EventHandler(this.linear_loopMode_CheckedChanged);
            // 
            // linear_positionMove
            // 
            this.linear_positionMove.BackColor = System.Drawing.Color.Black;
            this.linear_positionMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.linear_positionMove.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.linear_positionMove.ForeColor = System.Drawing.Color.Transparent;
            this.linear_positionMove.Location = new System.Drawing.Point(113, 21);
            this.linear_positionMove.Name = "linear_positionMove";
            this.linear_positionMove.Size = new System.Drawing.Size(103, 35);
            this.linear_positionMove.TabIndex = 34;
            this.linear_positionMove.Text = "MOVE";
            this.linear_positionMove.UseVisualStyleBackColor = false;
            this.linear_positionMove.Click += new System.EventHandler(this.linear_positionMove_Click);
            // 
            // groupBox_CH2
            // 
            this.groupBox_CH2.Controls.Add(this.CH2_Reset);
            this.groupBox_CH2.Controls.Add(this.CH2_ScanControl);
            this.groupBox_CH2.Controls.Add(this.CH2_PulseControl);
            this.groupBox_CH2.Controls.Add(this.groupBox_CH2_HV);
            this.groupBox_CH2.Controls.Add(this.groupBox_CH2_ModeSelect);
            this.groupBox_CH2.Controls.Add(this.groupBox_CH2_AFE);
            this.groupBox_CH2.Controls.Add(this.groupBox_CH2_TxParameter);
            this.groupBox_CH2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox_CH2.Location = new System.Drawing.Point(5, 311);
            this.groupBox_CH2.Name = "groupBox_CH2";
            this.groupBox_CH2.Size = new System.Drawing.Size(456, 300);
            this.groupBox_CH2.TabIndex = 24;
            this.groupBox_CH2.TabStop = false;
            this.groupBox_CH2.Text = "Channel 2";
            // 
            // CH2_Reset
            // 
            this.CH2_Reset.BackColor = System.Drawing.Color.DimGray;
            this.CH2_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CH2_Reset.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.CH2_Reset.ForeColor = System.Drawing.Color.White;
            this.CH2_Reset.Location = new System.Drawing.Point(6, 263);
            this.CH2_Reset.Name = "CH2_Reset";
            this.CH2_Reset.Size = new System.Drawing.Size(79, 31);
            this.CH2_Reset.TabIndex = 1030;
            this.CH2_Reset.Text = "RESET";
            this.CH2_Reset.UseVisualStyleBackColor = false;
            this.CH2_Reset.Click += new System.EventHandler(this.CH2_Reset_Click);
            // 
            // CH2_ScanControl
            // 
            this.CH2_ScanControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CH2_ScanControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CH2_ScanControl.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.CH2_ScanControl.ForeColor = System.Drawing.Color.White;
            this.CH2_ScanControl.Location = new System.Drawing.Point(91, 263);
            this.CH2_ScanControl.Name = "CH2_ScanControl";
            this.CH2_ScanControl.Size = new System.Drawing.Size(173, 31);
            this.CH2_ScanControl.TabIndex = 1029;
            this.CH2_ScanControl.Text = "SCAN SET";
            this.CH2_ScanControl.UseVisualStyleBackColor = false;
            // 
            // CH2_PulseControl
            // 
            this.CH2_PulseControl.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.CH2_PulseControl.Enabled = false;
            this.CH2_PulseControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CH2_PulseControl.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.CH2_PulseControl.ForeColor = System.Drawing.Color.White;
            this.CH2_PulseControl.Location = new System.Drawing.Point(277, 263);
            this.CH2_PulseControl.Name = "CH2_PulseControl";
            this.CH2_PulseControl.Size = new System.Drawing.Size(173, 31);
            this.CH2_PulseControl.TabIndex = 1028;
            this.CH2_PulseControl.Text = "Pulser ON";
            this.CH2_PulseControl.UseVisualStyleBackColor = false;
            this.CH2_PulseControl.Click += new System.EventHandler(this.CH2_PulseControl_Click);
            // 
            // groupBox_CH2_HV
            // 
            this.groupBox_CH2_HV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_CH2_HV.Controls.Add(this.CH2_VolatageControl);
            this.groupBox_CH2_HV.Controls.Add(this.CH2_label_VoltageLevel);
            this.groupBox_CH2_HV.Controls.Add(this.CH2_HVLevel);
            this.groupBox_CH2_HV.Controls.Add(this.CH2_HV_External);
            this.groupBox_CH2_HV.Controls.Add(this.CH2_HV_Internal);
            this.groupBox_CH2_HV.Controls.Add(this.groupBox3);
            this.groupBox_CH2_HV.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox_CH2_HV.Location = new System.Drawing.Point(271, 133);
            this.groupBox_CH2_HV.Name = "groupBox_CH2_HV";
            this.groupBox_CH2_HV.Size = new System.Drawing.Size(182, 124);
            this.groupBox_CH2_HV.TabIndex = 26;
            this.groupBox_CH2_HV.TabStop = false;
            this.groupBox_CH2_HV.Text = "High Voltage";
            // 
            // CH2_VolatageControl
            // 
            this.CH2_VolatageControl.BackColor = System.Drawing.Color.Brown;
            this.CH2_VolatageControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CH2_VolatageControl.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.CH2_VolatageControl.ForeColor = System.Drawing.Color.White;
            this.CH2_VolatageControl.Location = new System.Drawing.Point(6, 82);
            this.CH2_VolatageControl.Name = "CH2_VolatageControl";
            this.CH2_VolatageControl.Size = new System.Drawing.Size(173, 31);
            this.CH2_VolatageControl.TabIndex = 1027;
            this.CH2_VolatageControl.Text = "HV ON";
            this.CH2_VolatageControl.UseVisualStyleBackColor = false;
            this.CH2_VolatageControl.Click += new System.EventHandler(this.CH2_VolatageControl_Click);
            // 
            // CH2_label_VoltageLevel
            // 
            this.CH2_label_VoltageLevel.AutoSize = true;
            this.CH2_label_VoltageLevel.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CH2_label_VoltageLevel.ForeColor = System.Drawing.Color.DimGray;
            this.CH2_label_VoltageLevel.Location = new System.Drawing.Point(5, 54);
            this.CH2_label_VoltageLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CH2_label_VoltageLevel.Name = "CH2_label_VoltageLevel";
            this.CH2_label_VoltageLevel.Size = new System.Drawing.Size(97, 13);
            this.CH2_label_VoltageLevel.TabIndex = 1026;
            this.CH2_label_VoltageLevel.Text = "Voltage Level (V)";
            // 
            // CH2_HVLevel
            // 
            this.CH2_HVLevel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CH2_HVLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CH2_HVLevel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CH2_HVLevel.Location = new System.Drawing.Point(107, 54);
            this.CH2_HVLevel.Name = "CH2_HVLevel";
            this.CH2_HVLevel.Size = new System.Drawing.Size(69, 14);
            this.CH2_HVLevel.TabIndex = 1025;
            this.CH2_HVLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CH2_HVLevel.TextChanged += new System.EventHandler(this.CH2_HVLevel_TextChanged);
            // 
            // CH2_HV_External
            // 
            this.CH2_HV_External.AutoSize = true;
            this.CH2_HV_External.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Bold);
            this.CH2_HV_External.Location = new System.Drawing.Point(85, 23);
            this.CH2_HV_External.Name = "CH2_HV_External";
            this.CH2_HV_External.Size = new System.Drawing.Size(76, 15);
            this.CH2_HV_External.TabIndex = 27;
            this.CH2_HV_External.TabStop = true;
            this.CH2_HV_External.Text = "External";
            this.CH2_HV_External.UseVisualStyleBackColor = true;
            // 
            // CH2_HV_Internal
            // 
            this.CH2_HV_Internal.AutoSize = true;
            this.CH2_HV_Internal.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Bold);
            this.CH2_HV_Internal.Location = new System.Drawing.Point(6, 23);
            this.CH2_HV_Internal.Name = "CH2_HV_Internal";
            this.CH2_HV_Internal.Size = new System.Drawing.Size(73, 15);
            this.CH2_HV_Internal.TabIndex = 26;
            this.CH2_HV_Internal.TabStop = true;
            this.CH2_HV_Internal.Text = "Internal";
            this.CH2_HV_Internal.UseVisualStyleBackColor = true;
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
            // groupBox_CH2_ModeSelect
            // 
            this.groupBox_CH2_ModeSelect.Controls.Add(this.CH2_Mode_Stimul);
            this.groupBox_CH2_ModeSelect.Controls.Add(this.CH2_Mode_Imaging);
            this.groupBox_CH2_ModeSelect.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox_CH2_ModeSelect.Location = new System.Drawing.Point(6, 21);
            this.groupBox_CH2_ModeSelect.Name = "groupBox_CH2_ModeSelect";
            this.groupBox_CH2_ModeSelect.Size = new System.Drawing.Size(258, 46);
            this.groupBox_CH2_ModeSelect.TabIndex = 25;
            this.groupBox_CH2_ModeSelect.TabStop = false;
            this.groupBox_CH2_ModeSelect.Text = "Mode Select";
            // 
            // CH2_Mode_Stimul
            // 
            this.CH2_Mode_Stimul.AutoSize = true;
            this.CH2_Mode_Stimul.Checked = true;
            this.CH2_Mode_Stimul.Location = new System.Drawing.Point(95, 20);
            this.CH2_Mode_Stimul.Name = "CH2_Mode_Stimul";
            this.CH2_Mode_Stimul.Size = new System.Drawing.Size(74, 16);
            this.CH2_Mode_Stimul.TabIndex = 1;
            this.CH2_Mode_Stimul.TabStop = true;
            this.CH2_Mode_Stimul.Text = "STIMUL";
            this.CH2_Mode_Stimul.UseVisualStyleBackColor = true;
            this.CH2_Mode_Stimul.CheckedChanged += new System.EventHandler(this.CH2_Mode_Stimul_CheckedChanged);
            // 
            // CH2_Mode_Imaging
            // 
            this.CH2_Mode_Imaging.AutoSize = true;
            this.CH2_Mode_Imaging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CH2_Mode_Imaging.Location = new System.Drawing.Point(8, 20);
            this.CH2_Mode_Imaging.Name = "CH2_Mode_Imaging";
            this.CH2_Mode_Imaging.Size = new System.Drawing.Size(81, 16);
            this.CH2_Mode_Imaging.TabIndex = 0;
            this.CH2_Mode_Imaging.Text = "IMAGING";
            this.CH2_Mode_Imaging.UseVisualStyleBackColor = true;
            this.CH2_Mode_Imaging.CheckedChanged += new System.EventHandler(this.CH2_Mode_Imaging_CheckedChanged);
            // 
            // groupBox_CH2_AFE
            // 
            this.groupBox_CH2_AFE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_CH2_AFE.Controls.Add(this.CH2_label_ADCGain);
            this.groupBox_CH2_AFE.Controls.Add(this.CH2_label_PGAGain);
            this.groupBox_CH2_AFE.Controls.Add(this.CH2_label_LPF);
            this.groupBox_CH2_AFE.Controls.Add(this.CH2_ADCGain);
            this.groupBox_CH2_AFE.Controls.Add(this.CH2_PGAGain);
            this.groupBox_CH2_AFE.Controls.Add(this.CH2_LPF);
            this.groupBox_CH2_AFE.Controls.Add(this.groupBox7);
            this.groupBox_CH2_AFE.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox_CH2_AFE.Location = new System.Drawing.Point(270, 10);
            this.groupBox_CH2_AFE.Name = "groupBox_CH2_AFE";
            this.groupBox_CH2_AFE.Size = new System.Drawing.Size(182, 117);
            this.groupBox_CH2_AFE.TabIndex = 24;
            this.groupBox_CH2_AFE.TabStop = false;
            this.groupBox_CH2_AFE.Text = "AFE Parameter";
            // 
            // CH2_label_ADCGain
            // 
            this.CH2_label_ADCGain.AutoSize = true;
            this.CH2_label_ADCGain.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CH2_label_ADCGain.ForeColor = System.Drawing.Color.DimGray;
            this.CH2_label_ADCGain.Location = new System.Drawing.Point(6, 78);
            this.CH2_label_ADCGain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CH2_label_ADCGain.Name = "CH2_label_ADCGain";
            this.CH2_label_ADCGain.Size = new System.Drawing.Size(58, 13);
            this.CH2_label_ADCGain.TabIndex = 49;
            this.CH2_label_ADCGain.Text = "ADC Gain";
            // 
            // CH2_label_PGAGain
            // 
            this.CH2_label_PGAGain.AutoSize = true;
            this.CH2_label_PGAGain.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CH2_label_PGAGain.ForeColor = System.Drawing.Color.DimGray;
            this.CH2_label_PGAGain.Location = new System.Drawing.Point(6, 49);
            this.CH2_label_PGAGain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CH2_label_PGAGain.Name = "CH2_label_PGAGain";
            this.CH2_label_PGAGain.Size = new System.Drawing.Size(58, 13);
            this.CH2_label_PGAGain.TabIndex = 48;
            this.CH2_label_PGAGain.Text = "PGA Gain";
            // 
            // CH2_label_LPF
            // 
            this.CH2_label_LPF.AutoSize = true;
            this.CH2_label_LPF.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CH2_label_LPF.ForeColor = System.Drawing.Color.DimGray;
            this.CH2_label_LPF.Location = new System.Drawing.Point(6, 23);
            this.CH2_label_LPF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CH2_label_LPF.Name = "CH2_label_LPF";
            this.CH2_label_LPF.Size = new System.Drawing.Size(48, 13);
            this.CH2_label_LPF.TabIndex = 47;
            this.CH2_label_LPF.Text = "LPF SET";
            // 
            // CH2_ADCGain
            // 
            this.CH2_ADCGain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CH2_ADCGain.FormattingEnabled = true;
            this.CH2_ADCGain.Items.AddRange(new object[] {
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
            this.CH2_ADCGain.Location = new System.Drawing.Point(111, 75);
            this.CH2_ADCGain.Name = "CH2_ADCGain";
            this.CH2_ADCGain.Size = new System.Drawing.Size(66, 20);
            this.CH2_ADCGain.TabIndex = 45;
            this.CH2_ADCGain.SelectedValueChanged += new System.EventHandler(this.CH2_ADCGain_SelectedValueChanged);
            // 
            // CH2_PGAGain
            // 
            this.CH2_PGAGain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CH2_PGAGain.FormattingEnabled = true;
            this.CH2_PGAGain.Items.AddRange(new object[] {
            "0dB",
            "3dB",
            "6dB",
            "9dB",
            "12dB",
            "15dB",
            "18dB"});
            this.CH2_PGAGain.Location = new System.Drawing.Point(111, 46);
            this.CH2_PGAGain.Name = "CH2_PGAGain";
            this.CH2_PGAGain.Size = new System.Drawing.Size(66, 20);
            this.CH2_PGAGain.TabIndex = 44;
            this.CH2_PGAGain.SelectedValueChanged += new System.EventHandler(this.CH2_PGAGain_SelectedValueChanged);
            // 
            // CH2_LPF
            // 
            this.CH2_LPF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CH2_LPF.FormattingEnabled = true;
            this.CH2_LPF.Items.AddRange(new object[] {
            "60MHz",
            "75MHz"});
            this.CH2_LPF.Location = new System.Drawing.Point(111, 20);
            this.CH2_LPF.Name = "CH2_LPF";
            this.CH2_LPF.Size = new System.Drawing.Size(66, 20);
            this.CH2_LPF.TabIndex = 43;
            this.CH2_LPF.SelectedValueChanged += new System.EventHandler(this.CH2_LPF_SelectedValueChanged);
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
            // groupBox_CH2_TxParameter
            // 
            this.groupBox_CH2_TxParameter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_CH2_TxParameter.Controls.Add(this.CH2_DynamicRange);
            this.groupBox_CH2_TxParameter.Controls.Add(this.CH2_label_DynamicRange);
            this.groupBox_CH2_TxParameter.Controls.Add(this.CH2_PulseDuration);
            this.groupBox_CH2_TxParameter.Controls.Add(this.CH2_label_PulseDuration);
            this.groupBox_CH2_TxParameter.Controls.Add(this.CH2_PRF);
            this.groupBox_CH2_TxParameter.Controls.Add(this.CH2_label_PRF);
            this.groupBox_CH2_TxParameter.Controls.Add(this.CH2_label_ViewDepth);
            this.groupBox_CH2_TxParameter.Controls.Add(this.CH2_ViewDepth);
            this.groupBox_CH2_TxParameter.Controls.Add(this.CH2_PulseCycles);
            this.groupBox_CH2_TxParameter.Controls.Add(this.CH2_label_PulseCycles);
            this.groupBox_CH2_TxParameter.Controls.Add(this.CH2_CF);
            this.groupBox_CH2_TxParameter.Controls.Add(this.CH2_Scanline);
            this.groupBox_CH2_TxParameter.Controls.Add(this.CH2_label_CF);
            this.groupBox_CH2_TxParameter.Controls.Add(this.CH2_label_Scanline);
            this.groupBox_CH2_TxParameter.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox_CH2_TxParameter.Location = new System.Drawing.Point(6, 73);
            this.groupBox_CH2_TxParameter.Name = "groupBox_CH2_TxParameter";
            this.groupBox_CH2_TxParameter.Size = new System.Drawing.Size(258, 184);
            this.groupBox_CH2_TxParameter.TabIndex = 23;
            this.groupBox_CH2_TxParameter.TabStop = false;
            this.groupBox_CH2_TxParameter.Text = "Tx Parameter";
            // 
            // CH2_DynamicRange
            // 
            this.CH2_DynamicRange.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CH2_DynamicRange.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CH2_DynamicRange.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CH2_DynamicRange.Location = new System.Drawing.Point(166, 136);
            this.CH2_DynamicRange.Name = "CH2_DynamicRange";
            this.CH2_DynamicRange.Size = new System.Drawing.Size(86, 14);
            this.CH2_DynamicRange.TabIndex = 1028;
            this.CH2_DynamicRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CH2_DynamicRange.TextChanged += new System.EventHandler(this.CH2_DynamicRange_TextChanged);
            // 
            // CH2_label_DynamicRange
            // 
            this.CH2_label_DynamicRange.AutoSize = true;
            this.CH2_label_DynamicRange.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CH2_label_DynamicRange.ForeColor = System.Drawing.Color.DimGray;
            this.CH2_label_DynamicRange.Location = new System.Drawing.Point(5, 136);
            this.CH2_label_DynamicRange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CH2_label_DynamicRange.Name = "CH2_label_DynamicRange";
            this.CH2_label_DynamicRange.Size = new System.Drawing.Size(115, 13);
            this.CH2_label_DynamicRange.TabIndex = 1027;
            this.CH2_label_DynamicRange.Text = "Dynamic Range (dB)";
            // 
            // CH2_PulseDuration
            // 
            this.CH2_PulseDuration.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CH2_PulseDuration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CH2_PulseDuration.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CH2_PulseDuration.Location = new System.Drawing.Point(166, 112);
            this.CH2_PulseDuration.Name = "CH2_PulseDuration";
            this.CH2_PulseDuration.Size = new System.Drawing.Size(86, 14);
            this.CH2_PulseDuration.TabIndex = 1026;
            this.CH2_PulseDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CH2_PulseDuration.TextChanged += new System.EventHandler(this.CH2_PulseDuration_TextChanged);
            // 
            // CH2_label_PulseDuration
            // 
            this.CH2_label_PulseDuration.AutoSize = true;
            this.CH2_label_PulseDuration.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CH2_label_PulseDuration.ForeColor = System.Drawing.Color.DimGray;
            this.CH2_label_PulseDuration.Location = new System.Drawing.Point(5, 112);
            this.CH2_label_PulseDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CH2_label_PulseDuration.Name = "CH2_label_PulseDuration";
            this.CH2_label_PulseDuration.Size = new System.Drawing.Size(146, 13);
            this.CH2_label_PulseDuration.TabIndex = 1025;
            this.CH2_label_PulseDuration.Text = "Pulse Duration (micro sec)";
            // 
            // CH2_PRF
            // 
            this.CH2_PRF.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CH2_PRF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CH2_PRF.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CH2_PRF.Location = new System.Drawing.Point(166, 40);
            this.CH2_PRF.Name = "CH2_PRF";
            this.CH2_PRF.Size = new System.Drawing.Size(86, 14);
            this.CH2_PRF.TabIndex = 1024;
            this.CH2_PRF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CH2_PRF.TextChanged += new System.EventHandler(this.CH2_PRF_TextChanged);
            // 
            // CH2_label_PRF
            // 
            this.CH2_label_PRF.AutoSize = true;
            this.CH2_label_PRF.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CH2_label_PRF.ForeColor = System.Drawing.Color.DimGray;
            this.CH2_label_PRF.Location = new System.Drawing.Point(5, 41);
            this.CH2_label_PRF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CH2_label_PRF.Name = "CH2_label_PRF";
            this.CH2_label_PRF.Size = new System.Drawing.Size(52, 13);
            this.CH2_label_PRF.TabIndex = 1023;
            this.CH2_label_PRF.Text = "PRF (Hz)";
            // 
            // CH2_label_ViewDepth
            // 
            this.CH2_label_ViewDepth.AutoSize = true;
            this.CH2_label_ViewDepth.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CH2_label_ViewDepth.ForeColor = System.Drawing.Color.DimGray;
            this.CH2_label_ViewDepth.Location = new System.Drawing.Point(5, 160);
            this.CH2_label_ViewDepth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CH2_label_ViewDepth.Name = "CH2_label_ViewDepth";
            this.CH2_label_ViewDepth.Size = new System.Drawing.Size(95, 13);
            this.CH2_label_ViewDepth.TabIndex = 1022;
            this.CH2_label_ViewDepth.Text = "View Depth (cm)";
            // 
            // CH2_ViewDepth
            // 
            this.CH2_ViewDepth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CH2_ViewDepth.FormattingEnabled = true;
            this.CH2_ViewDepth.Items.AddRange(new object[] {
            "None",
            "~1cm",
            "~2cm",
            "~3cm",
            "~4cm"});
            this.CH2_ViewDepth.Location = new System.Drawing.Point(166, 156);
            this.CH2_ViewDepth.Name = "CH2_ViewDepth";
            this.CH2_ViewDepth.Size = new System.Drawing.Size(86, 20);
            this.CH2_ViewDepth.TabIndex = 1020;
            this.CH2_ViewDepth.SelectedValueChanged += new System.EventHandler(this.CH2_ViewDepth_SelectedValueChanged);
            // 
            // CH2_PulseCycles
            // 
            this.CH2_PulseCycles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CH2_PulseCycles.FormattingEnabled = true;
            this.CH2_PulseCycles.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.CH2_PulseCycles.Location = new System.Drawing.Point(166, 86);
            this.CH2_PulseCycles.Name = "CH2_PulseCycles";
            this.CH2_PulseCycles.Size = new System.Drawing.Size(86, 20);
            this.CH2_PulseCycles.TabIndex = 1021;
            this.CH2_PulseCycles.SelectedValueChanged += new System.EventHandler(this.CH2_PulseCycles_SelectedValueChanged);
            // 
            // CH2_label_PulseCycles
            // 
            this.CH2_label_PulseCycles.AutoSize = true;
            this.CH2_label_PulseCycles.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CH2_label_PulseCycles.ForeColor = System.Drawing.Color.DimGray;
            this.CH2_label_PulseCycles.Location = new System.Drawing.Point(5, 89);
            this.CH2_label_PulseCycles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CH2_label_PulseCycles.Name = "CH2_label_PulseCycles";
            this.CH2_label_PulseCycles.Size = new System.Drawing.Size(92, 13);
            this.CH2_label_PulseCycles.TabIndex = 1019;
            this.CH2_label_PulseCycles.Text = "Pulse Cycles (N)";
            // 
            // CH2_CF
            // 
            this.CH2_CF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CH2_CF.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CH2_CF.FormattingEnabled = true;
            this.CH2_CF.Items.AddRange(new object[] {
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
            this.CH2_CF.Location = new System.Drawing.Point(166, 60);
            this.CH2_CF.Name = "CH2_CF";
            this.CH2_CF.Size = new System.Drawing.Size(86, 20);
            this.CH2_CF.TabIndex = 1018;
            this.CH2_CF.SelectedValueChanged += new System.EventHandler(this.CH2_CF_SelectedValueChanged);
            // 
            // CH2_Scanline
            // 
            this.CH2_Scanline.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CH2_Scanline.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CH2_Scanline.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CH2_Scanline.Location = new System.Drawing.Point(166, 20);
            this.CH2_Scanline.Name = "CH2_Scanline";
            this.CH2_Scanline.Size = new System.Drawing.Size(86, 14);
            this.CH2_Scanline.TabIndex = 20;
            this.CH2_Scanline.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CH2_Scanline.TextChanged += new System.EventHandler(this.CH2_Scanline_TextChanged);
            // 
            // CH2_label_CF
            // 
            this.CH2_label_CF.AutoSize = true;
            this.CH2_label_CF.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CH2_label_CF.ForeColor = System.Drawing.Color.DimGray;
            this.CH2_label_CF.Location = new System.Drawing.Point(5, 63);
            this.CH2_label_CF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CH2_label_CF.Name = "CH2_label_CF";
            this.CH2_label_CF.Size = new System.Drawing.Size(135, 13);
            this.CH2_label_CF.TabIndex = 19;
            this.CH2_label_CF.Text = "Center Frequency (MHz)";
            // 
            // CH2_label_Scanline
            // 
            this.CH2_label_Scanline.AutoSize = true;
            this.CH2_label_Scanline.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CH2_label_Scanline.ForeColor = System.Drawing.Color.DimGray;
            this.CH2_label_Scanline.Location = new System.Drawing.Point(5, 22);
            this.CH2_label_Scanline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CH2_label_Scanline.Name = "CH2_label_Scanline";
            this.CH2_label_Scanline.Size = new System.Drawing.Size(78, 13);
            this.CH2_label_Scanline.TabIndex = 18;
            this.CH2_label_Scanline.Text = "N of Scanline";
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
            this.CH1_Mode_Stimul.Size = new System.Drawing.Size(74, 16);
            this.CH1_Mode_Stimul.TabIndex = 1;
            this.CH1_Mode_Stimul.Text = "STIMUL";
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
            this.Param_ScanlineTestDataViewValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.textBox_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
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
            this.Param_ScanlineViewValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.Param_ScanlineCounterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.Param_BinaryNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.Param_BinaryNumber.Location = new System.Drawing.Point(142, 36);
            this.Param_BinaryNumber.Name = "Param_BinaryNumber";
            this.Param_BinaryNumber.ReadOnly = true;
            this.Param_BinaryNumber.Size = new System.Drawing.Size(242, 20);
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
            this.Param_HexNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Param_HexNumber.Location = new System.Drawing.Point(8, 36);
            this.Param_HexNumber.Name = "Param_HexNumber";
            this.Param_HexNumber.Size = new System.Drawing.Size(128, 21);
            this.Param_HexNumber.TabIndex = 4;
            this.Param_HexNumber.Text = "841500FF";
            this.Param_HexNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage_motorControl
            // 
            this.tabPage_motorControl.Controls.Add(this.groupBox_motorMovingInterface);
            this.tabPage_motorControl.Controls.Add(this.groupBox_motorPositionInfo);
            this.tabPage_motorControl.Controls.Add(this.groupBox_motorConnectionInfo);
            this.tabPage_motorControl.Location = new System.Drawing.Point(4, 34);
            this.tabPage_motorControl.Name = "tabPage_motorControl";
            this.tabPage_motorControl.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_motorControl.Size = new System.Drawing.Size(466, 680);
            this.tabPage_motorControl.TabIndex = 7;
            this.tabPage_motorControl.Text = "Motor";
            this.tabPage_motorControl.UseVisualStyleBackColor = true;
            // 
            // groupBox_motorMovingInterface
            // 
            this.groupBox_motorMovingInterface.Controls.Add(this.motor_PositionFlag);
            this.groupBox_motorMovingInterface.Controls.Add(this.label_position_flag);
            this.groupBox_motorMovingInterface.Controls.Add(this.motor_1Way);
            this.groupBox_motorMovingInterface.Controls.Add(this.panel2);
            this.groupBox_motorMovingInterface.Controls.Add(this.motor_RepeatControl);
            this.groupBox_motorMovingInterface.Controls.Add(this.motor_timer_box);
            this.groupBox_motorMovingInterface.Controls.Add(this.label_motor_timer);
            this.groupBox_motorMovingInterface.Enabled = false;
            this.groupBox_motorMovingInterface.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox_motorMovingInterface.Location = new System.Drawing.Point(6, 154);
            this.groupBox_motorMovingInterface.Name = "groupBox_motorMovingInterface";
            this.groupBox_motorMovingInterface.Size = new System.Drawing.Size(454, 68);
            this.groupBox_motorMovingInterface.TabIndex = 30;
            this.groupBox_motorMovingInterface.TabStop = false;
            this.groupBox_motorMovingInterface.Text = "Motor Moving Interface";
            // 
            // motor_PositionFlag
            // 
            this.motor_PositionFlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.motor_PositionFlag.Location = new System.Drawing.Point(213, 35);
            this.motor_PositionFlag.Name = "motor_PositionFlag";
            this.motor_PositionFlag.Size = new System.Drawing.Size(92, 21);
            this.motor_PositionFlag.TabIndex = 37;
            this.motor_PositionFlag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_position_flag
            // 
            this.label_position_flag.AutoSize = true;
            this.label_position_flag.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_position_flag.ForeColor = System.Drawing.Color.DimGray;
            this.label_position_flag.Location = new System.Drawing.Point(210, 20);
            this.label_position_flag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_position_flag.Name = "label_position_flag";
            this.label_position_flag.Size = new System.Drawing.Size(76, 13);
            this.label_position_flag.TabIndex = 36;
            this.label_position_flag.Text = "Position Flag";
            // 
            // motor_1Way
            // 
            this.motor_1Way.BackColor = System.Drawing.Color.Black;
            this.motor_1Way.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.motor_1Way.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.motor_1Way.ForeColor = System.Drawing.Color.Transparent;
            this.motor_1Way.Location = new System.Drawing.Point(318, 17);
            this.motor_1Way.Name = "motor_1Way";
            this.motor_1Way.Size = new System.Drawing.Size(130, 39);
            this.motor_1Way.TabIndex = 35;
            this.motor_1Way.Text = "1 Way";
            this.motor_1Way.UseVisualStyleBackColor = false;
            this.motor_1Way.Click += new System.EventHandler(this.motor_1Way_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(202, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 35);
            this.panel2.TabIndex = 34;
            // 
            // motor_RepeatControl
            // 
            this.motor_RepeatControl.BackColor = System.Drawing.Color.Black;
            this.motor_RepeatControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.motor_RepeatControl.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.motor_RepeatControl.ForeColor = System.Drawing.Color.Transparent;
            this.motor_RepeatControl.Location = new System.Drawing.Point(117, 18);
            this.motor_RepeatControl.Name = "motor_RepeatControl";
            this.motor_RepeatControl.Size = new System.Drawing.Size(74, 39);
            this.motor_RepeatControl.TabIndex = 33;
            this.motor_RepeatControl.Text = "Start";
            this.motor_RepeatControl.UseVisualStyleBackColor = false;
            this.motor_RepeatControl.Click += new System.EventHandler(this.motor_RepeatControl_Click);
            // 
            // motor_timer_box
            // 
            this.motor_timer_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.motor_timer_box.Location = new System.Drawing.Point(6, 35);
            this.motor_timer_box.Name = "motor_timer_box";
            this.motor_timer_box.ReadOnly = true;
            this.motor_timer_box.Size = new System.Drawing.Size(105, 21);
            this.motor_timer_box.TabIndex = 29;
            this.motor_timer_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.motor_timer_box.TextChanged += new System.EventHandler(this.motor_NofRepetitions_TextChanged);
            // 
            // label_motor_timer
            // 
            this.label_motor_timer.AutoSize = true;
            this.label_motor_timer.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_motor_timer.ForeColor = System.Drawing.Color.DimGray;
            this.label_motor_timer.Location = new System.Drawing.Point(5, 20);
            this.label_motor_timer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_motor_timer.Name = "label_motor_timer";
            this.label_motor_timer.Size = new System.Drawing.Size(73, 13);
            this.label_motor_timer.TabIndex = 19;
            this.label_motor_timer.Text = "Motor Timer";
            // 
            // groupBox_motorPositionInfo
            // 
            this.groupBox_motorPositionInfo.Controls.Add(this.panel1);
            this.groupBox_motorPositionInfo.Controls.Add(this.motor_PositionCheck);
            this.groupBox_motorPositionInfo.Controls.Add(this.motor_PositionReset);
            this.groupBox_motorPositionInfo.Controls.Add(this.motor_PositionSet);
            this.groupBox_motorPositionInfo.Controls.Add(this.motor_MovingPosition);
            this.groupBox_motorPositionInfo.Controls.Add(this.motor_PresentPosition);
            this.groupBox_motorPositionInfo.Controls.Add(this.label_moving_position);
            this.groupBox_motorPositionInfo.Controls.Add(this.label_present_position);
            this.groupBox_motorPositionInfo.Enabled = false;
            this.groupBox_motorPositionInfo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox_motorPositionInfo.Location = new System.Drawing.Point(6, 80);
            this.groupBox_motorPositionInfo.Name = "groupBox_motorPositionInfo";
            this.groupBox_motorPositionInfo.Size = new System.Drawing.Size(454, 68);
            this.groupBox_motorPositionInfo.TabIndex = 29;
            this.groupBox_motorPositionInfo.TabStop = false;
            this.groupBox_motorPositionInfo.Text = "Position Setting";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(202, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 35);
            this.panel1.TabIndex = 34;
            // 
            // motor_PositionCheck
            // 
            this.motor_PositionCheck.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.motor_PositionCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.motor_PositionCheck.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.motor_PositionCheck.ForeColor = System.Drawing.Color.Transparent;
            this.motor_PositionCheck.Location = new System.Drawing.Point(117, 18);
            this.motor_PositionCheck.Name = "motor_PositionCheck";
            this.motor_PositionCheck.Size = new System.Drawing.Size(74, 39);
            this.motor_PositionCheck.TabIndex = 33;
            this.motor_PositionCheck.Text = "CHECK";
            this.motor_PositionCheck.UseVisualStyleBackColor = false;
            this.motor_PositionCheck.Click += new System.EventHandler(this.motor_PositionCheck_Click);
            // 
            // motor_PositionReset
            // 
            this.motor_PositionReset.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.motor_PositionReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.motor_PositionReset.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.motor_PositionReset.ForeColor = System.Drawing.Color.Transparent;
            this.motor_PositionReset.Location = new System.Drawing.Point(318, 18);
            this.motor_PositionReset.Name = "motor_PositionReset";
            this.motor_PositionReset.Size = new System.Drawing.Size(60, 39);
            this.motor_PositionReset.TabIndex = 32;
            this.motor_PositionReset.Text = "RSET";
            this.motor_PositionReset.UseVisualStyleBackColor = false;
            this.motor_PositionReset.Click += new System.EventHandler(this.motor_PositionReset_Click);
            // 
            // motor_PositionSet
            // 
            this.motor_PositionSet.BackColor = System.Drawing.Color.Black;
            this.motor_PositionSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.motor_PositionSet.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.motor_PositionSet.ForeColor = System.Drawing.Color.Transparent;
            this.motor_PositionSet.Location = new System.Drawing.Point(388, 18);
            this.motor_PositionSet.Name = "motor_PositionSet";
            this.motor_PositionSet.Size = new System.Drawing.Size(60, 39);
            this.motor_PositionSet.TabIndex = 31;
            this.motor_PositionSet.Text = "MOVE";
            this.motor_PositionSet.UseVisualStyleBackColor = false;
            this.motor_PositionSet.Click += new System.EventHandler(this.motor_PositionSet_Click);
            // 
            // motor_MovingPosition
            // 
            this.motor_MovingPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.motor_MovingPosition.Location = new System.Drawing.Point(213, 35);
            this.motor_MovingPosition.Name = "motor_MovingPosition";
            this.motor_MovingPosition.Size = new System.Drawing.Size(92, 21);
            this.motor_MovingPosition.TabIndex = 30;
            this.motor_MovingPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.motor_MovingPosition.TextChanged += new System.EventHandler(this.motor_MovingPosition_TextChanged);
            // 
            // motor_PresentPosition
            // 
            this.motor_PresentPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.motor_PresentPosition.Location = new System.Drawing.Point(6, 35);
            this.motor_PresentPosition.Name = "motor_PresentPosition";
            this.motor_PresentPosition.ReadOnly = true;
            this.motor_PresentPosition.Size = new System.Drawing.Size(105, 21);
            this.motor_PresentPosition.TabIndex = 29;
            this.motor_PresentPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.motor_PresentPosition.TextChanged += new System.EventHandler(this.motor_PresentPosition_TextChanged);
            // 
            // label_moving_position
            // 
            this.label_moving_position.AutoSize = true;
            this.label_moving_position.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_moving_position.ForeColor = System.Drawing.Color.DimGray;
            this.label_moving_position.Location = new System.Drawing.Point(210, 20);
            this.label_moving_position.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_moving_position.Name = "label_moving_position";
            this.label_moving_position.Size = new System.Drawing.Size(95, 13);
            this.label_moving_position.TabIndex = 21;
            this.label_moving_position.Text = "Moving Position";
            // 
            // label_present_position
            // 
            this.label_present_position.AutoSize = true;
            this.label_present_position.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_present_position.ForeColor = System.Drawing.Color.DimGray;
            this.label_present_position.Location = new System.Drawing.Point(5, 20);
            this.label_present_position.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_present_position.Name = "label_present_position";
            this.label_present_position.Size = new System.Drawing.Size(93, 13);
            this.label_present_position.TabIndex = 19;
            this.label_present_position.Text = "Present Position";
            // 
            // groupBox_motorConnectionInfo
            // 
            this.groupBox_motorConnectionInfo.Controls.Add(this.motor_ConnectionControl);
            this.groupBox_motorConnectionInfo.Controls.Add(this.motor_ServoID);
            this.groupBox_motorConnectionInfo.Controls.Add(this.motor_Comport);
            this.groupBox_motorConnectionInfo.Controls.Add(this.label_servo_id);
            this.groupBox_motorConnectionInfo.Controls.Add(this.label_motor_comport);
            this.groupBox_motorConnectionInfo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox_motorConnectionInfo.Location = new System.Drawing.Point(6, 6);
            this.groupBox_motorConnectionInfo.Name = "groupBox_motorConnectionInfo";
            this.groupBox_motorConnectionInfo.Size = new System.Drawing.Size(454, 68);
            this.groupBox_motorConnectionInfo.TabIndex = 1;
            this.groupBox_motorConnectionInfo.TabStop = false;
            this.groupBox_motorConnectionInfo.Text = "Motor System Connection INFO";
            // 
            // motor_ConnectionControl
            // 
            this.motor_ConnectionControl.BackColor = System.Drawing.Color.Black;
            this.motor_ConnectionControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.motor_ConnectionControl.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.motor_ConnectionControl.ForeColor = System.Drawing.Color.Transparent;
            this.motor_ConnectionControl.Location = new System.Drawing.Point(318, 18);
            this.motor_ConnectionControl.Name = "motor_ConnectionControl";
            this.motor_ConnectionControl.Size = new System.Drawing.Size(130, 39);
            this.motor_ConnectionControl.TabIndex = 28;
            this.motor_ConnectionControl.Text = "Connect";
            this.motor_ConnectionControl.UseVisualStyleBackColor = false;
            this.motor_ConnectionControl.Click += new System.EventHandler(this.motor_ConnectionControl_Click);
            // 
            // motor_ServoID
            // 
            this.motor_ServoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.motor_ServoID.Location = new System.Drawing.Point(143, 36);
            this.motor_ServoID.Name = "motor_ServoID";
            this.motor_ServoID.ReadOnly = true;
            this.motor_ServoID.Size = new System.Drawing.Size(128, 21);
            this.motor_ServoID.TabIndex = 27;
            this.motor_ServoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.motor_ServoID.TextChanged += new System.EventHandler(this.motor_ServoID_TextChanged);
            // 
            // motor_Comport
            // 
            this.motor_Comport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.motor_Comport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.motor_Comport.FormattingEnabled = true;
            this.motor_Comport.Location = new System.Drawing.Point(8, 36);
            this.motor_Comport.Name = "motor_Comport";
            this.motor_Comport.Size = new System.Drawing.Size(118, 21);
            this.motor_Comport.TabIndex = 26;
            this.motor_Comport.SelectedValueChanged += new System.EventHandler(this.motor_Comport_SelectedValueChanged);
            // 
            // label_servo_id
            // 
            this.label_servo_id.AutoSize = true;
            this.label_servo_id.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_servo_id.ForeColor = System.Drawing.Color.DimGray;
            this.label_servo_id.Location = new System.Drawing.Point(140, 20);
            this.label_servo_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_servo_id.Name = "label_servo_id";
            this.label_servo_id.Size = new System.Drawing.Size(51, 13);
            this.label_servo_id.TabIndex = 21;
            this.label_servo_id.Text = "Servo ID";
            // 
            // label_motor_comport
            // 
            this.label_motor_comport.AutoSize = true;
            this.label_motor_comport.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_motor_comport.ForeColor = System.Drawing.Color.DimGray;
            this.label_motor_comport.Location = new System.Drawing.Point(5, 20);
            this.label_motor_comport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_motor_comport.Name = "label_motor_comport";
            this.label_motor_comport.Size = new System.Drawing.Size(94, 13);
            this.label_motor_comport.TabIndex = 19;
            this.label_motor_comport.Text = "Motor Comport ";
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
            this.groupBox_Roatation_Motor_Control.ResumeLayout(false);
            this.groupBox_LinearMotorControl.ResumeLayout(false);
            this.groupBox_LinearMotorControl.PerformLayout();
            this.groupBox_CH2.ResumeLayout(false);
            this.groupBox_CH2_HV.ResumeLayout(false);
            this.groupBox_CH2_HV.PerformLayout();
            this.groupBox_CH2_ModeSelect.ResumeLayout(false);
            this.groupBox_CH2_ModeSelect.PerformLayout();
            this.groupBox_CH2_AFE.ResumeLayout(false);
            this.groupBox_CH2_AFE.PerformLayout();
            this.groupBox_CH2_TxParameter.ResumeLayout(false);
            this.groupBox_CH2_TxParameter.PerformLayout();
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
            this.tabPage_motorControl.ResumeLayout(false);
            this.groupBox_motorMovingInterface.ResumeLayout(false);
            this.groupBox_motorMovingInterface.PerformLayout();
            this.groupBox_motorPositionInfo.ResumeLayout(false);
            this.groupBox_motorPositionInfo.PerformLayout();
            this.groupBox_motorConnectionInfo.ResumeLayout(false);
            this.groupBox_motorConnectionInfo.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage_motorControl;
        private System.Windows.Forms.GroupBox groupBox_motorConnectionInfo;
        private System.Windows.Forms.Label label_servo_id;
        private System.Windows.Forms.Label label_motor_comport;
        private System.Windows.Forms.ComboBox motor_Comport;
        private System.Windows.Forms.Button motor_ConnectionControl;
        private System.Windows.Forms.TextBox motor_ServoID;
        private System.Windows.Forms.GroupBox groupBox_motorPositionInfo;
        private System.Windows.Forms.Label label_moving_position;
        private System.Windows.Forms.Label label_present_position;
        private System.Windows.Forms.TextBox motor_MovingPosition;
        private System.Windows.Forms.TextBox motor_PresentPosition;
        private System.Windows.Forms.Button motor_PositionReset;
        private System.Windows.Forms.Button motor_PositionSet;
        private System.Windows.Forms.Button motor_PositionCheck;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox_CH2;
        private System.Windows.Forms.Button CH2_Reset;
        private System.Windows.Forms.Button CH2_ScanControl;
        private System.Windows.Forms.Button CH2_PulseControl;
        private System.Windows.Forms.GroupBox groupBox_CH2_HV;
        private System.Windows.Forms.Button CH2_VolatageControl;
        private System.Windows.Forms.Label CH2_label_VoltageLevel;
        private System.Windows.Forms.TextBox CH2_HVLevel;
        private System.Windows.Forms.RadioButton CH2_HV_External;
        private System.Windows.Forms.RadioButton CH2_HV_Internal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox_CH2_ModeSelect;
        private System.Windows.Forms.RadioButton CH2_Mode_Stimul;
        private System.Windows.Forms.RadioButton CH2_Mode_Imaging;
        private System.Windows.Forms.GroupBox groupBox_CH2_AFE;
        private System.Windows.Forms.Label CH2_label_ADCGain;
        private System.Windows.Forms.Label CH2_label_PGAGain;
        private System.Windows.Forms.Label CH2_label_LPF;
        private System.Windows.Forms.ComboBox CH2_ADCGain;
        private System.Windows.Forms.ComboBox CH2_PGAGain;
        private System.Windows.Forms.ComboBox CH2_LPF;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox_CH2_TxParameter;
        private System.Windows.Forms.TextBox CH2_DynamicRange;
        private System.Windows.Forms.Label CH2_label_DynamicRange;
        private System.Windows.Forms.TextBox CH2_PulseDuration;
        private System.Windows.Forms.Label CH2_label_PulseDuration;
        private System.Windows.Forms.TextBox CH2_PRF;
        private System.Windows.Forms.Label CH2_label_PRF;
        private System.Windows.Forms.Label CH2_label_ViewDepth;
        private System.Windows.Forms.ComboBox CH2_ViewDepth;
        private System.Windows.Forms.ComboBox CH2_PulseCycles;
        private System.Windows.Forms.Label CH2_label_PulseCycles;
        private System.Windows.Forms.ComboBox CH2_CF;
        private System.Windows.Forms.TextBox CH2_Scanline;
        private System.Windows.Forms.Label CH2_label_CF;
        private System.Windows.Forms.Label CH2_label_Scanline;
        private System.Windows.Forms.GroupBox groupBox_LinearMotorControl;
        private System.Windows.Forms.GroupBox groupBox_Roatation_Motor_Control;
        private System.Windows.Forms.Button RotationMotorControl_Imaging;
        private System.Windows.Forms.Button RotationMotorControl_HIFU;
        private System.Windows.Forms.Button linear_positionMove;
        private System.Windows.Forms.CheckBox linear_loopMode;
        private System.Windows.Forms.GroupBox groupBox_motorMovingInterface;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button motor_RepeatControl;
        private System.Windows.Forms.TextBox motor_timer_box;
        private System.Windows.Forms.Label label_motor_timer;
        private System.Windows.Forms.Button motor_1Way;
        private System.Windows.Forms.TextBox motor_PositionFlag;
        private System.Windows.Forms.Label label_position_flag;
    }
}

