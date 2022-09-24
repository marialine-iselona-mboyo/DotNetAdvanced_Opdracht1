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
            DateTime date = DateTime.Now;
            //this.txtBox.Text = DateTime.Now.ToShortTimeString();
            //this.txtBox.Text = DateTime.Now.ToShortTimeString();

            MessageBox.Show(userName);           
            MessageBox.Show(date.ToString());
        }
    }
}