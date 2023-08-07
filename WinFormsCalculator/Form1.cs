namespace WinFormsCalculator
{
    public partial class Form1 : Form
    {
        private List<double> investedValues = new();
        private int investor = 1;
        private double totalValue;

        public Form1()
        {
            InitializeComponent();
        }

        #region Private methods
        private double CalculateProportion()
        {
            double constant = 0;
            foreach (var item in investedValues)
                constant += item;

            return totalValue / constant;
        }

        #endregion
        private void ButtonAddValue_Click(object sender, EventArgs e)
        {
            investedValues.Add(double.Parse(TextBoxInvestedValue.Text));
            RichTextBoxResult.Text += $"Investor {investor}: {double.Parse(TextBoxInvestedValue.Text):C} \n";
            investor++;
            TextBoxInvestedValue.Clear();
            TextBoxInvestedValue.Focus();
        }

        private void ButtonCalculateProportion_Click(object sender, EventArgs e)
        {
            totalValue = double.Parse(TextBoxInvestmentValue.Text);
            investor = 1;
            RichTextBoxResult.Text += "\n**************************************************\nGain of each investor\n";

            var constant = CalculateProportion();
            foreach (var item in investedValues)
            {
                RichTextBoxResult.Text += $"Investor {investor}: {item * constant:C}\n";
                investor++;
            }
            RichTextBoxResult.Text += $"\nTotal: {double.Parse(TextBoxInvestmentValue.Text):C}";
        }
    }
}