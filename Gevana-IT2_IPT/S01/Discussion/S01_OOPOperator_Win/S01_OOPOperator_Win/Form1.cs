namespace S01_OOPOperator_Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtAddends1.Text == "")
            {
                MessageBox.Show("Please Input addends 1 ");
            }
            else if (txtAddends2.Text == "")
            {
                MessageBox.Show("Please Input addends 2 ");
            }
            else
            {
                Addition myAddition = new Addition();
                myAddition.addends1 = int.Parse(txtAddends1.Text);
                myAddition.addends2 = int.Parse(txtAddends2.Text);
                txtSum.Text = myAddition.Add();
            }
        }
    }
}
