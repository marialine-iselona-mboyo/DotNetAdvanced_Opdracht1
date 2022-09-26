namespace Oefening1
{
    public partial class Begroeting : Form
    {
        public Begroeting()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            string userName = Environment.UserName;

            MessageBox.Show("Hello " + userName + ". Het is " + DateTime.Now.ToShortTimeString() + 
                " op " + DateTime.Now.ToShortDateString());


        }
    }
}