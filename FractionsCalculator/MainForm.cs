using System;
using System.Windows.Forms;
using YonatanMankovich.FractionsLibrary;

namespace YonatanMankovich.FractionsCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        int outFractionLabelDisplayMode = 0;
        private void Calculate()
        {
            try
            {
                if (DecimalToFractionRB.Checked)
                    CalculateRepeatingDecimalNumber();
                if (FractionSimplifierRB.Checked)
                    CalculateFractionSimplifier();
                ErrorLB.Text = "";
            }
            catch (Exception e)
            {
                ClearOutputs();
                ErrorLB.Text = e.Message;
            }
        }

        private void CalculateFractionSimplifier()
        {
            Fraction fraction = new Fraction(decimal.Parse(NumeratorInTB.Text == "" ? "0" : NumeratorInTB.Text), decimal.Parse(DenominatorInTB.Text == "" ? "1" : DenominatorInTB.Text));
            fraction.SetWhole(fraction.GetWhole() + decimal.Parse(WholePartFractionInTB.Text == "" ? "0" : WholePartFractionInTB.Text));
            Output(fraction.Simplify(), Environment.NewLine + ((decimal)fraction).ToString());
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
            IsMixedFractionCB.Enabled = (decimal)fraction >= 1;
            if (!IsMixedFractionCB.Checked)
            {
                WholePartFractionOutTB.Text = fraction.IsNegative() ? "-" : "";
                NumeratorOutTB.Text = fraction.Absolute().Numerator.ToString();
                DenominatorOutTB.Text = fraction.Absolute().Denominator.ToString();
            }
            else
            {
                WholePartFractionOutTB.Text = fraction.GetWhole().ToString();
                WholePartFractionOutTB.Text = WholePartFractionOutTB.Text == "0" ? (fraction.IsNegative() ? "-" : "") : WholePartFractionOutTB.Text;
                NumeratorOutTB.Text = fraction.RemoveWhole().Absolute().Numerator.ToString();
                DenominatorOutTB.Text = fraction.RemoveWhole().Absolute().Denominator.ToString();
            }
            VisualizationLB.Text = visualizationTB_Text;
        }

        private void ClearOutputs()
        {
            ErrorLB.Text = WholePartFractionOutTB.Text = NumeratorOutTB.Text = DenominatorOutTB.Text = VisualizationLB.Text = "";
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

        private void NumeratorInTB_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void DenominatorInTB_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void WholePartFractionInTB_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}