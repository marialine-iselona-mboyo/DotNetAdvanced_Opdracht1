namespace Oefening5
{
    public partial class CelsiusToFahrenheit : Form
    {
        public CelsiusToFahrenheit()
        {
            InitializeComponent();
        }

        private void celsiusBtn_Click(object sender, EventArgs e)
        {
            double celsius = 0.0;
            celsius = Convert.ToDouble(celsiusTB.Text);
            double celsiusToFahren = celsius * 9 / 5 + 32;
        }

        private void fahrenheitBtn_Click(object sender, EventArgs e)
        {
            double fahrenheit = 0.0;
            fahrenheit = Convert.ToDouble(fahrenheitTB.Text);
            double fahrenToCelsius = (fahrenheit - 32) * 5 / 9;
        }
    }
}