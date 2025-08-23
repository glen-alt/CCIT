namespace Employee_Management_System
{
    public partial class frmMotherForm : Form
    {
        public frmMotherForm()
        {
            InitializeComponent();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
