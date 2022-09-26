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
            
        }
    }
}