using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class frmMasterData : Form
    {
        public frmMasterData()
        {
            InitializeComponent();
        }

        private Panel pnlChildTitle;

        private void InitializeComponent()
        {
            pnlChildTitle = new Panel();
            lblMasterData = new Label();
            dtgMasterData = new DataGridView();
            pnlChildTitle.SuspendLayout();
            ((ISupportInitialize)dtgMasterData).BeginInit();
            SuspendLayout();
            // 
            // pnlChildTitle
            // 
            pnlChildTitle.BackColor = SystemColors.ActiveCaption;
            pnlChildTitle.Controls.Add(lblMasterData);
            pnlChildTitle.Dock = DockStyle.Top;
            pnlChildTitle.Location = new Point(0, 0);
            pnlChildTitle.Name = "pnlChildTitle";
            pnlChildTitle.Size = new Size(748, 62);
            pnlChildTitle.TabIndex = 0;
            // 
            // lblMasterData
            // 
            lblMasterData.AutoSize = true;
            lblMasterData.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMasterData.Location = new Point(10, 19);
            lblMasterData.Name = "lblMasterData";
            lblMasterData.Size = new Size(114, 24);
            lblMasterData.TabIndex = 0;
            lblMasterData.Text = "Master Data";
            // 
            // dtgMasterData
            // 
            dtgMasterData.BackgroundColor = SystemColors.ButtonFace;
            dtgMasterData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgMasterData.Dock = DockStyle.Fill;
            dtgMasterData.Location = new Point(0, 62);
            dtgMasterData.Name = "dtgMasterData";
            dtgMasterData.Size = new Size(748, 311);
            dtgMasterData.TabIndex = 1;
            // 
            // frmMasterData
            // 
            ClientSize = new Size(748, 373);
            Controls.Add(dtgMasterData);
            Controls.Add(pnlChildTitle);
            Name = "frmMasterData";
            Load += frmMasterData_Load;
            pnlChildTitle.ResumeLayout(false);
            pnlChildTitle.PerformLayout();
            ((ISupportInitialize)dtgMasterData).EndInit();
            ResumeLayout(false);
        }

        private Label lblMasterData;
        private DataGridView dtgMasterData;

        private void frmMasterData_Load(object sender, EventArgs e)
        {
            string select_tblrequestorlist = "select * from tblEmployeeData order BY EmployeeNumber DESC";
            CRUD.CRUD.RETRIEVEDTG(dtgMasterData, select_tblrequestorlist);
        }
    }
}
