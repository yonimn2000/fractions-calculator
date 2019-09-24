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
            mathOperatorCB.SelectedIndex = 0;
        }

        private void SimplifierFB_ExceptionOccurred(object sender, ExceptionOccurredEventArgs e)
        {
            ClearOutputs();
            MessageBox.Show(e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        int outFractionLabelDisplayMode = 0;

        private void Calculate()
        {
            try
            {
                if (DecimalToFractionRB.Checked)
                    CalculateRepeatingDecimalNumber();
                else if (FractionSimplifierRB.Checked)
                    Output(new Fraction(simplifierFB.Fraction.Simplify()),
                        Environment.NewLine + ((decimal)simplifierFB.Fraction).ToString());
                else if (fractionMathRB.Checked)
                    CalculateFractionMath();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateFractionMath()
        {
            Fraction outputFraction = new Fraction();
            Fraction fraction1 = math1FB.Fraction;
            Fraction fraction2 = math2FB.Fraction;

            switch (mathOperatorCB.SelectedItem)
            {
                case "+": outputFraction = fraction1 + fraction2; break;
                case "-": outputFraction = fraction1 - fraction2; break;
                case "x": outputFraction = fraction1 * fraction2; break;
                case ":": outputFraction = fraction1 / fraction2; break;
                default: MessageBox.Show("Unknown operation"); break;
            }
            Output(outputFraction, Environment.NewLine + ((decimal)outputFraction).ToString());

            fractionComparisonLBL.Text = "Top ";
            if (fraction1 < fraction2)
                fractionComparisonLBL.Text += "<";
            else if (fraction1.Equivalent(fraction2))
                fractionComparisonLBL.Text += "=";
            else //if (fraction1 > fraction2)
                fractionComparisonLBL.Text += ">";
            fractionComparisonLBL.Text += " Bottom";
        }

        private void CalculateRepeatingDecimalNumber()
        {
            if (DecimalNumberTB.Text.Length > 0)
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

        private void VisualizationLB_Click(object sender, EventArgs e)
        {
            outFractionLabelDisplayMode = outFractionLabelDisplayMode == 0 ? 1 : 0;
            Calculate();
        }

        private void RequestCalculation(object sender, EventArgs e)
        {
            Calculate();
        }

        private void RadioButton_CheckChanged(object sender, EventArgs e)
        {
            DecimalToFractionGB.Enabled = DecimalToFractionRB.Checked;
            FractionSimplifierGB.Enabled = FractionSimplifierRB.Checked;
            fractionMathGB.Enabled = fractionMathRB.Checked;
            Calculate();
        }
    }
}