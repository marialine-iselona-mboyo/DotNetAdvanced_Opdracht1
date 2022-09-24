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


            //DateTime date = DateTime.Now;
            //MessageBox.Show("Hello " + userName + ". Het is " + date.ToString() + " op ");

            MessageBox.Show("Hello " + userName + ". Het is " + DateTime.Now.ToShortTimeString() + " op " + DateTime.Now.ToShortDateString());




            //Vragen:
            //Hoe Kan ik de username veranderen?
            //Is mijn tijd en datum in de engelse formaat omdat mijn systeem in het engels is?
        }
    }
}