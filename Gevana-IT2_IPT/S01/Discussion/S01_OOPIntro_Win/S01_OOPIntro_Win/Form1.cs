namespace S01_OOPIntro_Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pet myPet = new Pet();
            myPet.Name = txtName.Text;
            myPet.Species = txtSpecies.Text;

            lblName.Text = myPet.Speak();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
