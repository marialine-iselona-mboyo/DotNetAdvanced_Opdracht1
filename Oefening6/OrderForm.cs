using System.Windows.Forms;

namespace Oefening6
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double quantity1 = Convert.ToDouble(quantityTB1.TextAlign);
            double price1 = Convert.ToDouble(priceEachTB1.TextAlign);
            double result1 = 0;
            result1 = quantity1 * price1;
            priceTB1.Text = "€ " + result1.ToString();

            double quantity2 = Convert.ToDouble(quantityTB2.TextAlign);
            double price2 = Convert.ToDouble(priceEachTB2.TextAlign);
            double result2 = 0;
            result2 = quantity2 * price2;
            priceTB2.Text = "€ " + result2.ToString();

            double quantity3 = Convert.ToDouble(quantityTB3.TextAlign);
            double price3 = Convert.ToDouble(priceEachTB3.TextAlign);
            double result3 = 0;
            result3 = quantity3 * price3;
            priceTB3.Text = "€ " + result3.ToString();

            double quantity4 = Convert.ToDouble(quantityTB4.TextAlign);
            double price4 = Convert.ToDouble(priceEachTB4.TextAlign);
            double result4 = 0;
            result4 = quantity4 * price4;
            priceTB4.Text = "€ " + result4.ToString();



            double subtotal = result1 + result2 + result3 + result4;
            subtotalTB.Text = "€ " + subtotal.ToString();

            //double tax = Convert.ToDouble(taxBox.Text);

            double taxSales = subtotal;
            salesTaxTB.Text = "€" + taxSales.ToString();

            double shipping = Convert.ToDouble(shippingTB.Text);

            double grandTotal = subtotal + taxSales + shipping;
            grandTotalTB.Text = "€" + grandTotal.ToString();
        }
    }
}