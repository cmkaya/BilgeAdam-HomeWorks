
namespace Week5.CarDemo
{
    partial class SpecificationForm
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
            this.lHeaderGeneralInfo = new System.Windows.Forms.Label();
            this.lHeaderSize = new System.Windows.Forms.Label();
            this.lBrand = new System.Windows.Forms.Label();
            this.lModel = new System.Windows.Forms.Label();
            this.lHeaderTechnical = new System.Windows.Forms.Label();
            this.lEnginePos = new System.Windows.Forms.Label();
            this.lTypeOfCar = new System.Windows.Forms.Label();
            this.lTopSpeed = new System.Windows.Forms.Label();
            this.lNumOfDoors = new System.Windows.Forms.Label();
            this.lAcceleration = new System.Windows.Forms.Label();
            this.lCurbWeight = new System.Windows.Forms.Label();
            this.lEngineSize = new System.Windows.Forms.Label();
            this.lMaxPower = new System.Windows.Forms.Label();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.ddlCarType = new System.Windows.Forms.ComboBox();
            this.rbTwoDoor = new System.Windows.Forms.RadioButton();
            this.rbFourDoor = new System.Windows.Forms.RadioButton();
            this.rbFiveDoors = new System.Windows.Forms.RadioButton();
            this.nudMaxPower = new System.Windows.Forms.NumericUpDown();
            this.nudEngineSize = new System.Windows.Forms.NumericUpDown();
            this.nudTopSpeed = new System.Windows.Forms.NumericUpDown();
            this.nudCurbWeight = new System.Windows.Forms.NumericUpDown();
            this.lGearbox = new System.Windows.Forms.Label();
            this.cbManual = new System.Windows.Forms.CheckBox();
            this.rbFwd = new System.Windows.Forms.RadioButton();
            this.rbRwd = new System.Windows.Forms.RadioButton();
            this.rbAwd = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbEngine = new System.Windows.Forms.PictureBox();
            this.pbSize = new System.Windows.Forms.PictureBox();
            this.lDisplay = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btDisplay = new System.Windows.Forms.Button();
            this.btCreate = new System.Windows.Forms.Button();
            this.nudAcceleration = new System.Windows.Forms.NumericUpDown();
            this.lProductYear = new System.Windows.Forms.Label();
            this.dtpProductYear = new System.Windows.Forms.DateTimePicker();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEngineSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTopSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCurbWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEngine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAcceleration)).BeginInit();
            this.SuspendLayout();
            // 
            // lHeaderGeneralInfo
            // 
            this.lHeaderGeneralInfo.BackColor = System.Drawing.Color.Gray;
            this.lHeaderGeneralInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lHeaderGeneralInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHeaderGeneralInfo.ForeColor = System.Drawing.Color.White;
            this.lHeaderGeneralInfo.Location = new System.Drawing.Point(12, 9);
            this.lHeaderGeneralInfo.Name = "lHeaderGeneralInfo";
            this.lHeaderGeneralInfo.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.lHeaderGeneralInfo.Size = new System.Drawing.Size(432, 38);
            this.lHeaderGeneralInfo.TabIndex = 0;
            this.lHeaderGeneralInfo.Text = "Car-Specs";
            this.lHeaderGeneralInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lHeaderSize
            // 
            this.lHeaderSize.BackColor = System.Drawing.Color.Gray;
            this.lHeaderSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHeaderSize.ForeColor = System.Drawing.Color.White;
            this.lHeaderSize.Location = new System.Drawing.Point(8, 454);
            this.lHeaderSize.Name = "lHeaderSize";
            this.lHeaderSize.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.lHeaderSize.Size = new System.Drawing.Size(436, 38);
            this.lHeaderSize.TabIndex = 1;
            this.lHeaderSize.Text = "Size, Dimensions, Aerodynamics and Weight";
            this.lHeaderSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lBrand
            // 
            this.lBrand.AutoSize = true;
            this.lBrand.Location = new System.Drawing.Point(16, 62);
            this.lBrand.Name = "lBrand";
            this.lBrand.Size = new System.Drawing.Size(35, 13);
            this.lBrand.TabIndex = 4;
            this.lBrand.Text = "Brand";
            // 
            // lModel
            // 
            this.lModel.AutoSize = true;
            this.lModel.Location = new System.Drawing.Point(16, 95);
            this.lModel.Name = "lModel";
            this.lModel.Size = new System.Drawing.Size(36, 13);
            this.lModel.TabIndex = 4;
            this.lModel.Text = "Model";
            // 
            // lHeaderTechnical
            // 
            this.lHeaderTechnical.BackColor = System.Drawing.Color.Gray;
            this.lHeaderTechnical.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHeaderTechnical.ForeColor = System.Drawing.Color.White;
            this.lHeaderTechnical.Location = new System.Drawing.Point(12, 186);
            this.lHeaderTechnical.Name = "lHeaderTechnical";
            this.lHeaderTechnical.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.lHeaderTechnical.Size = new System.Drawing.Size(432, 38);
            this.lHeaderTechnical.TabIndex = 0;
            this.lHeaderTechnical.Text = "Engine Technical Data";
            this.lHeaderTechnical.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lEnginePos
            // 
            this.lEnginePos.AutoSize = true;
            this.lEnginePos.Location = new System.Drawing.Point(8, 374);
            this.lEnginePos.Name = "lEnginePos";
            this.lEnginePos.Size = new System.Drawing.Size(80, 13);
            this.lEnginePos.TabIndex = 4;
            this.lEnginePos.Text = "Engine Position";
            // 
            // lTypeOfCar
            // 
            this.lTypeOfCar.AutoSize = true;
            this.lTypeOfCar.Location = new System.Drawing.Point(16, 124);
            this.lTypeOfCar.Name = "lTypeOfCar";
            this.lTypeOfCar.Size = new System.Drawing.Size(50, 13);
            this.lTypeOfCar.TabIndex = 4;
            this.lTypeOfCar.Text = "Car Type";
            // 
            // lTopSpeed
            // 
            this.lTopSpeed.AutoSize = true;
            this.lTopSpeed.Location = new System.Drawing.Point(12, 238);
            this.lTopSpeed.Name = "lTopSpeed";
            this.lTopSpeed.Size = new System.Drawing.Size(60, 13);
            this.lTopSpeed.TabIndex = 4;
            this.lTopSpeed.Text = "Top Speed";
            // 
            // lNumOfDoors
            // 
            this.lNumOfDoors.AutoSize = true;
            this.lNumOfDoors.Location = new System.Drawing.Point(4, 550);
            this.lNumOfDoors.Name = "lNumOfDoors";
            this.lNumOfDoors.Size = new System.Drawing.Size(78, 13);
            this.lNumOfDoors.TabIndex = 4;
            this.lNumOfDoors.Text = "Num. of. Doors";
            // 
            // lAcceleration
            // 
            this.lAcceleration.AutoSize = true;
            this.lAcceleration.Location = new System.Drawing.Point(12, 266);
            this.lAcceleration.Name = "lAcceleration";
            this.lAcceleration.Size = new System.Drawing.Size(66, 13);
            this.lAcceleration.TabIndex = 4;
            this.lAcceleration.Text = "Acceleration";
            // 
            // lCurbWeight
            // 
            this.lCurbWeight.AutoSize = true;
            this.lCurbWeight.Location = new System.Drawing.Point(5, 515);
            this.lCurbWeight.Name = "lCurbWeight";
            this.lCurbWeight.Size = new System.Drawing.Size(66, 13);
            this.lCurbWeight.TabIndex = 4;
            this.lCurbWeight.Text = "Curb Weight";
            // 
            // lEngineSize
            // 
            this.lEngineSize.AutoSize = true;
            this.lEngineSize.Location = new System.Drawing.Point(12, 293);
            this.lEngineSize.Name = "lEngineSize";
            this.lEngineSize.Size = new System.Drawing.Size(63, 13);
            this.lEngineSize.TabIndex = 4;
            this.lEngineSize.Text = "Engine Size";
            // 
            // lMaxPower
            // 
            this.lMaxPower.AutoSize = true;
            this.lMaxPower.Location = new System.Drawing.Point(12, 319);
            this.lMaxPower.Name = "lMaxPower";
            this.lMaxPower.Size = new System.Drawing.Size(84, 13);
            this.lMaxPower.TabIndex = 4;
            this.lMaxPower.Text = "Maximum Power";
            // 
            // tbBrand
            // 
            this.tbBrand.Location = new System.Drawing.Point(139, 54);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(191, 20);
            this.tbBrand.TabIndex = 5;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(139, 88);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(191, 20);
            this.tbModel.TabIndex = 5;
            // 
            // ddlCarType
            // 
            this.ddlCarType.FormattingEnabled = true;
            this.ddlCarType.Location = new System.Drawing.Point(139, 115);
            this.ddlCarType.Name = "ddlCarType";
            this.ddlCarType.Size = new System.Drawing.Size(191, 21);
            this.ddlCarType.TabIndex = 6;
            // 
            // rbTwoDoor
            // 
            this.rbTwoDoor.AutoSize = true;
            this.rbTwoDoor.Location = new System.Drawing.Point(135, 546);
            this.rbTwoDoor.Name = "rbTwoDoor";
            this.rbTwoDoor.Size = new System.Drawing.Size(77, 17);
            this.rbTwoDoor.TabIndex = 7;
            this.rbTwoDoor.TabStop = true;
            this.rbTwoDoor.Text = "Two Doors";
            this.rbTwoDoor.UseVisualStyleBackColor = true;
            // 
            // rbFourDoor
            // 
            this.rbFourDoor.AutoSize = true;
            this.rbFourDoor.Location = new System.Drawing.Point(135, 569);
            this.rbFourDoor.Name = "rbFourDoor";
            this.rbFourDoor.Size = new System.Drawing.Size(77, 17);
            this.rbFourDoor.TabIndex = 7;
            this.rbFourDoor.TabStop = true;
            this.rbFourDoor.Text = "Four Doors";
            this.rbFourDoor.UseVisualStyleBackColor = true;
            // 
            // rbFiveDoors
            // 
            this.rbFiveDoors.AutoSize = true;
            this.rbFiveDoors.Location = new System.Drawing.Point(135, 592);
            this.rbFiveDoors.Name = "rbFiveDoors";
            this.rbFiveDoors.Size = new System.Drawing.Size(76, 17);
            this.rbFiveDoors.TabIndex = 7;
            this.rbFiveDoors.TabStop = true;
            this.rbFiveDoors.Text = "Five Doors";
            this.rbFiveDoors.UseVisualStyleBackColor = true;
            // 
            // nudMaxPower
            // 
            this.nudMaxPower.Location = new System.Drawing.Point(135, 311);
            this.nudMaxPower.Name = "nudMaxPower";
            this.nudMaxPower.Size = new System.Drawing.Size(191, 20);
            this.nudMaxPower.TabIndex = 8;
            // 
            // nudEngineSize
            // 
            this.nudEngineSize.Location = new System.Drawing.Point(135, 285);
            this.nudEngineSize.Name = "nudEngineSize";
            this.nudEngineSize.Size = new System.Drawing.Size(191, 20);
            this.nudEngineSize.TabIndex = 8;
            // 
            // nudTopSpeed
            // 
            this.nudTopSpeed.Location = new System.Drawing.Point(135, 231);
            this.nudTopSpeed.Name = "nudTopSpeed";
            this.nudTopSpeed.Size = new System.Drawing.Size(191, 20);
            this.nudTopSpeed.TabIndex = 8;
            // 
            // nudCurbWeight
            // 
            this.nudCurbWeight.Location = new System.Drawing.Point(135, 508);
            this.nudCurbWeight.Name = "nudCurbWeight";
            this.nudCurbWeight.Size = new System.Drawing.Size(191, 20);
            this.nudCurbWeight.TabIndex = 8;
            // 
            // lGearbox
            // 
            this.lGearbox.AutoSize = true;
            this.lGearbox.Location = new System.Drawing.Point(9, 349);
            this.lGearbox.Name = "lGearbox";
            this.lGearbox.Size = new System.Drawing.Size(47, 13);
            this.lGearbox.TabIndex = 4;
            this.lGearbox.Text = "Gearbox";
            // 
            // cbManual
            // 
            this.cbManual.AutoSize = true;
            this.cbManual.Location = new System.Drawing.Point(135, 345);
            this.cbManual.Name = "cbManual";
            this.cbManual.Size = new System.Drawing.Size(61, 17);
            this.cbManual.TabIndex = 9;
            this.cbManual.Text = "Manual";
            this.cbManual.UseVisualStyleBackColor = true;
            // 
            // rbFwd
            // 
            this.rbFwd.AutoSize = true;
            this.rbFwd.Location = new System.Drawing.Point(135, 374);
            this.rbFwd.Name = "rbFwd";
            this.rbFwd.Size = new System.Drawing.Size(111, 17);
            this.rbFwd.TabIndex = 7;
            this.rbFwd.TabStop = true;
            this.rbFwd.Text = "Front Wheel Drive";
            this.rbFwd.UseVisualStyleBackColor = true;
            // 
            // rbRwd
            // 
            this.rbRwd.AutoSize = true;
            this.rbRwd.Location = new System.Drawing.Point(135, 395);
            this.rbRwd.Name = "rbRwd";
            this.rbRwd.Size = new System.Drawing.Size(110, 17);
            this.rbRwd.TabIndex = 7;
            this.rbRwd.TabStop = true;
            this.rbRwd.Text = "Rear Wheel Drive";
            this.rbRwd.UseVisualStyleBackColor = true;
            // 
            // rbAwd
            // 
            this.rbAwd.AutoSize = true;
            this.rbAwd.Location = new System.Drawing.Point(135, 418);
            this.rbAwd.Name = "rbAwd";
            this.rbAwd.Size = new System.Drawing.Size(98, 17);
            this.rbAwd.TabIndex = 7;
            this.rbAwd.TabStop = true;
            this.rbAwd.Text = "All Wheel Drive";
            this.rbAwd.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Week5.CarDemo.Properties.Resources.BMW_G20_3_Series_8;
            this.pictureBox1.Location = new System.Drawing.Point(7, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pbEngine
            // 
            this.pbEngine.Image = global::Week5.CarDemo.Properties.Resources.engine2;
            this.pbEngine.Location = new System.Drawing.Point(12, 186);
            this.pbEngine.Name = "pbEngine";
            this.pbEngine.Size = new System.Drawing.Size(44, 38);
            this.pbEngine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbEngine.TabIndex = 3;
            this.pbEngine.TabStop = false;
            // 
            // pbSize
            // 
            this.pbSize.Image = global::Week5.CarDemo.Properties.Resources.ruler;
            this.pbSize.Location = new System.Drawing.Point(7, 454);
            this.pbSize.Name = "pbSize";
            this.pbSize.Size = new System.Drawing.Size(44, 38);
            this.pbSize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSize.TabIndex = 2;
            this.pbSize.TabStop = false;
            // 
            // lDisplay
            // 
            this.lDisplay.BackColor = System.Drawing.Color.Gray;
            this.lDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDisplay.ForeColor = System.Drawing.Color.White;
            this.lDisplay.Location = new System.Drawing.Point(7, 621);
            this.lDisplay.Name = "lDisplay";
            this.lDisplay.Size = new System.Drawing.Size(437, 38);
            this.lDisplay.TabIndex = 0;
            this.lDisplay.Text = "Display The Specifications";
            this.lDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(335, 957);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(109, 47);
            this.btExit.TabIndex = 11;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(247, 882);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 47);
            this.button3.TabIndex = 11;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btDisplay
            // 
            this.btDisplay.Location = new System.Drawing.Point(247, 882);
            this.btDisplay.Name = "btDisplay";
            this.btDisplay.Size = new System.Drawing.Size(197, 47);
            this.btDisplay.TabIndex = 11;
            this.btDisplay.Text = "Display";
            this.btDisplay.UseVisualStyleBackColor = true;
            this.btDisplay.Click += new System.EventHandler(this.btDisplay_Click);
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(7, 882);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(197, 47);
            this.btCreate.TabIndex = 11;
            this.btCreate.Text = "Create";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // nudAcceleration
            // 
            this.nudAcceleration.DecimalPlaces = 1;
            this.nudAcceleration.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudAcceleration.Location = new System.Drawing.Point(135, 259);
            this.nudAcceleration.Name = "nudAcceleration";
            this.nudAcceleration.Size = new System.Drawing.Size(191, 20);
            this.nudAcceleration.TabIndex = 8;
            // 
            // lProductYear
            // 
            this.lProductYear.AutoSize = true;
            this.lProductYear.Location = new System.Drawing.Point(16, 154);
            this.lProductYear.Name = "lProductYear";
            this.lProductYear.Size = new System.Drawing.Size(70, 13);
            this.lProductYear.TabIndex = 4;
            this.lProductYear.Text = "Product Date";
            // 
            // dtpProductYear
            // 
            this.dtpProductYear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpProductYear.Location = new System.Drawing.Point(139, 146);
            this.dtpProductYear.Name = "dtpProductYear";
            this.dtpProductYear.Size = new System.Drawing.Size(191, 20);
            this.dtpProductYear.TabIndex = 13;
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(7, 663);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(437, 213);
            this.rtbDisplay.TabIndex = 14;
            this.rtbDisplay.Text = "";
            // 
            // SpecificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(455, 1016);
            this.Controls.Add(this.rtbDisplay);
            this.Controls.Add(this.dtpProductYear);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.btDisplay);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbManual);
            this.Controls.Add(this.nudTopSpeed);
            this.Controls.Add(this.nudAcceleration);
            this.Controls.Add(this.nudEngineSize);
            this.Controls.Add(this.nudCurbWeight);
            this.Controls.Add(this.nudMaxPower);
            this.Controls.Add(this.rbAwd);
            this.Controls.Add(this.rbFiveDoors);
            this.Controls.Add(this.rbRwd);
            this.Controls.Add(this.rbFourDoor);
            this.Controls.Add(this.rbFwd);
            this.Controls.Add(this.rbTwoDoor);
            this.Controls.Add(this.ddlCarType);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbBrand);
            this.Controls.Add(this.lCurbWeight);
            this.Controls.Add(this.lNumOfDoors);
            this.Controls.Add(this.lMaxPower);
            this.Controls.Add(this.lEngineSize);
            this.Controls.Add(this.lAcceleration);
            this.Controls.Add(this.lTopSpeed);
            this.Controls.Add(this.lGearbox);
            this.Controls.Add(this.lEnginePos);
            this.Controls.Add(this.lProductYear);
            this.Controls.Add(this.lTypeOfCar);
            this.Controls.Add(this.lModel);
            this.Controls.Add(this.lBrand);
            this.Controls.Add(this.pbEngine);
            this.Controls.Add(this.pbSize);
            this.Controls.Add(this.lDisplay);
            this.Controls.Add(this.lHeaderTechnical);
            this.Controls.Add(this.lHeaderSize);
            this.Controls.Add(this.lHeaderGeneralInfo);
            this.Name = "SpecificationForm";
            this.Text = "Specifications";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEngineSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTopSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCurbWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEngine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAcceleration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lHeaderGeneralInfo;
        private System.Windows.Forms.Label lHeaderSize;
        private System.Windows.Forms.PictureBox pbSize;
        private System.Windows.Forms.PictureBox pbEngine;
        private System.Windows.Forms.Label lBrand;
        private System.Windows.Forms.Label lModel;
        private System.Windows.Forms.Label lHeaderTechnical;
        private System.Windows.Forms.Label lEnginePos;
        private System.Windows.Forms.Label lTypeOfCar;
        private System.Windows.Forms.Label lTopSpeed;
        private System.Windows.Forms.Label lNumOfDoors;
        private System.Windows.Forms.Label lAcceleration;
        private System.Windows.Forms.Label lCurbWeight;
        private System.Windows.Forms.Label lEngineSize;
        private System.Windows.Forms.Label lMaxPower;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.ComboBox ddlCarType;
        private System.Windows.Forms.RadioButton rbTwoDoor;
        private System.Windows.Forms.RadioButton rbFourDoor;
        private System.Windows.Forms.RadioButton rbFiveDoors;
        private System.Windows.Forms.NumericUpDown nudMaxPower;
        private System.Windows.Forms.NumericUpDown nudEngineSize;
        private System.Windows.Forms.NumericUpDown nudTopSpeed;
        private System.Windows.Forms.NumericUpDown nudCurbWeight;
        private System.Windows.Forms.Label lGearbox;
        private System.Windows.Forms.CheckBox cbManual;
        private System.Windows.Forms.RadioButton rbFwd;
        private System.Windows.Forms.RadioButton rbRwd;
        private System.Windows.Forms.RadioButton rbAwd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lDisplay;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btDisplay;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.NumericUpDown nudAcceleration;
        private System.Windows.Forms.Label lProductYear;
        private System.Windows.Forms.DateTimePicker dtpProductYear;
        private System.Windows.Forms.RichTextBox rtbDisplay;
    }
}

