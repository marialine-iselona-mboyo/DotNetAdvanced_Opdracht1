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
            int i = 0;
            string s = "";

            do
            {
                s += (i * 7).ToString() + ", ";
                i++;

                //Console.WriteLine(i++);
            }
            while (i > 546);

            MessageBox.Show(s);

            //Problem while showing it
        }
    }
}