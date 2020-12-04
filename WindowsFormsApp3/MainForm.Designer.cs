namespace LEDStabilization
{
    partial class MainForm
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
            this.connectToELLStageButton = new System.Windows.Forms.Button();
            this.disconnectELLStageButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comPortComboBox1 = new System.Windows.Forms.ComboBox();
            this.comPortButton1 = new System.Windows.Forms.Button();
            this.gpibAddressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connectToDMMButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lockButton = new System.Windows.Forms.Button();
            this.lockRatioTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.feedbackIntervalTextBox = new System.Windows.Forms.TextBox();
            this.toleranceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.angleTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.polarizerButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.saveDataLabel = new System.Windows.Forms.Label();
            this.openFileButton = new System.Windows.Forms.Button();
            this.connectKrochmannButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comPortComboBox2 = new System.Windows.Forms.ComboBox();
            this.comPortButton2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.totalRotationTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numberOfRepeatsTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.theta0TextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dthetaTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectToELLStageButton
            // 
            this.connectToELLStageButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectToELLStageButton.Location = new System.Drawing.Point(55, 60);
            this.connectToELLStageButton.Margin = new System.Windows.Forms.Padding(4);
            this.connectToELLStageButton.Name = "connectToELLStageButton";
            this.connectToELLStageButton.Size = new System.Drawing.Size(261, 38);
            this.connectToELLStageButton.TabIndex = 0;
            this.connectToELLStageButton.Text = "connect to ELL stage";
            this.connectToELLStageButton.UseVisualStyleBackColor = true;
            this.connectToELLStageButton.Click += new System.EventHandler(this.connectToELLStageButton_Click);
            // 
            // disconnectELLStageButton
            // 
            this.disconnectELLStageButton.AutoSize = true;
            this.disconnectELLStageButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnectELLStageButton.Location = new System.Drawing.Point(427, 608);
            this.disconnectELLStageButton.Margin = new System.Windows.Forms.Padding(4);
            this.disconnectELLStageButton.Name = "disconnectELLStageButton";
            this.disconnectELLStageButton.Size = new System.Drawing.Size(119, 33);
            this.disconnectELLStageButton.TabIndex = 1;
            this.disconnectELLStageButton.Text = "disconnect";
            this.disconnectELLStageButton.UseVisualStyleBackColor = true;
            this.disconnectELLStageButton.Click += new System.EventHandler(this.disconnectELLStageButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(920, 21);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(440, 198);
            this.textBox1.TabIndex = 2;
            // 
            // comPortComboBox1
            // 
            this.comPortComboBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comPortComboBox1.FormattingEnabled = true;
            this.comPortComboBox1.Location = new System.Drawing.Point(4, 20);
            this.comPortComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comPortComboBox1.Name = "comPortComboBox1";
            this.comPortComboBox1.Size = new System.Drawing.Size(160, 29);
            this.comPortComboBox1.TabIndex = 3;
            // 
            // comPortButton1
            // 
            this.comPortButton1.AutoSize = true;
            this.comPortButton1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comPortButton1.Location = new System.Drawing.Point(173, 17);
            this.comPortButton1.Margin = new System.Windows.Forms.Padding(4);
            this.comPortButton1.Name = "comPortButton1";
            this.comPortButton1.Size = new System.Drawing.Size(229, 38);
            this.comPortButton1.TabIndex = 0;
            this.comPortButton1.Text = "refresh COM ports";
            this.comPortButton1.UseVisualStyleBackColor = true;
            this.comPortButton1.Click += new System.EventHandler(this.comPortButton1_Click);
            // 
            // gpibAddressTextBox
            // 
            this.gpibAddressTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpibAddressTextBox.Location = new System.Drawing.Point(8, 6);
            this.gpibAddressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.gpibAddressTextBox.Name = "gpibAddressTextBox";
            this.gpibAddressTextBox.Size = new System.Drawing.Size(132, 27);
            this.gpibAddressTextBox.TabIndex = 4;
            this.gpibAddressTextBox.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "GPIB Address";
            // 
            // connectToDMMButton
            // 
            this.connectToDMMButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectToDMMButton.Location = new System.Drawing.Point(47, 42);
            this.connectToDMMButton.Margin = new System.Windows.Forms.Padding(4);
            this.connectToDMMButton.Name = "connectToDMMButton";
            this.connectToDMMButton.Size = new System.Drawing.Size(176, 28);
            this.connectToDMMButton.TabIndex = 6;
            this.connectToDMMButton.Text = "connect to DMM";
            this.connectToDMMButton.UseVisualStyleBackColor = true;
            this.connectToDMMButton.Click += new System.EventHandler(this.connectToDMMButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(8, 162);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 27);
            this.textBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Krochmann output";
            // 
            // lockButton
            // 
            this.lockButton.AutoSize = true;
            this.lockButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lockButton.Location = new System.Drawing.Point(748, 305);
            this.lockButton.Margin = new System.Windows.Forms.Padding(4);
            this.lockButton.Name = "lockButton";
            this.lockButton.Size = new System.Drawing.Size(164, 33);
            this.lockButton.TabIndex = 9;
            this.lockButton.Text = "Start the locking";
            this.lockButton.UseVisualStyleBackColor = true;
            this.lockButton.Click += new System.EventHandler(this.lockButton_Click);
            // 
            // lockRatioTextBox
            // 
            this.lockRatioTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lockRatioTextBox.Location = new System.Drawing.Point(596, 254);
            this.lockRatioTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lockRatioTextBox.Name = "lockRatioTextBox";
            this.lockRatioTextBox.Size = new System.Drawing.Size(132, 27);
            this.lockRatioTextBox.TabIndex = 10;
            this.lockRatioTextBox.Text = "90";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(487, 257);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lock at (%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(624, 219);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Feedback intervals (sec)";
            // 
            // feedbackIntervalTextBox
            // 
            this.feedbackIntervalTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackIntervalTextBox.Location = new System.Drawing.Point(483, 215);
            this.feedbackIntervalTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.feedbackIntervalTextBox.Name = "feedbackIntervalTextBox";
            this.feedbackIntervalTextBox.Size = new System.Drawing.Size(132, 27);
            this.feedbackIntervalTextBox.TabIndex = 10;
            this.feedbackIntervalTextBox.Text = "30";
            // 
            // toleranceTextBox
            // 
            this.toleranceTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toleranceTextBox.Location = new System.Drawing.Point(780, 254);
            this.toleranceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.toleranceTextBox.Name = "toleranceTextBox";
            this.toleranceTextBox.Size = new System.Drawing.Size(132, 27);
            this.toleranceTextBox.TabIndex = 11;
            this.toleranceTextBox.Text = "0.1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(736, 257);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "+/-";
            // 
            // angleTextBox
            // 
            this.angleTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angleTextBox.Location = new System.Drawing.Point(491, 302);
            this.angleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.angleTextBox.Name = "angleTextBox";
            this.angleTextBox.Size = new System.Drawing.Size(132, 27);
            this.angleTextBox.TabIndex = 10;
            this.angleTextBox.Text = "90";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(631, 305);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "angle";
            // 
            // polarizerButton
            // 
            this.polarizerButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polarizerButton.Location = new System.Drawing.Point(7, 55);
            this.polarizerButton.Margin = new System.Windows.Forms.Padding(4);
            this.polarizerButton.Name = "polarizerButton";
            this.polarizerButton.Size = new System.Drawing.Size(213, 33);
            this.polarizerButton.TabIndex = 0;
            this.polarizerButton.Text = "rotate and record";
            this.polarizerButton.UseVisualStyleBackColor = true;
            this.polarizerButton.Click += new System.EventHandler(this.rotateAndrecord);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(222, 61);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(396, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "use this to find the angle of pol. axis and home";
            // 
            // saveDataLabel
            // 
            this.saveDataLabel.AutoSize = true;
            this.saveDataLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveDataLabel.Location = new System.Drawing.Point(235, 359);
            this.saveDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.saveDataLabel.Name = "saveDataLabel";
            this.saveDataLabel.Size = new System.Drawing.Size(174, 21);
            this.saveDataLabel.TabIndex = 13;
            this.saveDataLabel.Text = "save the data here";
            // 
            // openFileButton
            // 
            this.openFileButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFileButton.Location = new System.Drawing.Point(13, 353);
            this.openFileButton.Margin = new System.Windows.Forms.Padding(4);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(213, 33);
            this.openFileButton.TabIndex = 0;
            this.openFileButton.Text = "Save file...";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // connectKrochmannButton
            // 
            this.connectKrochmannButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectKrochmannButton.Location = new System.Drawing.Point(55, 69);
            this.connectKrochmannButton.Margin = new System.Windows.Forms.Padding(4);
            this.connectKrochmannButton.Name = "connectKrochmannButton";
            this.connectKrochmannButton.Size = new System.Drawing.Size(261, 36);
            this.connectKrochmannButton.TabIndex = 1;
            this.connectKrochmannButton.Text = "connect to Krochmann";
            this.connectKrochmannButton.UseVisualStyleBackColor = true;
            this.connectKrochmannButton.Click += new System.EventHandler(this.connectKrochmannButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.connectToELLStageButton);
            this.panel1.Controls.Add(this.comPortButton1);
            this.panel1.Controls.Add(this.comPortComboBox1);
            this.panel1.Location = new System.Drawing.Point(13, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 111);
            this.panel1.TabIndex = 14;
            // 
            // comPortComboBox2
            // 
            this.comPortComboBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comPortComboBox2.FormattingEnabled = true;
            this.comPortComboBox2.Location = new System.Drawing.Point(4, 22);
            this.comPortComboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comPortComboBox2.Name = "comPortComboBox2";
            this.comPortComboBox2.Size = new System.Drawing.Size(160, 29);
            this.comPortComboBox2.TabIndex = 3;
            // 
            // comPortButton2
            // 
            this.comPortButton2.AutoSize = true;
            this.comPortButton2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comPortButton2.Location = new System.Drawing.Point(173, 20);
            this.comPortButton2.Margin = new System.Windows.Forms.Padding(4);
            this.comPortButton2.Name = "comPortButton2";
            this.comPortButton2.Size = new System.Drawing.Size(229, 38);
            this.comPortButton2.TabIndex = 0;
            this.comPortButton2.Text = "refresh COM ports";
            this.comPortButton2.UseVisualStyleBackColor = true;
            this.comPortButton2.Click += new System.EventHandler(this.comPortButton2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.comPortButton2);
            this.panel2.Controls.Add(this.comPortComboBox2);
            this.panel2.Controls.Add(this.connectKrochmannButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new System.Drawing.Point(13, 139);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 199);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.connectToDMMButton);
            this.panel3.Controls.Add(this.gpibAddressTextBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(377, 21);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(313, 111);
            this.panel3.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.totalRotationTextBox);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.numberOfRepeatsTextBox);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.theta0TextBox);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.dthetaTextBox);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.polarizerButton);
            this.panel4.Location = new System.Drawing.Point(13, 403);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(899, 100);
            this.panel4.TabIndex = 17;
            // 
            // totalRotationTextBox
            // 
            this.totalRotationTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRotationTextBox.Location = new System.Drawing.Point(168, 17);
            this.totalRotationTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.totalRotationTextBox.Name = "totalRotationTextBox";
            this.totalRotationTextBox.Size = new System.Drawing.Size(64, 27);
            this.totalRotationTextBox.TabIndex = 23;
            this.totalRotationTextBox.Text = "90";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(234, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 68);
            this.label11.TabIndex = 24;
            this.label11.Text = "total rotation (deg)";
            // 
            // numberOfRepeatsTextBox
            // 
            this.numberOfRepeatsTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfRepeatsTextBox.Location = new System.Drawing.Point(499, 20);
            this.numberOfRepeatsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.numberOfRepeatsTextBox.Name = "numberOfRepeatsTextBox";
            this.numberOfRepeatsTextBox.Size = new System.Drawing.Size(52, 27);
            this.numberOfRepeatsTextBox.TabIndex = 21;
            this.numberOfRepeatsTextBox.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(553, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 21);
            this.label10.TabIndex = 22;
            this.label10.Text = "number of repeats";
            // 
            // theta0TextBox
            // 
            this.theta0TextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theta0TextBox.Location = new System.Drawing.Point(7, 17);
            this.theta0TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.theta0TextBox.Name = "theta0TextBox";
            this.theta0TextBox.Size = new System.Drawing.Size(64, 27);
            this.theta0TextBox.TabIndex = 19;
            this.theta0TextBox.Text = "54.506";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(73, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 21);
            this.label9.TabIndex = 20;
            this.label9.Text = "θ0 (deg)";
            // 
            // dthetaTextBox
            // 
            this.dthetaTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dthetaTextBox.Location = new System.Drawing.Point(325, 17);
            this.dthetaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.dthetaTextBox.Name = "dthetaTextBox";
            this.dthetaTextBox.Size = new System.Drawing.Size(52, 27);
            this.dthetaTextBox.TabIndex = 18;
            this.dthetaTextBox.Text = "0.1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(379, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "Δθ (deg)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 793);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.saveDataLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.toleranceTextBox);
            this.Controls.Add(this.feedbackIntervalTextBox);
            this.Controls.Add(this.angleTextBox);
            this.Controls.Add(this.lockRatioTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lockButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.disconnectELLStageButton);
            this.Controls.Add(this.openFileButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectToELLStageButton;
        private System.Windows.Forms.Button disconnectELLStageButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comPortComboBox1;
        private System.Windows.Forms.Button comPortButton1;
        private System.Windows.Forms.TextBox gpibAddressTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectToDMMButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button lockButton;
        private System.Windows.Forms.TextBox lockRatioTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox feedbackIntervalTextBox;
        private System.Windows.Forms.TextBox toleranceTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox angleTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button polarizerButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label saveDataLabel;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button connectKrochmannButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comPortComboBox2;
        private System.Windows.Forms.Button comPortButton2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox dthetaTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox theta0TextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox numberOfRepeatsTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox totalRotationTextBox;
        private System.Windows.Forms.Label label11;
    }
}

