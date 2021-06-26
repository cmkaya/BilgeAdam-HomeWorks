
namespace InterfacesDemo3
{
    partial class TrianglesForm
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
            this.lInfo = new System.Windows.Forms.Label();
            this.rbStraightTriangle = new System.Windows.Forms.RadioButton();
            this.rbEquilateralTriangle = new System.Windows.Forms.RadioButton();
            this.lFirstEdge = new System.Windows.Forms.Label();
            this.nudFirstEdge = new System.Windows.Forms.NumericUpDown();
            this.lSeconEdge = new System.Windows.Forms.Label();
            this.nudSecondEdge = new System.Windows.Forms.NumericUpDown();
            this.lPerimeterResult = new System.Windows.Forms.Label();
            this.nudThirdEdge = new System.Windows.Forms.NumericUpDown();
            this.btCalculate = new System.Windows.Forms.Button();
            this.lThirdEdge = new System.Windows.Forms.Label();
            this.lFieldResult = new System.Windows.Forms.Label();
            this.tbPerimeterResult = new System.Windows.Forms.TextBox();
            this.tbFieldResult = new System.Windows.Forms.TextBox();
            this.gbEdges = new System.Windows.Forms.GroupBox();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.pTriangleSelect = new System.Windows.Forms.Panel();
            this.btClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudFirstEdge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecondEdge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThirdEdge)).BeginInit();
            this.gbEdges.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.pTriangleSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // lInfo
            // 
            this.lInfo.AutoSize = true;
            this.lInfo.BackColor = System.Drawing.Color.Red;
            this.lInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lInfo.ForeColor = System.Drawing.Color.White;
            this.lInfo.Location = new System.Drawing.Point(13, 13);
            this.lInfo.Name = "lInfo";
            this.lInfo.Size = new System.Drawing.Size(360, 20);
            this.lInfo.TabIndex = 0;
            this.lInfo.Text = "For which triangle do you want to calculate?";
            // 
            // rbStraightTriangle
            // 
            this.rbStraightTriangle.AutoSize = true;
            this.rbStraightTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStraightTriangle.Location = new System.Drawing.Point(5, 3);
            this.rbStraightTriangle.Name = "rbStraightTriangle";
            this.rbStraightTriangle.Size = new System.Drawing.Size(129, 21);
            this.rbStraightTriangle.TabIndex = 1;
            this.rbStraightTriangle.TabStop = true;
            this.rbStraightTriangle.Text = "Straight Triangle";
            this.rbStraightTriangle.UseVisualStyleBackColor = true;
            this.rbStraightTriangle.CheckedChanged += new System.EventHandler(this.rbStraightTriangle_CheckedChanged);
            // 
            // rbEquilateralTriangle
            // 
            this.rbEquilateralTriangle.AutoSize = true;
            this.rbEquilateralTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEquilateralTriangle.Location = new System.Drawing.Point(178, 3);
            this.rbEquilateralTriangle.Name = "rbEquilateralTriangle";
            this.rbEquilateralTriangle.Size = new System.Drawing.Size(169, 21);
            this.rbEquilateralTriangle.TabIndex = 1;
            this.rbEquilateralTriangle.TabStop = true;
            this.rbEquilateralTriangle.Text = "Equilateral Triangle";
            this.rbEquilateralTriangle.UseVisualStyleBackColor = true;
            this.rbEquilateralTriangle.CheckedChanged += new System.EventHandler(this.rbEquilateralTriangle_CheckedChanged);
            // 
            // lFirstEdge
            // 
            this.lFirstEdge.AutoSize = true;
            this.lFirstEdge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFirstEdge.Location = new System.Drawing.Point(6, 37);
            this.lFirstEdge.Name = "lFirstEdge";
            this.lFirstEdge.Size = new System.Drawing.Size(92, 20);
            this.lFirstEdge.TabIndex = 2;
            this.lFirstEdge.Text = "First Edge";
            // 
            // nudFirstEdge
            // 
            this.nudFirstEdge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudFirstEdge.Location = new System.Drawing.Point(192, 33);
            this.nudFirstEdge.Name = "nudFirstEdge";
            this.nudFirstEdge.Size = new System.Drawing.Size(124, 24);
            this.nudFirstEdge.TabIndex = 3;
            this.nudFirstEdge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lSeconEdge
            // 
            this.lSeconEdge.AutoSize = true;
            this.lSeconEdge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSeconEdge.Location = new System.Drawing.Point(6, 82);
            this.lSeconEdge.Name = "lSeconEdge";
            this.lSeconEdge.Size = new System.Drawing.Size(117, 20);
            this.lSeconEdge.TabIndex = 2;
            this.lSeconEdge.Text = "Second Edge";
            // 
            // nudSecondEdge
            // 
            this.nudSecondEdge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSecondEdge.Location = new System.Drawing.Point(192, 78);
            this.nudSecondEdge.Name = "nudSecondEdge";
            this.nudSecondEdge.Size = new System.Drawing.Size(124, 24);
            this.nudSecondEdge.TabIndex = 3;
            this.nudSecondEdge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lPerimeterResult
            // 
            this.lPerimeterResult.AutoSize = true;
            this.lPerimeterResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPerimeterResult.Location = new System.Drawing.Point(6, 38);
            this.lPerimeterResult.Name = "lPerimeterResult";
            this.lPerimeterResult.Size = new System.Drawing.Size(86, 20);
            this.lPerimeterResult.TabIndex = 2;
            this.lPerimeterResult.Text = "Perimeter";
            // 
            // nudThirdEdge
            // 
            this.nudThirdEdge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudThirdEdge.Location = new System.Drawing.Point(192, 124);
            this.nudThirdEdge.Name = "nudThirdEdge";
            this.nudThirdEdge.Size = new System.Drawing.Size(124, 24);
            this.nudThirdEdge.TabIndex = 3;
            this.nudThirdEdge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btCalculate
            // 
            this.btCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalculate.Location = new System.Drawing.Point(226, 274);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(143, 32);
            this.btCalculate.TabIndex = 4;
            this.btCalculate.Text = "Calculate";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // lThirdEdge
            // 
            this.lThirdEdge.AutoSize = true;
            this.lThirdEdge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lThirdEdge.Location = new System.Drawing.Point(2, 128);
            this.lThirdEdge.Name = "lThirdEdge";
            this.lThirdEdge.Size = new System.Drawing.Size(154, 20);
            this.lThirdEdge.TabIndex = 2;
            this.lThirdEdge.Text = "Third (Base) Edge";
            // 
            // lFieldResult
            // 
            this.lFieldResult.AutoSize = true;
            this.lFieldResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFieldResult.Location = new System.Drawing.Point(6, 92);
            this.lFieldResult.Name = "lFieldResult";
            this.lFieldResult.Size = new System.Drawing.Size(48, 20);
            this.lFieldResult.TabIndex = 2;
            this.lFieldResult.Text = "Field";
            // 
            // tbPerimeterResult
            // 
            this.tbPerimeterResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPerimeterResult.Location = new System.Drawing.Point(192, 34);
            this.tbPerimeterResult.Name = "tbPerimeterResult";
            this.tbPerimeterResult.Size = new System.Drawing.Size(124, 24);
            this.tbPerimeterResult.TabIndex = 5;
            // 
            // tbFieldResult
            // 
            this.tbFieldResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFieldResult.Location = new System.Drawing.Point(192, 92);
            this.tbFieldResult.Name = "tbFieldResult";
            this.tbFieldResult.Size = new System.Drawing.Size(123, 24);
            this.tbFieldResult.TabIndex = 5;
            // 
            // gbEdges
            // 
            this.gbEdges.BackColor = System.Drawing.Color.LightGreen;
            this.gbEdges.Controls.Add(this.lFirstEdge);
            this.gbEdges.Controls.Add(this.lSeconEdge);
            this.gbEdges.Controls.Add(this.lThirdEdge);
            this.gbEdges.Controls.Add(this.nudFirstEdge);
            this.gbEdges.Controls.Add(this.nudThirdEdge);
            this.gbEdges.Controls.Add(this.nudSecondEdge);
            this.gbEdges.Location = new System.Drawing.Point(12, 87);
            this.gbEdges.Name = "gbEdges";
            this.gbEdges.Size = new System.Drawing.Size(360, 181);
            this.gbEdges.TabIndex = 6;
            this.gbEdges.TabStop = false;
            this.gbEdges.Text = "Triangle Edges";
            // 
            // gbResult
            // 
            this.gbResult.BackColor = System.Drawing.Color.Tomato;
            this.gbResult.Controls.Add(this.lPerimeterResult);
            this.gbResult.Controls.Add(this.lFieldResult);
            this.gbResult.Controls.Add(this.tbFieldResult);
            this.gbResult.Controls.Add(this.tbPerimeterResult);
            this.gbResult.Location = new System.Drawing.Point(12, 312);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(361, 141);
            this.gbResult.TabIndex = 7;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Result";
            // 
            // pTriangleSelect
            // 
            this.pTriangleSelect.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pTriangleSelect.Controls.Add(this.rbEquilateralTriangle);
            this.pTriangleSelect.Controls.Add(this.rbStraightTriangle);
            this.pTriangleSelect.Location = new System.Drawing.Point(12, 44);
            this.pTriangleSelect.Name = "pTriangleSelect";
            this.pTriangleSelect.Size = new System.Drawing.Size(360, 26);
            this.pTriangleSelect.TabIndex = 8;
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.Location = new System.Drawing.Point(229, 468);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(143, 32);
            this.btClear.TabIndex = 4;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // TrianglesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 514);
            this.Controls.Add(this.pTriangleSelect);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.gbEdges);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btCalculate);
            this.Controls.Add(this.lInfo);
            this.Name = "TrianglesForm";
            this.Text = "TrianglesForm";
            this.Load += new System.EventHandler(this.TrianglesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFirstEdge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecondEdge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThirdEdge)).EndInit();
            this.gbEdges.ResumeLayout(false);
            this.gbEdges.PerformLayout();
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.pTriangleSelect.ResumeLayout(false);
            this.pTriangleSelect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lInfo;
        private System.Windows.Forms.RadioButton rbStraightTriangle;
        private System.Windows.Forms.RadioButton rbEquilateralTriangle;
        private System.Windows.Forms.Label lFirstEdge;
        private System.Windows.Forms.NumericUpDown nudFirstEdge;
        private System.Windows.Forms.Label lSeconEdge;
        private System.Windows.Forms.NumericUpDown nudSecondEdge;
        private System.Windows.Forms.Label lPerimeterResult;
        private System.Windows.Forms.NumericUpDown nudThirdEdge;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.Label lThirdEdge;
        private System.Windows.Forms.Label lFieldResult;
        private System.Windows.Forms.TextBox tbPerimeterResult;
        private System.Windows.Forms.TextBox tbFieldResult;
        private System.Windows.Forms.GroupBox gbEdges;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.Panel pTriangleSelect;
        private System.Windows.Forms.Button btClear;
    }
}