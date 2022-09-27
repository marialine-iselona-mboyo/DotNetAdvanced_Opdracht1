/*
 Maak het programma SalesTaxCalculator:

Voorzie 4 lijnen met telkens de volgende velden die de gebruiker kan invullen:

 Item (De naam van een item)
 Quantity (De hoeveelheid van het item)
 Price Each (De eenheidsprijs van het item)
Voorzie de andere velden zoals op de afbeelding, waarbij Tax Rate ook door de gebruiker in te vullen is.

Wanneer de gebruiker op de Calculate knop drukt:

bereken en toon Ext. Price (quantity * price Each)
bereken en toon Subtotal
bereken en toon Sales Tax (subtotal * tax rate)
bereken en toon Grand Total (subtotal + sales sax + shipping)
 */


namespace Oefening4
{
    public partial class SalesTaxCalculator : Form
    {
        public SalesTaxCalculator()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(numericUpDown1.Text);
            double price1 = Convert.ToDouble(priceBox1.Text);
            double result1 = number1 * price1;
            extPriceBox1.Text = "€ " + result1.ToString();

            double number2 = Convert.ToDouble(numericUpDown2.Text);
            double price2 = Convert.ToDouble(priceBox2.Text);
            double result2 = number2 * price2;
            extPriceBox2.Text = "€ " + result2.ToString();

            double number3 = Convert.ToDouble(numericUpDown3.Text);
            double price3 = Convert.ToDouble(priceBox3.Text);
            double result3 = number3 * price3;
            extPriceBox3.Text = "€ " + result3.ToString();

            double number4 = Convert.ToDouble(numericUpDown4.Text);
            double price4 = Convert.ToDouble(priceBox4.Text);
            double result4 = number4 * price4;
            extPriceBox4.Text = "€ " + result4.ToString();



            double subtotal = result1 + result2 + result3 + result4;
            subtotalBox.Text = "€ " + subtotal.ToString();

            double tax = Convert.ToDouble(taxBox.Text);

            double taxSales = subtotal * tax;
            salesBox.Text = "€" + taxSales.ToString();

            double shipping = Convert.ToDouble(shippingBox.Text);

            double grandTotal = subtotal + taxSales + shipping;
            totalBox.Text = "€" + grandTotal.ToString();
        }
    }
}