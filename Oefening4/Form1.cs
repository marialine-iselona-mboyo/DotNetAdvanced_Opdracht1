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
            double number1 = Convert.ToDouble(numericUpDown1.TextAlign);
            double price1 = Convert.ToDouble(priceBox1.TextAlign);

            double number2 = Convert.ToDouble(numericUpDown2.TextAlign);
            double price2 = Convert.ToDouble(priceBox2.TextAlign);

            double number3 = Convert.ToDouble(numericUpDown3.TextAlign);
            double price3 = Convert.ToDouble(priceBox3.TextAlign);

            double number4 = Convert.ToDouble(numericUpDown4.TextAlign);
            double price4 = Convert.ToDouble(priceBox4.TextAlign);
        }
    }
}