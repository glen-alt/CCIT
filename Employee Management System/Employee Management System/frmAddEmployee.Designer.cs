namespace Employee_Management_System
{
    partial class frmAddEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblAddEmp = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtEmpID = new TextBox();
            txtRequestorName = new TextBox();
            txtEmailAddress = new TextBox();
            txtLocalNumber = new TextBox();
            button1 = new Button();
            cmbSection = new ComboBox();
            panel2 = new Panel();
            btnInsertUpdate = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(lblAddEmp);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 65);
            panel1.TabIndex = 0;
            // 
            // lblAddEmp
            // 
            lblAddEmp.AutoSize = true;
            lblAddEmp.BackColor = Color.Snow;
            lblAddEmp.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddEmp.Location = new Point(9, 24);
            lblAddEmp.Name = "lblAddEmp";
            lblAddEmp.Size = new Size(113, 23);
            lblAddEmp.TabIndex = 0;
            lblAddEmp.Text = "Add employee";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(3, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(801, 318);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 68);
            label1.Name = "label1";
            label1.Size = new Size(345, 23);
            label1.TabIndex = 1;
            label1.Text = "Employee Details Manual insert and Update:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 99);
            label2.Name = "label2";
            label2.Size = new Size(116, 18);
            label2.TabIndex = 2;
            label2.Text = "Employee Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 129);
            label3.Name = "label3";
            label3.Size = new Size(104, 18);
            label3.TabIndex = 3;
            label3.Text = "Requestor Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 159);
            label4.Name = "label4";
            label4.Size = new Size(93, 18);
            label4.TabIndex = 4;
            label4.Text = "Email Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 192);
            label5.Name = "label5";
            label5.Size = new Size(90, 18);
            label5.TabIndex = 5;
            label5.Text = "Local Number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(68, 221);
            label6.Name = "label6";
            label6.Size = new Size(54, 18);
            label6.TabIndex = 6;
            label6.Text = "Section:";
            // 
            // txtEmpID
            // 
            txtEmpID.Location = new Point(136, 95);
            txtEmpID.Name = "txtEmpID";
            txtEmpID.Size = new Size(318, 23);
            txtEmpID.TabIndex = 7;
            // 
            // txtRequestorName
            // 
            txtRequestorName.Location = new Point(136, 124);
            txtRequestorName.Name = "txtRequestorName";
            txtRequestorName.Size = new Size(316, 23);
            txtRequestorName.TabIndex = 8;
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.Location = new Point(136, 158);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(317, 23);
            txtEmailAddress.TabIndex = 9;
            // 
            // txtLocalNumber
            // 
            txtLocalNumber.Location = new Point(136, 187);
            txtLocalNumber.Name = "txtLocalNumber";
            txtLocalNumber.Size = new Size(317, 23);
            txtLocalNumber.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(460, 94);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // cmbSection
            // 
            cmbSection.FormattingEnabled = true;
            cmbSection.Location = new Point(136, 216);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(173, 23);
            cmbSection.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Menu;
            panel2.Controls.Add(btnInsertUpdate);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtRequestorName);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtEmailAddress);
            panel2.Controls.Add(txtLocalNumber);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(cmbSection);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(txtEmpID);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 456);
            panel2.TabIndex = 15;
            // 
            // btnInsertUpdate
            // 
            btnInsertUpdate.Location = new Point(136, 245);
            btnInsertUpdate.Name = "btnInsertUpdate";
            btnInsertUpdate.Size = new Size(141, 23);
            btnInsertUpdate.TabIndex = 14;
            btnInsertUpdate.Text = "INSERT/UPDATE";
            btnInsertUpdate.UseVisualStyleBackColor = true;
            btnInsertUpdate.Click += btnInsertUpdate_Click;
            // 
            // frmAddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Name = "frmAddEmployee";
            Text = "frmAddEmployee";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblAddEmp;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtEmpID;
        private GroupBox groupBox1;
        private TextBox txtRequestorName;
        private TextBox txtEmailAddress;
        private TextBox txtLocalNumber;
        private Button button1;
        private ComboBox cmbSection;
        private Panel panel2;
        private Button btnInsertUpdate;
    }
}