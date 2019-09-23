using System;
using System.Windows.Forms;
using YonatanMankovich.Fractions;
using YonatanMankovich.Fractions.RepeatingDecimalNumbers;

namespace YonatanMankovich.FractionsCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            simplifierFB.ExceptionOccurred += SimplifierFB_ExceptionOccurred;
        }

        private void SimplifierFB_ExceptionOccurred(object sender, ExceptionOccurredEventArgs e)
        {
            ClearOutputs();
            MessageBox.Show(e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        int outFractionLabelDisplayMode = 0;

        private void Calculate()
        {
            if (DecimalToFractionRB.Checked)
                CalculateRepeatingDecimalNumber();
            if (FractionSimplifierRB.Checked)
                CalculateFractionSimplifier();
        }

        private void CalculateFractionSimplifier()
        {
            Output(new Fraction(simplifierFB.Fraction.Simplify()), Environment.NewLine + ((decimal)simplifierFB.Fraction).ToString());
        }

        private void CalculateRepeatingDecimalNumber()
        {
            if (DecimalNumberTB.Text.Length > 0)
            {
                try
                {
                    RepeatingDecimalNumber repeatingDecimalNumber = new RepeatingDecimalNumber(decimal.Parse(DecimalNumberTB.Text));
                    CountNUD.Maximum = repeatingDecimalNumber.GetDecimalsLength();
                    repeatingDecimalNumber.RepeatingDecimalsCount = (uint)CountNUD.Value;
                    string outText;
                    if (outFractionLabelDisplayMode == 0)
                        outText = (repeatingDecimalNumber.IsRepeatingDecimal() ? "" : Environment.NewLine) + repeatingDecimalNumber.ToLineNotationString();
                    else
                        outText = Environment.NewLine + repeatingDecimalNumber.ToString(36);
                    Output(repeatingDecimalNumber.GetAsFraction(), outText);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                ClearOutputs();
        }

        private void Output(Fraction fraction, string visualizationTB_Text)
        {
            IsMixedResultFractionCB.Enabled = (decimal)fraction >= 1;
            resultFB.SetFraction(fraction);
            resultFB.IsMixed = IsMixedResultFractionCB.Checked;
            VisualizationLB.Text = visualizationTB_Text;
        }

        private void ClearOutputs()
        {
            resultFB.Clear();
        }

        private void IsMixedFractionCB_CheckedChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void VisualizationLB_Click(object sender, EventArgs e)
        {
            outFractionLabelDisplayMode = outFractionLabelDisplayMode == 0 ? 1 : 0;
            Calculate();
        }

        private void NumberTB_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void CountNUD_ValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Calculate();
        }

        private void FractionSimplifierRB_CheckedChanged(object sender, EventArgs e)
        {
            DecimalToFractionRB_CheckedChanged(sender, e);
        }

        private void DecimalToFractionRB_CheckedChanged(object sender, EventArgs e)
        {
            if (DecimalToFractionRB.Checked)
            {
                DecimalToFractionGB.Enabled = true;
                FractionSimplifierGB.Enabled = false;
            }
            else
            {
                DecimalToFractionGB.Enabled = false;
                FractionSimplifierGB.Enabled = true;
            }
            Calculate();
        }

        private void simplifyFB_ValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}