namespace Oefening3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThree_Click_1(object sender, EventArgs e)
        {
            for(int i = 0; i < 100; i++)
            {
                int result = i * 7;

                //Console.WriteLine(result); 
                // I don't understand.
                // Waarom kan ik Console.Writeline niet zien?

                MessageBox.Show(i + " * 7 " + result);

                if(result >= 546)
                {
                    break;
                }
            }
            
            
            /*int i = 0;
            string s = "";

            do
            {
                s += (i * 7).ToString() + ", ";
                i++;

                //Console.WriteLine(i++);
            }
            while (i >= 546);

            MessageBox.Show(s);*/

            //Problem while showing it
        }
    }
}