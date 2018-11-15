using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FractionsLibrary;

namespace Fractions
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void DecimalNumberTB_TextChanged(object sender, EventArgs e)
        {
            //Check correct input nums only
            Calculate();
        }

        private void RepeatingNumberTB_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        int mode = 0;
        private void Calculate()
        {
            if (DecimalNumberTB.Text.Length > 0)
            {
                try
                {
                    RepeatingDecimalNumber repeatingDecimalNumber
                    = new RepeatingDecimalNumber(decimal.Parse(DecimalNumberTB.Text), RepeatingNumberTB.Text);
                    OutputTB.Text = IsMixedFractionCB.Checked ? repeatingDecimalNumber.GetAsFraction().ToMixedFractionString() : repeatingDecimalNumber.GetAsFraction().ToString();
                    if (mode == 0)
                        VisualizationLB.Text = (repeatingDecimalNumber.IsRepeatingDecimal ? "" : Environment.NewLine) + repeatingDecimalNumber.ToScientificNotationString();
                    else
                    VisualizationLB.Text = Environment.NewLine+repeatingDecimalNumber.ToString(40);
                    ErrorLB.Text = "";
                }
                catch (Exception e)
                {
                    OutputTB.Text = VisualizationLB.Text = "";
                    ErrorLB.Text = e.Message;
                }
            }
            else
                ErrorLB.Text = OutputTB.Text = VisualizationLB.Text = "";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Calculate();
        }

        private void IsMixedFractionCB_CheckedChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void VisualizationLB_Click(object sender, EventArgs e)
        {
            mode = mode == 0 ? 1 : 0;
            Calculate();
        }
    }
}