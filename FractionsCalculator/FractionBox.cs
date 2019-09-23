using System;
using System.ComponentModel;
using System.Windows.Forms;
using YonatanMankovich.Fractions;

namespace YonatanMankovich.FractionsCalculator
{
    public partial class FractionBox : UserControl
    {
        public Fraction Fraction { get; private set; } = new Fraction();

        public event EventHandler ValueChanged;
        public event EventHandler<ExceptionOccurredEventArgs> ExceptionOccurred;

        private bool _isMixed = true;
        private bool _readOnly;

        public bool ReadOnly
        {
            get => _readOnly; set
            {
                _readOnly = value;
                wholeTB.ReadOnly = numeratorTB.ReadOnly = denominatorTB.ReadOnly = value;
            }
        }
        public bool IsMixed
        {
            get => _isMixed;
            set
            {
                _isMixed = value;
                ShowFraction();
            }
        }

        public FractionBox()
        {
            InitializeComponent();
            ParseFraction();
        }

        public void SetFraction(Fraction value)
        {
            Fraction = value;
            ShowFraction();
        }

        private void ShowFraction()
        {
            Fraction newFraction = new Fraction(Fraction).Absolute();
            if (IsMixed)
            {
                wholeTB.Text = Fraction.GetWhole().ToString();
                wholeTB.Text = wholeTB.Text == "0" ? (Fraction.IsNegative() ? "-" : "") : wholeTB.Text;
                newFraction.RemoveWhole();
                numeratorTB.Text = newFraction.Numerator.ToString();
                denominatorTB.Text = newFraction.Denominator.ToString();
            }
            else
            {
                wholeTB.Text = Fraction.IsNegative() ? "-" : "";
                numeratorTB.Text = newFraction.Numerator.ToString();
                denominatorTB.Text = newFraction.Denominator.ToString();
            }
        }

        private void Fraction_TextChanged(object sender, EventArgs e)
        {
            ParseFraction();
            ValueChanged?.Invoke(this, e);
        }

        private void ParseFraction()
        {
            try
            {
                Fraction.Numerator = decimal.Parse(numeratorTB.Text == "" ? "0" : numeratorTB.Text);
                Fraction.Denominator = decimal.Parse(denominatorTB.Text == "" ? "1" : denominatorTB.Text);
                Fraction.SetWhole(Fraction.GetWhole() + decimal.Parse(wholeTB.Text == "" ? "0" : wholeTB.Text));
            }
            catch (Exception e)
            {
                if (ExceptionOccurred == null)
                    throw e;
                else
                    ExceptionOccurred(this, new ExceptionOccurredEventArgs() { Exception = e });
            }
        }

        public void Clear()
        {
            wholeTB.Text = numeratorTB.Text = denominatorTB.Text = "";
        }
    }

    public class ExceptionOccurredEventArgs : EventArgs
    {
        public Exception Exception { get; set; }
    }
}