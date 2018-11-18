namespace Fractions
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OutputTB = new System.Windows.Forms.TextBox();
            this.VisualizationLB = new System.Windows.Forms.Label();
            this.ErrorLB = new System.Windows.Forms.Label();
            this.IsMixedFractionCB = new System.Windows.Forms.CheckBox();
            this.CountNUD = new System.Windows.Forms.NumericUpDown();
            this.NumberTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CountNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Count";
            // 
            // OutputTB
            // 
            this.OutputTB.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputTB.Location = new System.Drawing.Point(12, 55);
            this.OutputTB.Name = "OutputTB";
            this.OutputTB.ReadOnly = true;
            this.OutputTB.Size = new System.Drawing.Size(350, 24);
            this.OutputTB.TabIndex = 4;
            // 
            // VisualizationLB
            // 
            this.VisualizationLB.AutoSize = true;
            this.VisualizationLB.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisualizationLB.Location = new System.Drawing.Point(11, 71);
            this.VisualizationLB.Name = "VisualizationLB";
            this.VisualizationLB.Size = new System.Drawing.Size(18, 32);
            this.VisualizationLB.TabIndex = 5;
            this.VisualizationLB.Text = "_\r\n0";
            this.VisualizationLB.Click += new System.EventHandler(this.VisualizationLB_Click);
            // 
            // ErrorLB
            // 
            this.ErrorLB.AutoSize = true;
            this.ErrorLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLB.ForeColor = System.Drawing.Color.Red;
            this.ErrorLB.Location = new System.Drawing.Point(8, 79);
            this.ErrorLB.MaximumSize = new System.Drawing.Size(415, 0);
            this.ErrorLB.Name = "ErrorLB";
            this.ErrorLB.Size = new System.Drawing.Size(34, 13);
            this.ErrorLB.TabIndex = 6;
            this.ErrorLB.Text = "Error";
            // 
            // IsMixedFractionCB
            // 
            this.IsMixedFractionCB.AutoSize = true;
            this.IsMixedFractionCB.Checked = true;
            this.IsMixedFractionCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsMixedFractionCB.Location = new System.Drawing.Point(368, 60);
            this.IsMixedFractionCB.Name = "IsMixedFractionCB";
            this.IsMixedFractionCB.Size = new System.Drawing.Size(54, 17);
            this.IsMixedFractionCB.TabIndex = 9;
            this.IsMixedFractionCB.Text = "Mixed";
            this.IsMixedFractionCB.UseVisualStyleBackColor = true;
            this.IsMixedFractionCB.CheckedChanged += new System.EventHandler(this.IsMixedFractionCB_CheckedChanged);
            // 
            // CountNUD
            // 
            this.CountNUD.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountNUD.Location = new System.Drawing.Point(368, 25);
            this.CountNUD.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.CountNUD.Name = "CountNUD";
            this.CountNUD.Size = new System.Drawing.Size(48, 24);
            this.CountNUD.TabIndex = 2;
            this.CountNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CountNUD.ValueChanged += new System.EventHandler(this.CountNUD_ValueChanged);
            // 
            // NumberTB
            // 
            this.NumberTB.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberTB.Location = new System.Drawing.Point(12, 25);
            this.NumberTB.MaxLength = 34;
            this.NumberTB.Name = "NumberTB";
            this.NumberTB.Size = new System.Drawing.Size(350, 24);
            this.NumberTB.TabIndex = 1;
            this.NumberTB.TextChanged += new System.EventHandler(this.NumberTB_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 108);
            this.Controls.Add(this.NumberTB);
            this.Controls.Add(this.CountNUD);
            this.Controls.Add(this.IsMixedFractionCB);
            this.Controls.Add(this.OutputTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VisualizationLB);
            this.Controls.Add(this.ErrorLB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Decimal to Fraction Converter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CountNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OutputTB;
        private System.Windows.Forms.Label VisualizationLB;
        private System.Windows.Forms.Label ErrorLB;
        private System.Windows.Forms.CheckBox IsMixedFractionCB;
        private System.Windows.Forms.NumericUpDown CountNUD;
        private System.Windows.Forms.TextBox NumberTB;
    }
}

