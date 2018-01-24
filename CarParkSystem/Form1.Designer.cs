namespace CarParkSystem
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblErrorText = new System.Windows.Forms.Label();
            this.lbxFloors = new System.Windows.Forms.ListBox();
            this.lbxCarList = new System.Windows.Forms.ListBox();
            this.lblCurrentCar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPassCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxLicense = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tbxExitPass = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPaymentneeded = new System.Windows.Forms.Button();
            this.lblpayneeded = new System.Windows.Forms.Label();
            this.dcLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnApplyDiscount = new System.Windows.Forms.Button();
            this.nudDiscountAmount = new System.Windows.Forms.NumericUpDown();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnHourBackwards = new System.Windows.Forms.Button();
            this.btnHourFoward = new System.Windows.Forms.Button();
            this.lblParkingError = new System.Windows.Forms.Label();
            this.BtnPark = new System.Windows.Forms.Button();
            this.btnDownFloor = new System.Windows.Forms.Button();
            this.btnUpFloor = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnNewCar = new System.Windows.Forms.Button();
            this.pbxEntranceClosed = new System.Windows.Forms.PictureBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.pbxEntranceOpen = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnCardScan = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btnEmergency = new System.Windows.Forms.Button();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.btnAdvancePay = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxAdvanceLicensePlate = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscountAmount)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEntranceClosed)).BeginInit();
            this.groupBox13.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEntranceOpen)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblErrorText);
            this.groupBox1.Controls.Add(this.lbxFloors);
            this.groupBox1.Controls.Add(this.lbxCarList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 501);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Floor space";
            // 
            // lblErrorText
            // 
            this.lblErrorText.AutoSize = true;
            this.lblErrorText.Location = new System.Drawing.Point(6, 22);
            this.lblErrorText.Name = "lblErrorText";
            this.lblErrorText.Size = new System.Drawing.Size(71, 13);
            this.lblErrorText.TabIndex = 10;
            this.lblErrorText.Text = "License Plate";
            // 
            // lbxFloors
            // 
            this.lbxFloors.FormattingEnabled = true;
            this.lbxFloors.Location = new System.Drawing.Point(6, 38);
            this.lbxFloors.Name = "lbxFloors";
            this.lbxFloors.Size = new System.Drawing.Size(188, 95);
            this.lbxFloors.TabIndex = 1;
            // 
            // lbxCarList
            // 
            this.lbxCarList.FormattingEnabled = true;
            this.lbxCarList.Location = new System.Drawing.Point(6, 136);
            this.lbxCarList.Name = "lbxCarList";
            this.lbxCarList.Size = new System.Drawing.Size(188, 355);
            this.lbxCarList.TabIndex = 0;
            // 
            // lblCurrentCar
            // 
            this.lblCurrentCar.AutoSize = true;
            this.lblCurrentCar.Location = new System.Drawing.Point(6, 16);
            this.lblCurrentCar.Name = "lblCurrentCar";
            this.lblCurrentCar.Size = new System.Drawing.Size(71, 13);
            this.lblCurrentCar.TabIndex = 11;
            this.lblCurrentCar.Text = "License Plate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Passcode";
            // 
            // tbxPassCode
            // 
            this.tbxPassCode.Location = new System.Drawing.Point(10, 76);
            this.tbxPassCode.Name = "tbxPassCode";
            this.tbxPassCode.Size = new System.Drawing.Size(100, 20);
            this.tbxPassCode.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "License Plate";
            // 
            // tbxLicense
            // 
            this.tbxLicense.Location = new System.Drawing.Point(5, 19);
            this.tbxLicense.Name = "tbxLicense";
            this.tbxLicense.Size = new System.Drawing.Size(100, 20);
            this.tbxLicense.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Get Coin";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbxExitPass
            // 
            this.tbxExitPass.Location = new System.Drawing.Point(6, 73);
            this.tbxExitPass.Name = "tbxExitPass";
            this.tbxExitPass.Size = new System.Drawing.Size(100, 20);
            this.tbxExitPass.TabIndex = 12;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(119, 70);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPaymentneeded
            // 
            this.btnPaymentneeded.Location = new System.Drawing.Point(6, 20);
            this.btnPaymentneeded.Name = "btnPaymentneeded";
            this.btnPaymentneeded.Size = new System.Drawing.Size(75, 23);
            this.btnPaymentneeded.TabIndex = 0;
            this.btnPaymentneeded.Text = "Pay for stay";
            this.btnPaymentneeded.UseVisualStyleBackColor = true;
            this.btnPaymentneeded.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // lblpayneeded
            // 
            this.lblpayneeded.AutoSize = true;
            this.lblpayneeded.Location = new System.Drawing.Point(87, 25);
            this.lblpayneeded.Name = "lblpayneeded";
            this.lblpayneeded.Size = new System.Drawing.Size(35, 13);
            this.lblpayneeded.TabIndex = 1;
            this.lblpayneeded.Text = "label3";
            // 
            // dcLbl
            // 
            this.dcLbl.AutoSize = true;
            this.dcLbl.Location = new System.Drawing.Point(96, 18);
            this.dcLbl.Name = "dcLbl";
            this.dcLbl.Size = new System.Drawing.Size(13, 13);
            this.dcLbl.TabIndex = 8;
            this.dcLbl.Text = "0";
            this.dcLbl.Click += new System.EventHandler(this.dcLbl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Current Discount";
            // 
            // btnApplyDiscount
            // 
            this.btnApplyDiscount.Location = new System.Drawing.Point(7, 60);
            this.btnApplyDiscount.Name = "btnApplyDiscount";
            this.btnApplyDiscount.Size = new System.Drawing.Size(75, 23);
            this.btnApplyDiscount.TabIndex = 6;
            this.btnApplyDiscount.Text = "Apply Discount";
            this.btnApplyDiscount.UseVisualStyleBackColor = true;
            this.btnApplyDiscount.Click += new System.EventHandler(this.btnApplyDiscount_Click);
            // 
            // nudDiscountAmount
            // 
            this.nudDiscountAmount.Location = new System.Drawing.Point(6, 34);
            this.nudDiscountAmount.Name = "nudDiscountAmount";
            this.nudDiscountAmount.Size = new System.Drawing.Size(120, 20);
            this.nudDiscountAmount.TabIndex = 5;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(46, 45);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(35, 13);
            this.lblTimer.TabIndex = 4;
            this.lblTimer.Text = "label3";
            // 
            // btnHourBackwards
            // 
            this.btnHourBackwards.Location = new System.Drawing.Point(6, 61);
            this.btnHourBackwards.Name = "btnHourBackwards";
            this.btnHourBackwards.Size = new System.Drawing.Size(75, 23);
            this.btnHourBackwards.TabIndex = 3;
            this.btnHourBackwards.Text = "Time--";
            this.btnHourBackwards.UseVisualStyleBackColor = true;
            this.btnHourBackwards.Click += new System.EventHandler(this.btnHourBackwards_Click);
            // 
            // btnHourFoward
            // 
            this.btnHourFoward.Location = new System.Drawing.Point(6, 19);
            this.btnHourFoward.Name = "btnHourFoward";
            this.btnHourFoward.Size = new System.Drawing.Size(75, 23);
            this.btnHourFoward.TabIndex = 2;
            this.btnHourFoward.Text = "Time++";
            this.btnHourFoward.UseVisualStyleBackColor = true;
            this.btnHourFoward.Click += new System.EventHandler(this.btnHourFoward_Click);
            // 
            // lblParkingError
            // 
            this.lblParkingError.AutoSize = true;
            this.lblParkingError.Location = new System.Drawing.Point(116, 24);
            this.lblParkingError.Name = "lblParkingError";
            this.lblParkingError.Size = new System.Drawing.Size(71, 13);
            this.lblParkingError.TabIndex = 11;
            this.lblParkingError.Text = "License Plate";
            // 
            // BtnPark
            // 
            this.BtnPark.Location = new System.Drawing.Point(119, 134);
            this.BtnPark.Name = "BtnPark";
            this.BtnPark.Size = new System.Drawing.Size(75, 23);
            this.BtnPark.TabIndex = 4;
            this.BtnPark.Text = "Park";
            this.BtnPark.UseVisualStyleBackColor = true;
            this.BtnPark.Click += new System.EventHandler(this.BtnPark_Click);
            // 
            // btnDownFloor
            // 
            this.btnDownFloor.Location = new System.Drawing.Point(6, 134);
            this.btnDownFloor.Name = "btnDownFloor";
            this.btnDownFloor.Size = new System.Drawing.Size(75, 23);
            this.btnDownFloor.TabIndex = 3;
            this.btnDownFloor.Text = "go down floor";
            this.btnDownFloor.UseVisualStyleBackColor = true;
            this.btnDownFloor.Click += new System.EventHandler(this.btnDownFloor_Click);
            // 
            // btnUpFloor
            // 
            this.btnUpFloor.Location = new System.Drawing.Point(6, 19);
            this.btnUpFloor.Name = "btnUpFloor";
            this.btnUpFloor.Size = new System.Drawing.Size(75, 23);
            this.btnUpFloor.TabIndex = 2;
            this.btnUpFloor.Text = "go up floor";
            this.btnUpFloor.UseVisualStyleBackColor = true;
            this.btnUpFloor.Click += new System.EventHandler(this.btnUpFloor_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnNewCar);
            this.groupBox4.Controls.Add(this.pbxEntranceClosed);
            this.groupBox4.Controls.Add(this.groupBox13);
            this.groupBox4.Controls.Add(this.groupBox11);
            this.groupBox4.Controls.Add(this.pbxEntranceOpen);
            this.groupBox4.Location = new System.Drawing.Point(218, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 163);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Entrance";
            // 
            // btnNewCar
            // 
            this.btnNewCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCar.Image = global::CarParkSystem.Properties.Resources.CarParkCar1;
            this.btnNewCar.Location = new System.Drawing.Point(120, 103);
            this.btnNewCar.Name = "btnNewCar";
            this.btnNewCar.Size = new System.Drawing.Size(76, 46);
            this.btnNewCar.TabIndex = 7;
            this.btnNewCar.Text = "New Car";
            this.btnNewCar.UseVisualStyleBackColor = true;
            this.btnNewCar.Click += new System.EventHandler(this.btnNewCar_Click);
            // 
            // pbxEntranceClosed
            // 
            this.pbxEntranceClosed.Image = global::CarParkSystem.Properties.Resources.CarParkEntranceClosed;
            this.pbxEntranceClosed.Location = new System.Drawing.Point(91, 94);
            this.pbxEntranceClosed.Name = "pbxEntranceClosed";
            this.pbxEntranceClosed.Size = new System.Drawing.Size(100, 59);
            this.pbxEntranceClosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEntranceClosed.TabIndex = 10;
            this.pbxEntranceClosed.TabStop = false;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.button2);
            this.groupBox13.Location = new System.Drawing.Point(6, 70);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(79, 83);
            this.groupBox13.TabIndex = 1;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Get coin button";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label1);
            this.groupBox11.Controls.Add(this.tbxLicense);
            this.groupBox11.Location = new System.Drawing.Point(6, 19);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(188, 45);
            this.groupBox11.TabIndex = 0;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "License plate scanner";
            // 
            // pbxEntranceOpen
            // 
            this.pbxEntranceOpen.Image = global::CarParkSystem.Properties.Resources.CarParkEntranceOpenV2;
            this.pbxEntranceOpen.Location = new System.Drawing.Point(91, 52);
            this.pbxEntranceOpen.Name = "pbxEntranceOpen";
            this.pbxEntranceOpen.Size = new System.Drawing.Size(45, 101);
            this.pbxEntranceOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEntranceOpen.TabIndex = 11;
            this.pbxEntranceOpen.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnPaymentneeded);
            this.groupBox6.Controls.Add(this.lblpayneeded);
            this.groupBox6.Location = new System.Drawing.Point(630, 181);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 163);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "payment machine";
            // 
            // groupBox7
            // 
            this.groupBox7.Location = new System.Drawing.Point(630, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 163);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Car grid";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnCardScan);
            this.groupBox8.Controls.Add(this.dcLbl);
            this.groupBox8.Controls.Add(this.nudDiscountAmount);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.btnApplyDiscount);
            this.groupBox8.Location = new System.Drawing.Point(218, 181);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(200, 163);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Discount";
            // 
            // btnCardScan
            // 
            this.btnCardScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCardScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCardScan.Image = global::CarParkSystem.Properties.Resources.cardScan;
            this.btnCardScan.Location = new System.Drawing.Point(132, 34);
            this.btnCardScan.Name = "btnCardScan";
            this.btnCardScan.Size = new System.Drawing.Size(47, 46);
            this.btnCardScan.TabIndex = 12;
            this.btnCardScan.Text = "Scan ID Card";
            this.btnCardScan.UseVisualStyleBackColor = true;
            this.btnCardScan.Click += new System.EventHandler(this.btnCardScan_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnExit);
            this.groupBox9.Controls.Add(this.tbxExitPass);
            this.groupBox9.Controls.Add(this.groupBox12);
            this.groupBox9.Location = new System.Drawing.Point(218, 350);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(200, 163);
            this.groupBox9.TabIndex = 7;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Exit";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.lblCurrentCar);
            this.groupBox12.Location = new System.Drawing.Point(6, 19);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(188, 45);
            this.groupBox12.TabIndex = 1;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "License plate scanner";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.btnEmergency);
            this.groupBox10.Location = new System.Drawing.Point(630, 350);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(200, 163);
            this.groupBox10.TabIndex = 8;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Emergency Mode";
            // 
            // btnEmergency
            // 
            this.btnEmergency.Location = new System.Drawing.Point(60, 72);
            this.btnEmergency.Name = "btnEmergency";
            this.btnEmergency.Size = new System.Drawing.Size(75, 23);
            this.btnEmergency.TabIndex = 11;
            this.btnEmergency.Text = "Emergency button";
            this.btnEmergency.UseVisualStyleBackColor = true;
            this.btnEmergency.Click += new System.EventHandler(this.btnEmergency_Click);
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.groupBox2);
            this.groupBox14.Controls.Add(this.btnAdvancePay);
            this.groupBox14.Location = new System.Drawing.Point(424, 181);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(200, 163);
            this.groupBox14.TabIndex = 9;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Advanced payment";
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.label2);
            this.groupBox15.Controls.Add(this.tbxPassCode);
            this.groupBox15.Controls.Add(this.btnUpFloor);
            this.groupBox15.Controls.Add(this.btnDownFloor);
            this.groupBox15.Controls.Add(this.BtnPark);
            this.groupBox15.Controls.Add(this.lblParkingError);
            this.groupBox15.Location = new System.Drawing.Point(424, 12);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(200, 163);
            this.groupBox15.TabIndex = 10;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Parking";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.lblTimer);
            this.groupBox16.Controls.Add(this.btnHourFoward);
            this.groupBox16.Controls.Add(this.btnHourBackwards);
            this.groupBox16.Location = new System.Drawing.Point(424, 350);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(200, 163);
            this.groupBox16.TabIndex = 12;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "The passage of time";
            // 
            // btnAdvancePay
            // 
            this.btnAdvancePay.Location = new System.Drawing.Point(6, 20);
            this.btnAdvancePay.Name = "btnAdvancePay";
            this.btnAdvancePay.Size = new System.Drawing.Size(104, 23);
            this.btnAdvancePay.TabIndex = 2;
            this.btnAdvancePay.Text = "Advance Pay";
            this.btnAdvancePay.UseVisualStyleBackColor = true;
            this.btnAdvancePay.Click += new System.EventHandler(this.btnAdvancePay_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbxAdvanceLicensePlate);
            this.groupBox2.Location = new System.Drawing.Point(6, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 45);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input License plate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "License Plate";
            // 
            // tbxAdvanceLicensePlate
            // 
            this.tbxAdvanceLicensePlate.Location = new System.Drawing.Point(5, 19);
            this.tbxAdvanceLicensePlate.Name = "tbxAdvanceLicensePlate";
            this.tbxAdvanceLicensePlate.Size = new System.Drawing.Size(100, 20);
            this.tbxAdvanceLicensePlate.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 525);
            this.Controls.Add(this.groupBox16);
            this.Controls.Add(this.groupBox15);
            this.Controls.Add(this.groupBox14);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Car Park System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscountAmount)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxEntranceClosed)).EndInit();
            this.groupBox13.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEntranceOpen)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbxCarList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button BtnPark;
        private System.Windows.Forms.Button btnDownFloor;
        private System.Windows.Forms.Button btnUpFloor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewCar;
        private System.Windows.Forms.TextBox tbxPassCode;
        private System.Windows.Forms.TextBox tbxLicense;
        private System.Windows.Forms.Label lblErrorText;
        private System.Windows.Forms.ListBox lbxFloors;
        private System.Windows.Forms.Label lblParkingError;
        private System.Windows.Forms.Label lblCurrentCar;
        private System.Windows.Forms.Button btnPaymentneeded;
        private System.Windows.Forms.Label lblpayneeded;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnHourBackwards;
        private System.Windows.Forms.Button btnHourFoward;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnApplyDiscount;
        private System.Windows.Forms.NumericUpDown nudDiscountAmount;
        private System.Windows.Forms.Label dcLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxExitPass;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.PictureBox pbxEntranceClosed;
        private System.Windows.Forms.PictureBox pbxEntranceOpen;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Button btnEmergency;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Button btnCardScan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxAdvanceLicensePlate;
        private System.Windows.Forms.Button btnAdvancePay;
    }
}

