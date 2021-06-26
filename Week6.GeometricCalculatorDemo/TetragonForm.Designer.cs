
namespace InterfacesDemo3
{
    partial class TetragonForm
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
            this.lQuestion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.rbSquare = new System.Windows.Forms.RadioButton();
            this.gbInputs = new System.Windows.Forms.GroupBox();
            this.nudLongSide = new System.Windows.Forms.NumericUpDown();
            this.nudShortSide = new System.Windows.Forms.NumericUpDown();
            this.lLongSide = new System.Windows.Forms.Label();
            this.lShortSide = new System.Windows.Forms.Label();
            this.btCalculate = new System.Windows.Forms.Button();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.tbField = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tbPerimeter = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lField = new System.Windows.Forms.Label();
            this.lPerimeter = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongSide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShortSide)).BeginInit();
            this.gbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // lQuestion
            // 
            this.lQuestion.BackColor = System.Drawing.Color.Gold;
            this.lQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQuestion.Location = new System.Drawing.Point(3, 9);
            this.lQuestion.Name = "lQuestion";
            this.lQuestion.Size = new System.Drawing.Size(372, 23);
            this.lQuestion.TabIndex = 0;
            this.lQuestion.Text = "For which tetragon do you want to calculate?";
            this.lQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbRectangle);
            this.panel1.Controls.Add(this.rbSquare);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(7, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 57);
            this.panel1.TabIndex = 1;
            // 
            // rbRectangle
            // 
            this.rbRectangle.AutoSize = true;
            this.rbRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRectangle.Location = new System.Drawing.Point(5, 30);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(90, 21);
            this.rbRectangle.TabIndex = 0;
            this.rbRectangle.TabStop = true;
            this.rbRectangle.Text = "Rectangle";
            this.rbRectangle.UseVisualStyleBackColor = true;
            this.rbRectangle.CheckedChanged += new System.EventHandler(this.rbRectangle_CheckedChanged);
            // 
            // rbSquare
            // 
            this.rbSquare.AutoSize = true;
            this.rbSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSquare.Location = new System.Drawing.Point(5, 3);
            this.rbSquare.Name = "rbSquare";
            this.rbSquare.Size = new System.Drawing.Size(72, 21);
            this.rbSquare.TabIndex = 0;
            this.rbSquare.TabStop = true;
            this.rbSquare.Text = "Square";
            this.rbSquare.UseVisualStyleBackColor = true;
            this.rbSquare.CheckedChanged += new System.EventHandler(this.rbSquare_CheckedChanged);
            // 
            // gbInputs
            // 
            this.gbInputs.Controls.Add(this.nudLongSide);
            this.gbInputs.Controls.Add(this.nudShortSide);
            this.gbInputs.Controls.Add(this.lLongSide);
            this.gbInputs.Controls.Add(this.lShortSide);
            this.gbInputs.ForeColor = System.Drawing.Color.White;
            this.gbInputs.Location = new System.Drawing.Point(7, 99);
            this.gbInputs.Name = "gbInputs";
            this.gbInputs.Size = new System.Drawing.Size(368, 92);
            this.gbInputs.TabIndex = 2;
            this.gbInputs.TabStop = false;
            this.gbInputs.Text = "Inputs";
            // 
            // nudLongSide
            // 
            this.nudLongSide.Location = new System.Drawing.Point(128, 57);
            this.nudLongSide.Name = "nudLongSide";
            this.nudLongSide.Size = new System.Drawing.Size(234, 20);
            this.nudLongSide.TabIndex = 1;
            this.nudLongSide.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudShortSide
            // 
            this.nudShortSide.Location = new System.Drawing.Point(128, 19);
            this.nudShortSide.Name = "nudShortSide";
            this.nudShortSide.Size = new System.Drawing.Size(234, 20);
            this.nudShortSide.TabIndex = 1;
            this.nudShortSide.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lLongSide
            // 
            this.lLongSide.AutoSize = true;
            this.lLongSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLongSide.Location = new System.Drawing.Point(5, 57);
            this.lLongSide.Name = "lLongSide";
            this.lLongSide.Size = new System.Drawing.Size(72, 17);
            this.lLongSide.TabIndex = 0;
            this.lLongSide.Text = "Long Side";
            // 
            // lShortSide
            // 
            this.lShortSide.AutoSize = true;
            this.lShortSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShortSide.Location = new System.Drawing.Point(3, 19);
            this.lShortSide.Name = "lShortSide";
            this.lShortSide.Size = new System.Drawing.Size(70, 17);
            this.lShortSide.TabIndex = 0;
            this.lShortSide.Text = "ShortSide";
            // 
            // btCalculate
            // 
            this.btCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalculate.Location = new System.Drawing.Point(135, 210);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(240, 37);
            this.btCalculate.TabIndex = 3;
            this.btCalculate.Text = "Calculate";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.tbField);
            this.gbResult.Controls.Add(this.textBox3);
            this.gbResult.Controls.Add(this.tbPerimeter);
            this.gbResult.Controls.Add(this.textBox2);
            this.gbResult.Controls.Add(this.textBox1);
            this.gbResult.Controls.Add(this.lField);
            this.gbResult.Controls.Add(this.lPerimeter);
            this.gbResult.ForeColor = System.Drawing.Color.White;
            this.gbResult.Location = new System.Drawing.Point(7, 264);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(368, 92);
            this.gbResult.TabIndex = 2;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Result";
            // 
            // tbField
            // 
            this.tbField.Location = new System.Drawing.Point(128, 56);
            this.tbField.Name = "tbField";
            this.tbField.Size = new System.Drawing.Size(234, 20);
            this.tbField.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(128, 56);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(234, 20);
            this.textBox3.TabIndex = 1;
            // 
            // tbPerimeter
            // 
            this.tbPerimeter.Location = new System.Drawing.Point(128, 19);
            this.tbPerimeter.Name = "tbPerimeter";
            this.tbPerimeter.Size = new System.Drawing.Size(234, 20);
            this.tbPerimeter.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(128, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(234, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lField
            // 
            this.lField.AutoSize = true;
            this.lField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lField.Location = new System.Drawing.Point(5, 57);
            this.lField.Name = "lField";
            this.lField.Size = new System.Drawing.Size(38, 17);
            this.lField.TabIndex = 0;
            this.lField.Text = "Field";
            // 
            // lPerimeter
            // 
            this.lPerimeter.AutoSize = true;
            this.lPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPerimeter.Location = new System.Drawing.Point(3, 22);
            this.lPerimeter.Name = "lPerimeter";
            this.lPerimeter.Size = new System.Drawing.Size(69, 17);
            this.lPerimeter.TabIndex = 0;
            this.lPerimeter.Text = "Perimeter";
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.Location = new System.Drawing.Point(135, 374);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(240, 37);
            this.btClear.TabIndex = 3;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // TetragonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(388, 450);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btCalculate);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.gbInputs);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lQuestion);
            this.Name = "TetragonForm";
            this.Text = "Tetragon Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbInputs.ResumeLayout(false);
            this.gbInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongSide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShortSide)).EndInit();
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lQuestion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.RadioButton rbSquare;
        private System.Windows.Forms.GroupBox gbInputs;
        private System.Windows.Forms.NumericUpDown nudLongSide;
        private System.Windows.Forms.NumericUpDown nudShortSide;
        private System.Windows.Forms.Label lLongSide;
        private System.Windows.Forms.Label lShortSide;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.TextBox tbField;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox tbPerimeter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lField;
        private System.Windows.Forms.Label lPerimeter;
        private System.Windows.Forms.Button btClear;
    }
}