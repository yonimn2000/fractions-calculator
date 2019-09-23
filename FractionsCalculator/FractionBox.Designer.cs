namespace YonatanMankovich.FractionsCalculator
{
    partial class FractionBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wholeTB = new System.Windows.Forms.TextBox();
            this.denominatorTB = new System.Windows.Forms.TextBox();
            this.numeratorTB = new System.Windows.Forms.TextBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // wholeTB
            // 
            this.wholeTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wholeTB.Font = new System.Drawing.Font("Miriam Fixed", 35F);
            this.wholeTB.Location = new System.Drawing.Point(3, 3);
            this.wholeTB.MaxLength = 20;
            this.wholeTB.Name = "wholeTB";
            this.wholeTB.Size = new System.Drawing.Size(279, 54);
            this.wholeTB.TabIndex = 3;
            this.wholeTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.wholeTB.TextChanged += new System.EventHandler(this.Fraction_TextChanged);
            // 
            // denominatorTB
            // 
            this.denominatorTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.denominatorTB.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denominatorTB.Location = new System.Drawing.Point(3, 33);
            this.denominatorTB.MaxLength = 20;
            this.denominatorTB.Name = "denominatorTB";
            this.denominatorTB.Size = new System.Drawing.Size(105, 24);
            this.denominatorTB.TabIndex = 6;
            this.denominatorTB.TextChanged += new System.EventHandler(this.Fraction_TextChanged);
            // 
            // numeratorTB
            // 
            this.numeratorTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numeratorTB.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeratorTB.Location = new System.Drawing.Point(3, 3);
            this.numeratorTB.MaxLength = 20;
            this.numeratorTB.Name = "numeratorTB";
            this.numeratorTB.Size = new System.Drawing.Size(105, 24);
            this.numeratorTB.TabIndex = 4;
            this.numeratorTB.TextChanged += new System.EventHandler(this.Fraction_TextChanged);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.wholeTB);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.numeratorTB);
            this.splitContainer.Panel2.Controls.Add(this.denominatorTB);
            this.splitContainer.Size = new System.Drawing.Size(400, 61);
            this.splitContainer.SplitterDistance = 285;
            this.splitContainer.TabIndex = 7;
            // 
            // FractionBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.splitContainer);
            this.Name = "FractionBox";
            this.Size = new System.Drawing.Size(400, 61);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox wholeTB;
        private System.Windows.Forms.TextBox denominatorTB;
        private System.Windows.Forms.TextBox numeratorTB;
        private System.Windows.Forms.SplitContainer splitContainer;
    }
}
