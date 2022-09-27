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
            double quantity1 = Convert.ToDouble(quantityTB1.Text);
            double price1 = Convert.ToDouble(priceEachTB1.Text);
            double result1 = quantity1 * price1;
            priceTB1.Text = "€ " + result1.ToString();

            double quantity2 = Convert.ToDouble(quantityTB2.Text);
            double price2 = Convert.ToDouble(priceEachTB2.Text);
            double result2 = quantity2 * price2;
            priceTB2.Text = "€ " + result2.ToString();

            double quantity3 = Convert.ToDouble(quantityTB3.Text);
            double price3 = Convert.ToDouble(priceEachTB3.Text);
            double result3 = quantity3 * price3;
            priceTB3.Text = "€ " + result3.ToString();

            double quantity4 = Convert.ToDouble(quantityTB4.Text);
            double price4 = Convert.ToDouble(priceEachTB4.Text);
            double result4 = quantity4 * price4;
            priceTB4.Text = "€ " + result4.ToString();



            double subtotal = result1 + result2 + result3 + result4;
            subtotalTB.Text = "€ " + subtotal.ToString();

            double taxSales = subtotal * 7 / 100;
            salesTaxTB.Text = "€" + taxSales.ToString();

            double shipping = 0; //= Convert.ToDouble(shippingTB.Text);
            if (subtotal <= 20)
            {
                shipping = 5;
            } else if (subtotal >= 20 || subtotal < 50)
            {
                shipping = 7.5;
            } else if (subtotal >= 50 || subtotal < 75)
            {
                shipping = 10;
            } else if(subtotal >= 75)
            {
                shippingTB.Text = "Free";
            }
            
            double grandTotal = subtotal + taxSales + shipping;
            grandTotalTB.Text = "€" + grandTotal.ToString();
        }
    }
}