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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbxFloors = new System.Windows.Forms.ListBox();
            this.lbxCarList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCurrentCar = new System.Windows.Forms.Label();
            this.lblErrorText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewCar = new System.Windows.Forms.Button();
            this.tbxPassCode = new System.Windows.Forms.TextBox();
            this.tbxLicense = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblParkingError = new System.Windows.Forms.Label();
            this.BtnPark = new System.Windows.Forms.Button();
            this.btnDownFloor = new System.Windows.Forms.Button();
            this.btnUpFloor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxFloors);
            this.groupBox1.Controls.Add(this.lbxCarList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 501);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Floor space";
            // 
            // lbxFloors
            // 
            this.lbxFloors.FormattingEnabled = true;
            this.lbxFloors.Location = new System.Drawing.Point(6, 25);
            this.lbxFloors.Name = "lbxFloors";
            this.lbxFloors.Size = new System.Drawing.Size(188, 108);
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.lblCurrentCar);
            this.groupBox2.Controls.Add(this.lblErrorText);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnNewCar);
            this.groupBox2.Controls.Add(this.tbxPassCode);
            this.groupBox2.Controls.Add(this.tbxLicense);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 163);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Car entry";
            // 
            // lblCurrentCar
            // 
            this.lblCurrentCar.AutoSize = true;
            this.lblCurrentCar.Location = new System.Drawing.Point(10, 136);
            this.lblCurrentCar.Name = "lblCurrentCar";
            this.lblCurrentCar.Size = new System.Drawing.Size(71, 13);
            this.lblCurrentCar.TabIndex = 11;
            this.lblCurrentCar.Text = "License Plate";
            // 
            // lblErrorText
            // 
            this.lblErrorText.AutoSize = true;
            this.lblErrorText.Location = new System.Drawing.Point(87, 24);
            this.lblErrorText.Name = "lblErrorText";
            this.lblErrorText.Size = new System.Drawing.Size(71, 13);
            this.lblErrorText.TabIndex = 10;
            this.lblErrorText.Text = "License Plate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Passcode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "License Plate";
            // 
            // btnNewCar
            // 
            this.btnNewCar.Location = new System.Drawing.Point(6, 19);
            this.btnNewCar.Name = "btnNewCar";
            this.btnNewCar.Size = new System.Drawing.Size(75, 23);
            this.btnNewCar.TabIndex = 7;
            this.btnNewCar.Text = "New Car";
            this.btnNewCar.UseVisualStyleBackColor = true;
            this.btnNewCar.Click += new System.EventHandler(this.btnNewCar_Click);
            // 
            // tbxPassCode
            // 
            this.tbxPassCode.Location = new System.Drawing.Point(6, 74);
            this.tbxPassCode.Name = "tbxPassCode";
            this.tbxPassCode.Size = new System.Drawing.Size(100, 20);
            this.tbxPassCode.TabIndex = 6;
            // 
            // tbxLicense
            // 
            this.tbxLicense.Location = new System.Drawing.Point(6, 48);
            this.tbxLicense.Name = "tbxLicense";
            this.tbxLicense.Size = new System.Drawing.Size(100, 20);
            this.tbxLicense.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(250, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Get Coin";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Location = new System.Drawing.Point(218, 350);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 163);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Car Exit";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(168, 19);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 2;
            this.button8.Text = "Exit";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(87, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 1;
            this.button7.Text = "Return Coin";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 0;
            this.button6.Text = "Unpark";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(555, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(359, 501);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Payment and other externals";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Controls.Add(this.lblParkingError);
            this.groupBox5.Controls.Add(this.BtnPark);
            this.groupBox5.Controls.Add(this.btnDownFloor);
            this.groupBox5.Controls.Add(this.btnUpFloor);
            this.groupBox5.Location = new System.Drawing.Point(218, 181);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(331, 163);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "In park";
            // 
            // lblParkingError
            // 
            this.lblParkingError.AutoSize = true;
            this.lblParkingError.Location = new System.Drawing.Point(84, 24);
            this.lblParkingError.Name = "lblParkingError";
            this.lblParkingError.Size = new System.Drawing.Size(71, 13);
            this.lblParkingError.TabIndex = 11;
            this.lblParkingError.Text = "License Plate";
            // 
            // BtnPark
            // 
            this.BtnPark.Location = new System.Drawing.Point(6, 134);
            this.BtnPark.Name = "BtnPark";
            this.BtnPark.Size = new System.Drawing.Size(75, 23);
            this.BtnPark.TabIndex = 4;
            this.BtnPark.Text = "Park";
            this.BtnPark.UseVisualStyleBackColor = true;
            this.BtnPark.Click += new System.EventHandler(this.BtnPark_Click);
            // 
            // btnDownFloor
            // 
            this.btnDownFloor.Location = new System.Drawing.Point(6, 48);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Discount";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(45, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 525);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Car Park System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbxCarList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox5;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

