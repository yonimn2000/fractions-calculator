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
            this.components = new System.ComponentModel.Container();
            this.VisualizationLB = new System.Windows.Forms.Label();
            this.ErrorLB = new System.Windows.Forms.Label();
            this.IsMixedFractionCB = new System.Windows.Forms.CheckBox();
            this.CountNUD = new System.Windows.Forms.NumericUpDown();
            this.DecimalNumberTB = new System.Windows.Forms.TextBox();
            this.DecimalToFractionGB = new System.Windows.Forms.GroupBox();
            this.MainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.FractionSimplifierGB = new System.Windows.Forms.GroupBox();
            this.WholePartFractionInTB = new System.Windows.Forms.TextBox();
            this.DenominatorInTB = new System.Windows.Forms.TextBox();
            this.NumeratorInTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OutputGB = new System.Windows.Forms.GroupBox();
            this.WholePartFractionOutTB = new System.Windows.Forms.TextBox();
            this.DenominatorOutTB = new System.Windows.Forms.TextBox();
            this.NumeratorOutTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DecimalToFractionRB = new System.Windows.Forms.RadioButton();
            this.FractionSimplifierRB = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.CountNUD)).BeginInit();
            this.DecimalToFractionGB.SuspendLayout();
            this.FractionSimplifierGB.SuspendLayout();
            this.OutputGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // VisualizationLB
            // 
            this.VisualizationLB.AutoSize = true;
            this.VisualizationLB.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisualizationLB.Location = new System.Drawing.Point(4, 56);
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
            this.ErrorLB.Location = new System.Drawing.Point(3, 65);
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
            this.IsMixedFractionCB.Location = new System.Drawing.Point(366, 71);
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
            this.CountNUD.Location = new System.Drawing.Point(366, 19);
            this.CountNUD.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.CountNUD.Name = "CountNUD";
            this.CountNUD.Size = new System.Drawing.Size(48, 24);
            this.CountNUD.TabIndex = 2;
            this.CountNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MainToolTip.SetToolTip(this.CountNUD, "Count of repeating decimals");
            this.CountNUD.ValueChanged += new System.EventHandler(this.CountNUD_ValueChanged);
            // 
            // DecimalNumberTB
            // 
            this.DecimalNumberTB.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecimalNumberTB.Location = new System.Drawing.Point(6, 19);
            this.DecimalNumberTB.MaxLength = 34;
            this.DecimalNumberTB.Name = "DecimalNumberTB";
            this.DecimalNumberTB.Size = new System.Drawing.Size(354, 24);
            this.DecimalNumberTB.TabIndex = 1;
            this.MainToolTip.SetToolTip(this.DecimalNumberTB, "A decimal number");
            this.DecimalNumberTB.TextChanged += new System.EventHandler(this.NumberTB_TextChanged);
            // 
            // DecimalToFractionGB
            // 
            this.DecimalToFractionGB.Controls.Add(this.DecimalNumberTB);
            this.DecimalToFractionGB.Controls.Add(this.CountNUD);
            this.DecimalToFractionGB.Location = new System.Drawing.Point(25, 12);
            this.DecimalToFractionGB.Name = "DecimalToFractionGB";
            this.DecimalToFractionGB.Size = new System.Drawing.Size(423, 52);
            this.DecimalToFractionGB.TabIndex = 10;
            this.DecimalToFractionGB.TabStop = false;
            this.DecimalToFractionGB.Text = "Decimal to Fraction";
            // 
            // FractionSimplifierGB
            // 
            this.FractionSimplifierGB.Controls.Add(this.WholePartFractionInTB);
            this.FractionSimplifierGB.Controls.Add(this.DenominatorInTB);
            this.FractionSimplifierGB.Controls.Add(this.NumeratorInTB);
            this.FractionSimplifierGB.Controls.Add(this.label1);
            this.FractionSimplifierGB.Enabled = false;
            this.FractionSimplifierGB.Location = new System.Drawing.Point(25, 70);
            this.FractionSimplifierGB.Name = "FractionSimplifierGB";
            this.FractionSimplifierGB.Size = new System.Drawing.Size(423, 74);
            this.FractionSimplifierGB.TabIndex = 11;
            this.FractionSimplifierGB.TabStop = false;
            this.FractionSimplifierGB.Text = "Fraction Simplifier";
            // 
            // WholePartFractionInTB
            // 
            this.WholePartFractionInTB.Font = new System.Drawing.Font("Miriam Fixed", 20F);
            this.WholePartFractionInTB.Location = new System.Drawing.Point(8, 22);
            this.WholePartFractionInTB.MaxLength = 20;
            this.WholePartFractionInTB.Name = "WholePartFractionInTB";
            this.WholePartFractionInTB.Size = new System.Drawing.Size(200, 34);
            this.WholePartFractionInTB.TabIndex = 2;
            this.WholePartFractionInTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.WholePartFractionInTB.TextChanged += new System.EventHandler(this.WholePartFractionInTB_TextChanged);
            // 
            // DenominatorInTB
            // 
            this.DenominatorInTB.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DenominatorInTB.Location = new System.Drawing.Point(214, 43);
            this.DenominatorInTB.MaxLength = 20;
            this.DenominatorInTB.Name = "DenominatorInTB";
            this.DenominatorInTB.Size = new System.Drawing.Size(200, 24);
            this.DenominatorInTB.TabIndex = 0;
            this.DenominatorInTB.TextChanged += new System.EventHandler(this.DenominatorInTB_TextChanged);
            // 
            // NumeratorInTB
            // 
            this.NumeratorInTB.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeratorInTB.Location = new System.Drawing.Point(214, 13);
            this.NumeratorInTB.MaxLength = 20;
            this.NumeratorInTB.Name = "NumeratorInTB";
            this.NumeratorInTB.Size = new System.Drawing.Size(200, 24);
            this.NumeratorInTB.TabIndex = 0;
            this.NumeratorInTB.TextChanged += new System.EventHandler(this.NumeratorInTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Miriam Fixed", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(214, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "___________";
            // 
            // OutputGB
            // 
            this.OutputGB.Controls.Add(this.WholePartFractionOutTB);
            this.OutputGB.Controls.Add(this.DenominatorOutTB);
            this.OutputGB.Controls.Add(this.NumeratorOutTB);
            this.OutputGB.Controls.Add(this.IsMixedFractionCB);
            this.OutputGB.Controls.Add(this.label2);
            this.OutputGB.Controls.Add(this.VisualizationLB);
            this.OutputGB.Controls.Add(this.ErrorLB);
            this.OutputGB.Location = new System.Drawing.Point(25, 150);
            this.OutputGB.Name = "OutputGB";
            this.OutputGB.Size = new System.Drawing.Size(423, 97);
            this.OutputGB.TabIndex = 12;
            this.OutputGB.TabStop = false;
            this.OutputGB.Text = "Fraction Simplifier";
            // 
            // WholePartFractionOutTB
            // 
            this.WholePartFractionOutTB.Font = new System.Drawing.Font("Miriam Fixed", 20F);
            this.WholePartFractionOutTB.Location = new System.Drawing.Point(8, 19);
            this.WholePartFractionOutTB.MaxLength = 17;
            this.WholePartFractionOutTB.Name = "WholePartFractionOutTB";
            this.WholePartFractionOutTB.ReadOnly = true;
            this.WholePartFractionOutTB.Size = new System.Drawing.Size(200, 34);
            this.WholePartFractionOutTB.TabIndex = 2;
            this.WholePartFractionOutTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DenominatorOutTB
            // 
            this.DenominatorOutTB.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DenominatorOutTB.Location = new System.Drawing.Point(214, 39);
            this.DenominatorOutTB.MaxLength = 100;
            this.DenominatorOutTB.Name = "DenominatorOutTB";
            this.DenominatorOutTB.ReadOnly = true;
            this.DenominatorOutTB.Size = new System.Drawing.Size(200, 24);
            this.DenominatorOutTB.TabIndex = 0;
            // 
            // NumeratorOutTB
            // 
            this.NumeratorOutTB.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeratorOutTB.Location = new System.Drawing.Point(214, 9);
            this.NumeratorOutTB.MaxLength = 100;
            this.NumeratorOutTB.Name = "NumeratorOutTB";
            this.NumeratorOutTB.ReadOnly = true;
            this.NumeratorOutTB.Size = new System.Drawing.Size(200, 24);
            this.NumeratorOutTB.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Miriam Fixed", 20F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(214, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "___________";
            // 
            // DecimalToFractionRB
            // 
            this.DecimalToFractionRB.AutoSize = true;
            this.DecimalToFractionRB.Checked = true;
            this.DecimalToFractionRB.Location = new System.Drawing.Point(5, 35);
            this.DecimalToFractionRB.Name = "DecimalToFractionRB";
            this.DecimalToFractionRB.Size = new System.Drawing.Size(14, 13);
            this.DecimalToFractionRB.TabIndex = 13;
            this.DecimalToFractionRB.UseVisualStyleBackColor = true;
            this.DecimalToFractionRB.CheckedChanged += new System.EventHandler(this.DecimalToFractionRB_CheckedChanged);
            // 
            // FractionSimplifierRB
            // 
            this.FractionSimplifierRB.AutoSize = true;
            this.FractionSimplifierRB.Location = new System.Drawing.Point(5, 104);
            this.FractionSimplifierRB.Name = "FractionSimplifierRB";
            this.FractionSimplifierRB.Size = new System.Drawing.Size(14, 13);
            this.FractionSimplifierRB.TabIndex = 13;
            this.FractionSimplifierRB.UseVisualStyleBackColor = true;
            this.FractionSimplifierRB.CheckedChanged += new System.EventHandler(this.FractionSimplifierRB_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 257);
            this.Controls.Add(this.FractionSimplifierRB);
            this.Controls.Add(this.DecimalToFractionRB);
            this.Controls.Add(this.FractionSimplifierGB);
            this.Controls.Add(this.OutputGB);
            this.Controls.Add(this.DecimalToFractionGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Fraction Tools";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CountNUD)).EndInit();
            this.DecimalToFractionGB.ResumeLayout(false);
            this.DecimalToFractionGB.PerformLayout();
            this.FractionSimplifierGB.ResumeLayout(false);
            this.FractionSimplifierGB.PerformLayout();
            this.OutputGB.ResumeLayout(false);
            this.OutputGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label VisualizationLB;
        private System.Windows.Forms.Label ErrorLB;
        private System.Windows.Forms.CheckBox IsMixedFractionCB;
        private System.Windows.Forms.NumericUpDown CountNUD;
        private System.Windows.Forms.TextBox DecimalNumberTB;
        private System.Windows.Forms.ToolTip MainToolTip;
        private System.Windows.Forms.GroupBox DecimalToFractionGB;
        private System.Windows.Forms.GroupBox FractionSimplifierGB;
        private System.Windows.Forms.TextBox NumeratorInTB;
        private System.Windows.Forms.TextBox WholePartFractionInTB;
        private System.Windows.Forms.TextBox DenominatorInTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox OutputGB;
        private System.Windows.Forms.TextBox WholePartFractionOutTB;
        private System.Windows.Forms.TextBox DenominatorOutTB;
        private System.Windows.Forms.TextBox NumeratorOutTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton DecimalToFractionRB;
        private System.Windows.Forms.RadioButton FractionSimplifierRB;
    }
}

