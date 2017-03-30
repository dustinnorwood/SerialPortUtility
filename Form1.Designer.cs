namespace CodeJetSerialPortUtility
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Tx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Send = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Rx = new System.Windows.Forms.TextBox();
            this.button_SendClear = new System.Windows.Forms.Button();
            this.button_ReceiveClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Open = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.radioButton_Stop15 = new System.Windows.Forms.RadioButton();
            this.radioButton_Stop2 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton_Stop0 = new System.Windows.Forms.RadioButton();
            this.radioButton_Stop1 = new System.Windows.Forms.RadioButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton_DataBits8 = new System.Windows.Forms.RadioButton();
            this.radioButton_DataBits7 = new System.Windows.Forms.RadioButton();
            this.radioButton_DataBits6 = new System.Windows.Forms.RadioButton();
            this.radioButton_DataBits5 = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.radioButton_ParityOdd = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton_ParityNone = new System.Windows.Forms.RadioButton();
            this.radioButton_ParityEven = new System.Windows.Forms.RadioButton();
            this.radioButton_ParityMark = new System.Windows.Forms.RadioButton();
            this.radioButton_ParitySpace = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton_HSNone = new System.Windows.Forms.RadioButton();
            this.radioButton_HSRTS = new System.Windows.Forms.RadioButton();
            this.radioButton_HSXon = new System.Windows.Forms.RadioButton();
            this.radioButton_HSRTSXon = new System.Windows.Forms.RadioButton();
            this.comboBox_PortName = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button_Change = new System.Windows.Forms.Button();
            this.comboBox_BaudRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox_StatusError = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox_StatusBreak = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox_StatusRing = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox_StatusDsr = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox_StatusDcd = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox_StatusCts = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox_StatusTxd = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox_StatusRxd = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox_StatusConnected = new System.Windows.Forms.PictureBox();
            this.button_SendLine = new System.Windows.Forms.Button();
            this.radioButton_CRLF = new System.Windows.Forms.RadioButton();
            this.radioButton_LF = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_SetNewLine = new System.Windows.Forms.Button();
            this.checkBox_Checksum = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Tx
            // 
            this.textBox_Tx.Location = new System.Drawing.Point(3, 27);
            this.textBox_Tx.Name = "textBox_Tx";
            this.textBox_Tx.Size = new System.Drawing.Size(568, 23);
            this.textBox_Tx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "Transmit";
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(577, 27);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(108, 32);
            this.button_Send.TabIndex = 2;
            this.button_Send.Text = "Send";
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "Receive";
            // 
            // textBox_Rx
            // 
            this.textBox_Rx.BackColor = System.Drawing.Color.White;
            this.textBox_Rx.Location = new System.Drawing.Point(3, 79);
            this.textBox_Rx.Multiline = true;
            this.textBox_Rx.Name = "textBox_Rx";
            this.textBox_Rx.ReadOnly = true;
            this.textBox_Rx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Rx.Size = new System.Drawing.Size(568, 161);
            this.textBox_Rx.TabIndex = 4;
            // 
            // button_SendClear
            // 
            this.button_SendClear.Location = new System.Drawing.Point(109, 4);
            this.button_SendClear.Name = "button_SendClear";
            this.button_SendClear.Size = new System.Drawing.Size(108, 20);
            this.button_SendClear.TabIndex = 6;
            this.button_SendClear.Text = "Clear";
            this.button_SendClear.Click += new System.EventHandler(this.button_SendClear_Click);
            // 
            // button_ReceiveClear
            // 
            this.button_ReceiveClear.Location = new System.Drawing.Point(109, 56);
            this.button_ReceiveClear.Name = "button_ReceiveClear";
            this.button_ReceiveClear.Size = new System.Drawing.Size(108, 20);
            this.button_ReceiveClear.TabIndex = 7;
            this.button_ReceiveClear.Text = "Clear";
            this.button_ReceiveClear.Click += new System.EventHandler(this.button_ReceiveClear_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Open);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.comboBox_PortName);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.button_Change);
            this.panel1.Controls.Add(this.comboBox_BaudRate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(4, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 163);
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(454, 5);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(108, 73);
            this.button_Open.TabIndex = 32;
            this.button_Open.Text = "Open";
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.radioButton_Stop15);
            this.panel7.Controls.Add(this.radioButton_Stop2);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.radioButton_Stop0);
            this.panel7.Controls.Add(this.radioButton_Stop1);
            this.panel7.Location = new System.Drawing.Point(378, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(70, 157);
            // 
            // radioButton_Stop15
            // 
            this.radioButton_Stop15.Location = new System.Drawing.Point(3, 79);
            this.radioButton_Stop15.Name = "radioButton_Stop15";
            this.radioButton_Stop15.Size = new System.Drawing.Size(63, 20);
            this.radioButton_Stop15.TabIndex = 25;
            this.radioButton_Stop15.TabStop = false;
            this.radioButton_Stop15.Text = "1.5 bits";
            // 
            // radioButton_Stop2
            // 
            this.radioButton_Stop2.Location = new System.Drawing.Point(3, 105);
            this.radioButton_Stop2.Name = "radioButton_Stop2";
            this.radioButton_Stop2.Size = new System.Drawing.Size(63, 20);
            this.radioButton_Stop2.TabIndex = 26;
            this.radioButton_Stop2.TabStop = false;
            this.radioButton_Stop2.Text = "2 bits";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.Text = "Stop Bits:";
            // 
            // radioButton_Stop0
            // 
            this.radioButton_Stop0.Location = new System.Drawing.Point(3, 28);
            this.radioButton_Stop0.Name = "radioButton_Stop0";
            this.radioButton_Stop0.Size = new System.Drawing.Size(63, 20);
            this.radioButton_Stop0.TabIndex = 23;
            this.radioButton_Stop0.TabStop = false;
            this.radioButton_Stop0.Text = "None";
            // 
            // radioButton_Stop1
            // 
            this.radioButton_Stop1.Checked = true;
            this.radioButton_Stop1.Location = new System.Drawing.Point(3, 54);
            this.radioButton_Stop1.Name = "radioButton_Stop1";
            this.radioButton_Stop1.Size = new System.Drawing.Size(63, 20);
            this.radioButton_Stop1.TabIndex = 24;
            this.radioButton_Stop1.Text = "1 bit";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.radioButton_DataBits8);
            this.panel6.Controls.Add(this.radioButton_DataBits7);
            this.panel6.Controls.Add(this.radioButton_DataBits6);
            this.panel6.Controls.Add(this.radioButton_DataBits5);
            this.panel6.Location = new System.Drawing.Point(302, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(69, 157);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(3, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.Text = "Data Bits:";
            // 
            // radioButton_DataBits8
            // 
            this.radioButton_DataBits8.Checked = true;
            this.radioButton_DataBits8.Location = new System.Drawing.Point(3, 28);
            this.radioButton_DataBits8.Name = "radioButton_DataBits8";
            this.radioButton_DataBits8.Size = new System.Drawing.Size(64, 20);
            this.radioButton_DataBits8.TabIndex = 14;
            this.radioButton_DataBits8.Text = "8 bits";
            // 
            // radioButton_DataBits7
            // 
            this.radioButton_DataBits7.Location = new System.Drawing.Point(3, 54);
            this.radioButton_DataBits7.Name = "radioButton_DataBits7";
            this.radioButton_DataBits7.Size = new System.Drawing.Size(64, 20);
            this.radioButton_DataBits7.TabIndex = 15;
            this.radioButton_DataBits7.TabStop = false;
            this.radioButton_DataBits7.Text = "7 bits";
            // 
            // radioButton_DataBits6
            // 
            this.radioButton_DataBits6.Location = new System.Drawing.Point(3, 80);
            this.radioButton_DataBits6.Name = "radioButton_DataBits6";
            this.radioButton_DataBits6.Size = new System.Drawing.Size(64, 20);
            this.radioButton_DataBits6.TabIndex = 16;
            this.radioButton_DataBits6.TabStop = false;
            this.radioButton_DataBits6.Text = "6 bits";
            // 
            // radioButton_DataBits5
            // 
            this.radioButton_DataBits5.Location = new System.Drawing.Point(3, 106);
            this.radioButton_DataBits5.Name = "radioButton_DataBits5";
            this.radioButton_DataBits5.Size = new System.Drawing.Size(64, 20);
            this.radioButton_DataBits5.TabIndex = 17;
            this.radioButton_DataBits5.TabStop = false;
            this.radioButton_DataBits5.Text = "5 bits";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.radioButton_ParityOdd);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.radioButton_ParityNone);
            this.panel5.Controls.Add(this.radioButton_ParityEven);
            this.panel5.Controls.Add(this.radioButton_ParityMark);
            this.panel5.Controls.Add(this.radioButton_ParitySpace);
            this.panel5.Location = new System.Drawing.Point(216, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(80, 157);
            // 
            // radioButton_ParityOdd
            // 
            this.radioButton_ParityOdd.Location = new System.Drawing.Point(3, 55);
            this.radioButton_ParityOdd.Name = "radioButton_ParityOdd";
            this.radioButton_ParityOdd.Size = new System.Drawing.Size(74, 20);
            this.radioButton_ParityOdd.TabIndex = 19;
            this.radioButton_ParityOdd.TabStop = false;
            this.radioButton_ParityOdd.Text = "Odd";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.Text = "Parity:";
            // 
            // radioButton_ParityNone
            // 
            this.radioButton_ParityNone.Checked = true;
            this.radioButton_ParityNone.Location = new System.Drawing.Point(3, 29);
            this.radioButton_ParityNone.Name = "radioButton_ParityNone";
            this.radioButton_ParityNone.Size = new System.Drawing.Size(74, 20);
            this.radioButton_ParityNone.TabIndex = 18;
            this.radioButton_ParityNone.Text = "None";
            // 
            // radioButton_ParityEven
            // 
            this.radioButton_ParityEven.Location = new System.Drawing.Point(3, 81);
            this.radioButton_ParityEven.Name = "radioButton_ParityEven";
            this.radioButton_ParityEven.Size = new System.Drawing.Size(74, 20);
            this.radioButton_ParityEven.TabIndex = 20;
            this.radioButton_ParityEven.TabStop = false;
            this.radioButton_ParityEven.Text = "Even";
            // 
            // radioButton_ParityMark
            // 
            this.radioButton_ParityMark.Location = new System.Drawing.Point(3, 107);
            this.radioButton_ParityMark.Name = "radioButton_ParityMark";
            this.radioButton_ParityMark.Size = new System.Drawing.Size(74, 20);
            this.radioButton_ParityMark.TabIndex = 21;
            this.radioButton_ParityMark.TabStop = false;
            this.radioButton_ParityMark.Text = "Mark";
            // 
            // radioButton_ParitySpace
            // 
            this.radioButton_ParitySpace.Location = new System.Drawing.Point(3, 133);
            this.radioButton_ParitySpace.Name = "radioButton_ParitySpace";
            this.radioButton_ParitySpace.Size = new System.Drawing.Size(74, 20);
            this.radioButton_ParitySpace.TabIndex = 22;
            this.radioButton_ParitySpace.TabStop = false;
            this.radioButton_ParitySpace.Text = "Space";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.radioButton_HSNone);
            this.panel4.Controls.Add(this.radioButton_HSRTS);
            this.panel4.Controls.Add(this.radioButton_HSXon);
            this.panel4.Controls.Add(this.radioButton_HSRTSXon);
            this.panel4.Location = new System.Drawing.Point(120, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(90, 157);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.Text = "Handshaking:";
            // 
            // radioButton_HSNone
            // 
            this.radioButton_HSNone.Location = new System.Drawing.Point(3, 28);
            this.radioButton_HSNone.Name = "radioButton_HSNone";
            this.radioButton_HSNone.Size = new System.Drawing.Size(84, 20);
            this.radioButton_HSNone.TabIndex = 8;
            this.radioButton_HSNone.TabStop = false;
            this.radioButton_HSNone.Text = "None";
            // 
            // radioButton_HSRTS
            // 
            this.radioButton_HSRTS.Checked = true;
            this.radioButton_HSRTS.Location = new System.Drawing.Point(3, 54);
            this.radioButton_HSRTS.Name = "radioButton_HSRTS";
            this.radioButton_HSRTS.Size = new System.Drawing.Size(84, 20);
            this.radioButton_HSRTS.TabIndex = 9;
            this.radioButton_HSRTS.Text = "RTS/CTS";
            // 
            // radioButton_HSXon
            // 
            this.radioButton_HSXon.Location = new System.Drawing.Point(3, 80);
            this.radioButton_HSXon.Name = "radioButton_HSXon";
            this.radioButton_HSXon.Size = new System.Drawing.Size(84, 20);
            this.radioButton_HSXon.TabIndex = 10;
            this.radioButton_HSXon.TabStop = false;
            this.radioButton_HSXon.Text = "Xon/Xoff";
            // 
            // radioButton_HSRTSXon
            // 
            this.radioButton_HSRTSXon.Location = new System.Drawing.Point(3, 106);
            this.radioButton_HSRTSXon.Name = "radioButton_HSRTSXon";
            this.radioButton_HSRTSXon.Size = new System.Drawing.Size(84, 20);
            this.radioButton_HSRTSXon.TabIndex = 11;
            this.radioButton_HSRTSXon.TabStop = false;
            this.radioButton_HSRTSXon.Text = "RTS/Xon";
            // 
            // comboBox_PortName
            // 
            this.comboBox_PortName.Location = new System.Drawing.Point(13, 33);
            this.comboBox_PortName.Name = "comboBox_PortName";
            this.comboBox_PortName.Size = new System.Drawing.Size(101, 23);
            this.comboBox_PortName.TabIndex = 26;
            this.comboBox_PortName.GotFocus += new System.EventHandler(this.comboBox_PortName_GotFocus);
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(13, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 20);
            this.label17.Text = "Port Name:";
            // 
            // button_Change
            // 
            this.button_Change.Location = new System.Drawing.Point(454, 84);
            this.button_Change.Name = "button_Change";
            this.button_Change.Size = new System.Drawing.Size(108, 73);
            this.button_Change.TabIndex = 9;
            this.button_Change.Text = "Change";
            this.button_Change.Click += new System.EventHandler(this.button_Change_Click);
            // 
            // comboBox_BaudRate
            // 
            this.comboBox_BaudRate.Items.Add("230400");
            this.comboBox_BaudRate.Items.Add("115200");
            this.comboBox_BaudRate.Items.Add("57600");
            this.comboBox_BaudRate.Items.Add("38400");
            this.comboBox_BaudRate.Items.Add("9600");
            this.comboBox_BaudRate.Items.Add("4800");
            this.comboBox_BaudRate.Items.Add("2400");
            this.comboBox_BaudRate.Items.Add("1200");
            this.comboBox_BaudRate.Items.Add("300");
            this.comboBox_BaudRate.Location = new System.Drawing.Point(13, 109);
            this.comboBox_BaudRate.Name = "comboBox_BaudRate";
            this.comboBox_BaudRate.Size = new System.Drawing.Size(101, 23);
            this.comboBox_BaudRate.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.Text = "Baud Rate:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.pictureBox_StatusError);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.pictureBox_StatusBreak);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.pictureBox_StatusRing);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.pictureBox_StatusDsr);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.pictureBox_StatusDcd);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.pictureBox_StatusCts);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.pictureBox_StatusTxd);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.pictureBox_StatusRxd);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.pictureBox_StatusConnected);
            this.panel2.Location = new System.Drawing.Point(577, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(108, 184);
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(32, 164);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 15);
            this.label14.Text = "Error";
            // 
            // pictureBox_StatusError
            // 
            this.pictureBox_StatusError.Location = new System.Drawing.Point(15, 164);
            this.pictureBox_StatusError.Name = "pictureBox_StatusError";
            this.pictureBox_StatusError.Size = new System.Drawing.Size(14, 14);
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(32, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 15);
            this.label15.Text = "BREAK";
            // 
            // pictureBox_StatusBreak
            // 
            this.pictureBox_StatusBreak.Location = new System.Drawing.Point(15, 144);
            this.pictureBox_StatusBreak.Name = "pictureBox_StatusBreak";
            this.pictureBox_StatusBreak.Size = new System.Drawing.Size(14, 14);
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(32, 124);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 15);
            this.label16.Text = "Ring (9)";
            // 
            // pictureBox_StatusRing
            // 
            this.pictureBox_StatusRing.Location = new System.Drawing.Point(15, 124);
            this.pictureBox_StatusRing.Name = "pictureBox_StatusRing";
            this.pictureBox_StatusRing.Size = new System.Drawing.Size(14, 14);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(32, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 15);
            this.label11.Text = "DSR (6)";
            // 
            // pictureBox_StatusDsr
            // 
            this.pictureBox_StatusDsr.Location = new System.Drawing.Point(15, 104);
            this.pictureBox_StatusDsr.Name = "pictureBox_StatusDsr";
            this.pictureBox_StatusDsr.Size = new System.Drawing.Size(14, 14);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(32, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 15);
            this.label12.Text = "DCD (1)";
            // 
            // pictureBox_StatusDcd
            // 
            this.pictureBox_StatusDcd.Location = new System.Drawing.Point(15, 84);
            this.pictureBox_StatusDcd.Name = "pictureBox_StatusDcd";
            this.pictureBox_StatusDcd.Size = new System.Drawing.Size(14, 14);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(32, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 15);
            this.label13.Text = "CTS (8)";
            // 
            // pictureBox_StatusCts
            // 
            this.pictureBox_StatusCts.Location = new System.Drawing.Point(15, 64);
            this.pictureBox_StatusCts.Name = "pictureBox_StatusCts";
            this.pictureBox_StatusCts.Size = new System.Drawing.Size(14, 14);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(32, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 15);
            this.label10.Text = "TXD (3)";
            // 
            // pictureBox_StatusTxd
            // 
            this.pictureBox_StatusTxd.Location = new System.Drawing.Point(15, 44);
            this.pictureBox_StatusTxd.Name = "pictureBox_StatusTxd";
            this.pictureBox_StatusTxd.Size = new System.Drawing.Size(14, 14);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(32, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 15);
            this.label9.Text = "RXD (2)";
            // 
            // pictureBox_StatusRxd
            // 
            this.pictureBox_StatusRxd.Location = new System.Drawing.Point(15, 24);
            this.pictureBox_StatusRxd.Name = "pictureBox_StatusRxd";
            this.pictureBox_StatusRxd.Size = new System.Drawing.Size(14, 14);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(32, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 15);
            this.label8.Text = "Connected";
            // 
            // pictureBox_StatusConnected
            // 
            this.pictureBox_StatusConnected.BackColor = System.Drawing.Color.Silver;
            this.pictureBox_StatusConnected.Location = new System.Drawing.Point(15, 4);
            this.pictureBox_StatusConnected.Name = "pictureBox_StatusConnected";
            this.pictureBox_StatusConnected.Size = new System.Drawing.Size(14, 14);
            // 
            // button_SendLine
            // 
            this.button_SendLine.Location = new System.Drawing.Point(577, 65);
            this.button_SendLine.Name = "button_SendLine";
            this.button_SendLine.Size = new System.Drawing.Size(108, 32);
            this.button_SendLine.TabIndex = 10;
            this.button_SendLine.Text = "Send Line";
            this.button_SendLine.Click += new System.EventHandler(this.button_SendLine_Click);
            // 
            // radioButton_CRLF
            // 
            this.radioButton_CRLF.Location = new System.Drawing.Point(3, 58);
            this.radioButton_CRLF.Name = "radioButton_CRLF";
            this.radioButton_CRLF.Size = new System.Drawing.Size(100, 20);
            this.radioButton_CRLF.TabIndex = 30;
            this.radioButton_CRLF.TabStop = false;
            this.radioButton_CRLF.Text = "\\r\\n";
            // 
            // radioButton_LF
            // 
            this.radioButton_LF.Checked = true;
            this.radioButton_LF.Location = new System.Drawing.Point(3, 32);
            this.radioButton_LF.Name = "radioButton_LF";
            this.radioButton_LF.Size = new System.Drawing.Size(100, 20);
            this.radioButton_LF.TabIndex = 29;
            this.radioButton_LF.Text = "\\n";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(3, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 20);
            this.label18.Text = "New Line:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button_SetNewLine);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.radioButton_CRLF);
            this.panel3.Controls.Add(this.radioButton_LF);
            this.panel3.Location = new System.Drawing.Point(577, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(108, 116);
            // 
            // button_SetNewLine
            // 
            this.button_SetNewLine.Location = new System.Drawing.Point(3, 81);
            this.button_SetNewLine.Name = "button_SetNewLine";
            this.button_SetNewLine.Size = new System.Drawing.Size(100, 32);
            this.button_SetNewLine.TabIndex = 28;
            this.button_SetNewLine.Text = "Set";
            this.button_SetNewLine.Click += new System.EventHandler(this.button_SetNewLine_Click);
            // 
            // checkBox_Checksum
            // 
            this.checkBox_Checksum.Checked = true;
            this.checkBox_Checksum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Checksum.Location = new System.Drawing.Point(220, 4);
            this.checkBox_Checksum.Name = "checkBox_Checksum";
            this.checkBox_Checksum.Size = new System.Drawing.Size(124, 20);
            this.checkBox_Checksum.TabIndex = 21;
            this.checkBox_Checksum.Text = "Use Checksum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(691, 411);
            this.Controls.Add(this.checkBox_Checksum);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button_SendLine);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_ReceiveClear);
            this.Controls.Add(this.button_SendClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Rx);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Tx);
            this.Name = "Form1";
            this.Text = "Serial Port Utility";
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Tx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Rx;
        private System.Windows.Forms.Button button_SendClear;
        private System.Windows.Forms.Button button_ReceiveClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_BaudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton_DataBits5;
        private System.Windows.Forms.RadioButton radioButton_DataBits6;
        private System.Windows.Forms.RadioButton radioButton_DataBits7;
        private System.Windows.Forms.RadioButton radioButton_DataBits8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton_HSRTSXon;
        private System.Windows.Forms.RadioButton radioButton_HSXon;
        private System.Windows.Forms.RadioButton radioButton_HSRTS;
        private System.Windows.Forms.RadioButton radioButton_HSNone;
        private System.Windows.Forms.RadioButton radioButton_Stop1;
        private System.Windows.Forms.RadioButton radioButton_Stop0;
        private System.Windows.Forms.RadioButton radioButton_ParitySpace;
        private System.Windows.Forms.RadioButton radioButton_ParityMark;
        private System.Windows.Forms.RadioButton radioButton_ParityEven;
        private System.Windows.Forms.RadioButton radioButton_ParityOdd;
        private System.Windows.Forms.RadioButton radioButton_ParityNone;
        private System.Windows.Forms.Button button_Change;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox_StatusRxd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox_StatusConnected;
        private System.Windows.Forms.ComboBox comboBox_PortName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox_StatusError;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox_StatusBreak;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox_StatusRing;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox_StatusDsr;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox_StatusDcd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox_StatusCts;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox_StatusTxd;
        private System.Windows.Forms.Button button_SendLine;
        private System.Windows.Forms.RadioButton radioButton_CRLF;
        private System.Windows.Forms.RadioButton radioButton_LF;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_SetNewLine;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.RadioButton radioButton_Stop15;
        private System.Windows.Forms.RadioButton radioButton_Stop2;
        private System.Windows.Forms.CheckBox checkBox_Checksum;
    }
}

