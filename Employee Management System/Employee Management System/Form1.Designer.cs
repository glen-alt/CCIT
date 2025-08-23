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
            pnlTitleBar = new Panel();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            pnlTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSideMenu
            // 
            pnlSideMenu.Dock = DockStyle.Left;
            pnlSideMenu.Location = new Point(0, 79);
            pnlSideMenu.Name = "pnlSideMenu";
            pnlSideMenu.Size = new Size(220, 418);
            pnlSideMenu.TabIndex = 0;
            pnlSideMenu.Paint += pnlSideMenu_Paint;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.Controls.Add(btnMinimize);
            pnlTitleBar.Controls.Add(btnMaximize);
            pnlTitleBar.Controls.Add(btnClose);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(828, 79);
            pnlTitleBar.TabIndex = 1;
            pnlTitleBar.Paint += pnlTitleBar_Paint;
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
            // frmMotherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 497);
            Controls.Add(pnlSideMenu);
            Controls.Add(pnlTitleBar);
            Name = "frmMotherForm";
            Text = "Form1";
            pnlTitleBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSideMenu;
        private Panel pnlTitleBar;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;
    }
}
