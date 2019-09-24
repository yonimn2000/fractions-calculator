namespace YonatanMankovich.FractionsCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.VisualizationLB = new System.Windows.Forms.Label();
            this.IsMixedResultFractionCB = new System.Windows.Forms.CheckBox();
            this.CountNUD = new System.Windows.Forms.NumericUpDown();
            this.DecimalNumberTB = new System.Windows.Forms.TextBox();
            this.DecimalToFractionGB = new System.Windows.Forms.GroupBox();
            this.MainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.FractionSimplifierGB = new System.Windows.Forms.GroupBox();
            this.simplifierFB = new YonatanMankovich.FractionsCalculator.FractionBox();
            this.resultGB = new System.Windows.Forms.GroupBox();
            this.resultFB = new YonatanMankovich.FractionsCalculator.FractionBox();
            this.DecimalToFractionRB = new System.Windows.Forms.RadioButton();
            this.FractionSimplifierRB = new System.Windows.Forms.RadioButton();
            this.fractionMathGB = new System.Windows.Forms.GroupBox();
            this.fractionComparisonLBL = new System.Windows.Forms.Label();
            this.mathOperatorCB = new System.Windows.Forms.ComboBox();
            this.math2FB = new YonatanMankovich.FractionsCalculator.FractionBox();
            this.math1FB = new YonatanMankovich.FractionsCalculator.FractionBox();
            this.fractionMathRB = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.CountNUD)).BeginInit();
            this.DecimalToFractionGB.SuspendLayout();
            this.FractionSimplifierGB.SuspendLayout();
            this.resultGB.SuspendLayout();
            this.fractionMathGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // VisualizationLB
            // 
            this.VisualizationLB.AutoSize = true;
            this.VisualizationLB.BackColor = System.Drawing.Color.Transparent;
            this.VisualizationLB.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisualizationLB.Location = new System.Drawing.Point(3, 71);
            this.VisualizationLB.Name = "VisualizationLB";
            this.VisualizationLB.Size = new System.Drawing.Size(18, 32);
            this.VisualizationLB.TabIndex = 1;
            this.VisualizationLB.Text = "_\r\n0";
            this.VisualizationLB.Click += new System.EventHandler(this.VisualizationLB_Click);
            // 
            // IsMixedResultFractionCB
            // 
            this.IsMixedResultFractionCB.AutoSize = true;
            this.IsMixedResultFractionCB.Checked = true;
            this.IsMixedResultFractionCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsMixedResultFractionCB.Enabled = false;
            this.IsMixedResultFractionCB.Location = new System.Drawing.Point(364, 86);
            this.IsMixedResultFractionCB.Name = "IsMixedResultFractionCB";
            this.IsMixedResultFractionCB.Size = new System.Drawing.Size(54, 17);
            this.IsMixedResultFractionCB.TabIndex = 0;
            this.IsMixedResultFractionCB.Text = "Mixed";
            this.IsMixedResultFractionCB.UseVisualStyleBackColor = true;
            this.IsMixedResultFractionCB.CheckedChanged += new System.EventHandler(this.RequestCalculation);
            // 
            // CountNUD
            // 
            this.CountNUD.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountNUD.Location = new System.Drawing.Point(364, 19);
            this.CountNUD.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.CountNUD.Name = "CountNUD";
            this.CountNUD.Size = new System.Drawing.Size(48, 24);
            this.CountNUD.TabIndex = 1;
            this.CountNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MainToolTip.SetToolTip(this.CountNUD, "Count of repeating decimals");
            this.CountNUD.ValueChanged += new System.EventHandler(this.RequestCalculation);
            // 
            // DecimalNumberTB
            // 
            this.DecimalNumberTB.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecimalNumberTB.Location = new System.Drawing.Point(6, 19);
            this.DecimalNumberTB.MaxLength = 34;
            this.DecimalNumberTB.Name = "DecimalNumberTB";
            this.DecimalNumberTB.Size = new System.Drawing.Size(352, 24);
            this.DecimalNumberTB.TabIndex = 0;
            this.MainToolTip.SetToolTip(this.DecimalNumberTB, "A decimal number");
            this.DecimalNumberTB.TextChanged += new System.EventHandler(this.RequestCalculation);
            // 
            // DecimalToFractionGB
            // 
            this.DecimalToFractionGB.Controls.Add(this.DecimalNumberTB);
            this.DecimalToFractionGB.Controls.Add(this.CountNUD);
            this.DecimalToFractionGB.Enabled = false;
            this.DecimalToFractionGB.Location = new System.Drawing.Point(15, 298);
            this.DecimalToFractionGB.Name = "DecimalToFractionGB";
            this.DecimalToFractionGB.Size = new System.Drawing.Size(418, 52);
            this.DecimalToFractionGB.TabIndex = 4;
            this.DecimalToFractionGB.TabStop = false;
            this.DecimalToFractionGB.Text = "Decimal to Fraction";
            // 
            // FractionSimplifierGB
            // 
            this.FractionSimplifierGB.Controls.Add(this.simplifierFB);
            this.FractionSimplifierGB.Enabled = false;
            this.FractionSimplifierGB.Location = new System.Drawing.Point(15, 209);
            this.FractionSimplifierGB.Name = "FractionSimplifierGB";
            this.FractionSimplifierGB.Size = new System.Drawing.Size(418, 83);
            this.FractionSimplifierGB.TabIndex = 3;
            this.FractionSimplifierGB.TabStop = false;
            this.FractionSimplifierGB.Text = "Fraction Simplifier";
            // 
            // simplifierFB
            // 
            this.simplifierFB.BackColor = System.Drawing.Color.Transparent;
            this.simplifierFB.IsMixed = true;
            this.simplifierFB.Location = new System.Drawing.Point(6, 19);
            this.simplifierFB.MinimumSize = new System.Drawing.Size(100, 61);
            this.simplifierFB.Name = "simplifierFB";
            this.simplifierFB.ReadOnly = false;
            this.simplifierFB.Size = new System.Drawing.Size(408, 61);
            this.simplifierFB.TabIndex = 0;
            this.simplifierFB.ValueChanged += new System.EventHandler(this.RequestCalculation);
            // 
            // resultGB
            // 
            this.resultGB.Controls.Add(this.IsMixedResultFractionCB);
            this.resultGB.Controls.Add(this.resultFB);
            this.resultGB.Controls.Add(this.VisualizationLB);
            this.resultGB.Location = new System.Drawing.Point(15, 356);
            this.resultGB.Name = "resultGB";
            this.resultGB.Size = new System.Drawing.Size(418, 107);
            this.resultGB.TabIndex = 5;
            this.resultGB.TabStop = false;
            this.resultGB.Text = "Result";
            // 
            // resultFB
            // 
            this.resultFB.BackColor = System.Drawing.Color.Red;
            this.resultFB.IsMixed = true;
            this.resultFB.Location = new System.Drawing.Point(6, 19);
            this.resultFB.MinimumSize = new System.Drawing.Size(100, 61);
            this.resultFB.Name = "resultFB";
            this.resultFB.ReadOnly = true;
            this.resultFB.Size = new System.Drawing.Size(408, 61);
            this.resultFB.TabIndex = 2;
            // 
            // DecimalToFractionRB
            // 
            this.DecimalToFractionRB.AutoSize = true;
            this.DecimalToFractionRB.Location = new System.Drawing.Point(2, 298);
            this.DecimalToFractionRB.Name = "DecimalToFractionRB";
            this.DecimalToFractionRB.Size = new System.Drawing.Size(14, 13);
            this.DecimalToFractionRB.TabIndex = 0;
            this.DecimalToFractionRB.UseVisualStyleBackColor = true;
            this.DecimalToFractionRB.CheckedChanged += new System.EventHandler(this.RadioButton_CheckChanged);
            // 
            // FractionSimplifierRB
            // 
            this.FractionSimplifierRB.AutoSize = true;
            this.FractionSimplifierRB.Location = new System.Drawing.Point(2, 209);
            this.FractionSimplifierRB.Name = "FractionSimplifierRB";
            this.FractionSimplifierRB.Size = new System.Drawing.Size(14, 13);
            this.FractionSimplifierRB.TabIndex = 2;
            this.FractionSimplifierRB.UseVisualStyleBackColor = true;
            this.FractionSimplifierRB.CheckedChanged += new System.EventHandler(this.RadioButton_CheckChanged);
            // 
            // fractionMathGB
            // 
            this.fractionMathGB.Controls.Add(this.fractionComparisonLBL);
            this.fractionMathGB.Controls.Add(this.mathOperatorCB);
            this.fractionMathGB.Controls.Add(this.math2FB);
            this.fractionMathGB.Controls.Add(this.math1FB);
            this.fractionMathGB.Location = new System.Drawing.Point(15, 12);
            this.fractionMathGB.Name = "fractionMathGB";
            this.fractionMathGB.Size = new System.Drawing.Size(418, 191);
            this.fractionMathGB.TabIndex = 1;
            this.fractionMathGB.TabStop = false;
            this.fractionMathGB.Text = "Fraction Math";
            // 
            // fractionComparisonLBL
            // 
            this.fractionComparisonLBL.AutoSize = true;
            this.fractionComparisonLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fractionComparisonLBL.Location = new System.Drawing.Point(289, 89);
            this.fractionComparisonLBL.Name = "fractionComparisonLBL";
            this.fractionComparisonLBL.Size = new System.Drawing.Size(123, 24);
            this.fractionComparisonLBL.TabIndex = 3;
            this.fractionComparisonLBL.Text = "Top = Bottom";
            // 
            // mathOperatorCB
            // 
            this.mathOperatorCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mathOperatorCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mathOperatorCB.FormattingEnabled = true;
            this.mathOperatorCB.Items.AddRange(new object[] {
            "+",
            "-",
            "x",
            ":"});
            this.mathOperatorCB.Location = new System.Drawing.Point(189, 86);
            this.mathOperatorCB.Name = "mathOperatorCB";
            this.mathOperatorCB.Size = new System.Drawing.Size(44, 32);
            this.mathOperatorCB.TabIndex = 1;
            this.mathOperatorCB.SelectedIndexChanged += new System.EventHandler(this.RequestCalculation);
            // 
            // math2FB
            // 
            this.math2FB.BackColor = System.Drawing.Color.Transparent;
            this.math2FB.IsMixed = true;
            this.math2FB.Location = new System.Drawing.Point(6, 124);
            this.math2FB.MinimumSize = new System.Drawing.Size(100, 61);
            this.math2FB.Name = "math2FB";
            this.math2FB.ReadOnly = false;
            this.math2FB.Size = new System.Drawing.Size(408, 61);
            this.math2FB.TabIndex = 2;
            this.math2FB.ValueChanged += new System.EventHandler(this.RequestCalculation);
            this.math2FB.ExceptionOccurred += new System.EventHandler<YonatanMankovich.FractionsCalculator.ExceptionOccurredEventArgs>(this.SimplifierFB_ExceptionOccurred);
            // 
            // math1FB
            // 
            this.math1FB.BackColor = System.Drawing.Color.Transparent;
            this.math1FB.IsMixed = true;
            this.math1FB.Location = new System.Drawing.Point(6, 19);
            this.math1FB.MinimumSize = new System.Drawing.Size(100, 61);
            this.math1FB.Name = "math1FB";
            this.math1FB.ReadOnly = false;
            this.math1FB.Size = new System.Drawing.Size(408, 61);
            this.math1FB.TabIndex = 0;
            this.math1FB.ValueChanged += new System.EventHandler(this.RequestCalculation);
            this.math1FB.ExceptionOccurred += new System.EventHandler<YonatanMankovich.FractionsCalculator.ExceptionOccurredEventArgs>(this.SimplifierFB_ExceptionOccurred);
            // 
            // fractionMathRB
            // 
            this.fractionMathRB.AutoSize = true;
            this.fractionMathRB.Checked = true;
            this.fractionMathRB.Location = new System.Drawing.Point(2, 12);
            this.fractionMathRB.Name = "fractionMathRB";
            this.fractionMathRB.Size = new System.Drawing.Size(14, 13);
            this.fractionMathRB.TabIndex = 0;
            this.fractionMathRB.TabStop = true;
            this.fractionMathRB.UseVisualStyleBackColor = true;
            this.fractionMathRB.CheckedChanged += new System.EventHandler(this.RadioButton_CheckChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 465);
            this.Controls.Add(this.fractionMathRB);
            this.Controls.Add(this.FractionSimplifierRB);
            this.Controls.Add(this.DecimalToFractionRB);
            this.Controls.Add(this.FractionSimplifierGB);
            this.Controls.Add(this.resultGB);
            this.Controls.Add(this.DecimalToFractionGB);
            this.Controls.Add(this.fractionMathGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Fractions Calculator";
            this.Load += new System.EventHandler(this.RequestCalculation);
            ((System.ComponentModel.ISupportInitialize)(this.CountNUD)).EndInit();
            this.DecimalToFractionGB.ResumeLayout(false);
            this.DecimalToFractionGB.PerformLayout();
            this.FractionSimplifierGB.ResumeLayout(false);
            this.resultGB.ResumeLayout(false);
            this.resultGB.PerformLayout();
            this.fractionMathGB.ResumeLayout(false);
            this.fractionMathGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label VisualizationLB;
        private System.Windows.Forms.CheckBox IsMixedResultFractionCB;
        private System.Windows.Forms.NumericUpDown CountNUD;
        private System.Windows.Forms.TextBox DecimalNumberTB;
        private System.Windows.Forms.ToolTip MainToolTip;
        private System.Windows.Forms.GroupBox DecimalToFractionGB;
        private System.Windows.Forms.GroupBox FractionSimplifierGB;
        private System.Windows.Forms.GroupBox resultGB;
        private System.Windows.Forms.RadioButton DecimalToFractionRB;
        private System.Windows.Forms.RadioButton FractionSimplifierRB;
        private FractionBox simplifierFB;
        private FractionBox resultFB;
        private System.Windows.Forms.GroupBox fractionMathGB;
        private System.Windows.Forms.ComboBox mathOperatorCB;
        private FractionBox math2FB;
        private FractionBox math1FB;
        private System.Windows.Forms.RadioButton fractionMathRB;
        private System.Windows.Forms.Label fractionComparisonLBL;
    }
}

