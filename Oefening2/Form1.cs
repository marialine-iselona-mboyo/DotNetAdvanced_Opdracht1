namespace Oefening2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            int number1 = 12345;
            int number2 = 54321;
            int number3 = 22222;
            int number4 = 33333;

            int result1 = number1 * number2;
            int result2 = number3 * number4;

            //bool isValid = true;
            bool myBool = result1 > result2;


            MessageBox.Show(number1 + "*" + +number2 + " = "+ +result1 + "\n" + +number3 + "*" + +number4 + " = " + +result2 +
                "\n" + +number1 + "*" + +number2 + " > " + +number3 + "*" + +number4 + "\n" + myBool, "IsItBigger");
            
        }
    }
}