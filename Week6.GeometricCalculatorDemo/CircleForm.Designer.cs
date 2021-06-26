
namespace InterfacesDemo3
{
    partial class CircleForm
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
            this.lRadius = new System.Windows.Forms.Label();
            this.nudRadius = new System.Windows.Forms.NumericUpDown();
            this.gbInputs = new System.Windows.Forms.GroupBox();
            this.btCalculate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lPerimeter = new System.Windows.Forms.Label();
            this.lField = new System.Windows.Forms.Label();
            this.lPerimeterResult = new System.Windows.Forms.Label();
            this.lFieldResult = new System.Windows.Forms.Label();
            this.btClean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius)).BeginInit();
            this.gbInputs.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lRadius
            // 
            this.lRadius.AutoSize = true;
            this.lRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRadius.Location = new System.Drawing.Point(6, 39);
            this.lRadius.Name = "lRadius";
            this.lRadius.Size = new System.Drawing.Size(52, 17);
            this.lRadius.TabIndex = 0;
            this.lRadius.Text = "Radius";
            this.lRadius.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nudRadius
            // 
            this.nudRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRadius.Location = new System.Drawing.Point(123, 37);
            this.nudRadius.Name = "nudRadius";
            this.nudRadius.Size = new System.Drawing.Size(120, 23);
            this.nudRadius.TabIndex = 1;
            // 
            // gbInputs
            // 
            this.gbInputs.Controls.Add(this.lRadius);
            this.gbInputs.Controls.Add(this.nudRadius);
            this.gbInputs.Location = new System.Drawing.Point(12, 12);
            this.gbInputs.Name = "gbInputs";
            this.gbInputs.Size = new System.Drawing.Size(249, 91);
            this.gbInputs.TabIndex = 2;
            this.gbInputs.TabStop = false;
            this.gbInputs.Text = "Input";
            // 
            // btCalculate
            // 
            this.btCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalculate.Location = new System.Drawing.Point(129, 134);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(126, 37);
            this.btCalculate.TabIndex = 3;
            this.btCalculate.Text = "Calculate";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lFieldResult);
            this.panel1.Controls.Add(this.lPerimeterResult);
            this.panel1.Controls.Add(this.lField);
            this.panel1.Controls.Add(this.lPerimeter);
            this.panel1.Location = new System.Drawing.Point(12, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 114);
            this.panel1.TabIndex = 4;
            // 
            // lPerimeter
            // 
            this.lPerimeter.AutoSize = true;
            this.lPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPerimeter.Location = new System.Drawing.Point(6, 24);
            this.lPerimeter.Name = "lPerimeter";
            this.lPerimeter.Size = new System.Drawing.Size(69, 17);
            this.lPerimeter.TabIndex = 0;
            this.lPerimeter.Text = "Perimeter";
            this.lPerimeter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lField
            // 
            this.lField.AutoSize = true;
            this.lField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lField.Location = new System.Drawing.Point(6, 65);
            this.lField.Name = "lField";
            this.lField.Size = new System.Drawing.Size(38, 17);
            this.lField.TabIndex = 0;
            this.lField.Text = "Filed";
            this.lField.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lPerimeterResult
            // 
            this.lPerimeterResult.AutoSize = true;
            this.lPerimeterResult.Location = new System.Drawing.Point(123, 24);
            this.lPerimeterResult.Name = "lPerimeterResult";
            this.lPerimeterResult.Size = new System.Drawing.Size(0, 13);
            this.lPerimeterResult.TabIndex = 1;
            // 
            // lFieldResult
            // 
            this.lFieldResult.AutoSize = true;
            this.lFieldResult.Location = new System.Drawing.Point(123, 67);
            this.lFieldResult.Name = "lFieldResult";
            this.lFieldResult.Size = new System.Drawing.Size(0, 13);
            this.lFieldResult.TabIndex = 1;
            // 
            // btClean
            // 
            this.btClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClean.Location = new System.Drawing.Point(129, 344);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(126, 37);
            this.btClean.TabIndex = 3;
            this.btClean.Text = "Clean";
            this.btClean.UseVisualStyleBackColor = true;
            this.btClean.Click += new System.EventHandler(this.btClean_Click);
            // 
            // CircleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(268, 403);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btClean);
            this.Controls.Add(this.btCalculate);
            this.Controls.Add(this.gbInputs);
            this.Name = "CircleForm";
            this.Text = "CircleForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius)).EndInit();
            this.gbInputs.ResumeLayout(false);
            this.gbInputs.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lRadius;
        private System.Windows.Forms.NumericUpDown nudRadius;
        private System.Windows.Forms.GroupBox gbInputs;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lFieldResult;
        private System.Windows.Forms.Label lPerimeterResult;
        private System.Windows.Forms.Label lField;
        private System.Windows.Forms.Label lPerimeter;
        private System.Windows.Forms.Button btClean;
    }
}