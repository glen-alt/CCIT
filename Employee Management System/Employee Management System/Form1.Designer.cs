namespace Employee_Management_System
{
    partial class frmMotherForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSideMenu = new Panel();
            btnAddEmp = new Button();
            btnMasterData = new Button();
            pnlTitleBar = new Panel();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            pnlStage = new Panel();
            pnlSideMenu.SuspendLayout();
            pnlTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSideMenu
            // 
            pnlSideMenu.BackColor = Color.CadetBlue;
            pnlSideMenu.Controls.Add(btnAddEmp);
            pnlSideMenu.Controls.Add(btnMasterData);
            pnlSideMenu.Dock = DockStyle.Left;
            pnlSideMenu.Location = new Point(0, 51);
            pnlSideMenu.Name = "pnlSideMenu";
            pnlSideMenu.Size = new Size(220, 446);
            pnlSideMenu.TabIndex = 0;
            pnlSideMenu.Paint += pnlSideMenu_Paint;
            // 
            // btnAddEmp
            // 
            btnAddEmp.BackColor = Color.LightGray;
            btnAddEmp.Dock = DockStyle.Top;
            btnAddEmp.Font = new Font("Stylus BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddEmp.Location = new Point(0, 44);
            btnAddEmp.Name = "btnAddEmp";
            btnAddEmp.Size = new Size(220, 46);
            btnAddEmp.TabIndex = 1;
            btnAddEmp.Text = "ADD EMPLOYEE";
            btnAddEmp.UseVisualStyleBackColor = false;
            btnAddEmp.Click += btnAddEmp_Click;
            // 
            // btnMasterData
            // 
            btnMasterData.BackColor = Color.LightGray;
            btnMasterData.Dock = DockStyle.Top;
            btnMasterData.Font = new Font("Stylus BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMasterData.Location = new Point(0, 0);
            btnMasterData.Name = "btnMasterData";
            btnMasterData.Size = new Size(220, 44);
            btnMasterData.TabIndex = 0;
            btnMasterData.Text = "MASTER DATA";
            btnMasterData.UseVisualStyleBackColor = false;
            btnMasterData.Click += btnMasterData_Click;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.Teal;
            pnlTitleBar.Controls.Add(btnMinimize);
            pnlTitleBar.Controls.Add(btnMaximize);
            pnlTitleBar.Controls.Add(btnClose);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(828, 51);
            pnlTitleBar.TabIndex = 1;
            pnlTitleBar.Paint += pnlTitleBar_Paint;
            pnlTitleBar.MouseDown += pnlTitleBar_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.Location = new Point(688, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(43, 23);
            btnMinimize.TabIndex = 4;
            btnMinimize.Text = "—";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.Location = new Point(737, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(42, 23);
            btnMaximize.TabIndex = 3;
            btnMaximize.Text = "☐";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Location = new Point(785, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(43, 23);
            btnClose.TabIndex = 2;
            btnClose.Text = "✖";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pnlStage
            // 
            pnlStage.BackColor = SystemColors.ButtonFace;
            pnlStage.Dock = DockStyle.Fill;
            pnlStage.Location = new Point(220, 51);
            pnlStage.Name = "pnlStage";
            pnlStage.Size = new Size(608, 446);
            pnlStage.TabIndex = 2;
            pnlStage.Paint += pnlStage_Paint;
            // 
            // frmMotherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(828, 497);
            Controls.Add(pnlStage);
            Controls.Add(pnlSideMenu);
            Controls.Add(pnlTitleBar);
            Name = "frmMotherForm";
            Text = "Form1";
            Load += frmMotherForm_Load;
            pnlSideMenu.ResumeLayout(false);
            pnlTitleBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSideMenu;
        private Panel pnlTitleBar;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;
        private Button btnAddEmp;
        private Button btnMasterData;
        private Panel pnlStage;
    }
}
