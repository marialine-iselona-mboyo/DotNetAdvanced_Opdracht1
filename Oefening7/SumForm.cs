namespace Oefening7
{
    public partial class sum : Form
    {
        public sum()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            int till = int.Parse(tbNumber.Text);
            
            int sum = 0;

            int from = 1;


            while (from <= till)
            {
                    sum += from;
                    from++;

                    tbResult.Text = sum.ToString();
            }
        }
    }
}