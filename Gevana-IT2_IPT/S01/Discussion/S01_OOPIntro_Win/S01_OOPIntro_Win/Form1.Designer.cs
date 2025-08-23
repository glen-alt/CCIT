namespace S01_OOPIntro_Win
{
    partial class Form1
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
            lblName = new Label();
            lblName1 = new Label();
            txtName = new TextBox();
            txtSpecies = new TextBox();
            label1 = new Label();
            button1Speak = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(142, 76);
            lblName.Name = "lblName";
            lblName.Size = new Size(74, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            lblName.Click += lblName_Click;
            // 
            // lblName1
            // 
            lblName1.AutoSize = true;
            lblName1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName1.Location = new Point(111, 140);
            lblName1.Name = "lblName1";
            lblName1.Size = new Size(117, 30);
            lblName1.TabIndex = 1;
            lblName1.Text = "Species:";
            // 
            // txtName
            // 
            txtName.Location = new Point(222, 80);
            txtName.Name = "txtName";
            txtName.Size = new Size(447, 23);
            txtName.TabIndex = 2;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(230, 150);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(439, 23);
            txtSpecies.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SuperFrench", 18F, FontStyle.Bold, GraphicsUnit.Point, 2);
            label1.Location = new Point(119, 223);
            label1.Name = "label1";
            label1.Size = new Size(109, 24);
            label1.TabIndex = 5;
            label1.Text = "OUTPUT";
            // 
            // button1Speak
            // 
            button1Speak.Font = new Font("Stencil", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1Speak.Location = new Point(594, 179);
            button1Speak.Name = "button1Speak";
            button1Speak.Size = new Size(75, 23);
            button1Speak.TabIndex = 6;
            button1Speak.Text = "SPEAK";
            button1Speak.UseVisualStyleBackColor = true;
            button1Speak.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 323);
            Controls.Add(button1Speak);
            Controls.Add(label1);
            Controls.Add(txtSpecies);
            Controls.Add(txtName);
            Controls.Add(lblName1);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblName1;
        private TextBox txtName;
        private TextBox txtSpecies;
        private Label label1;
        private Button button1Speak;
    }
}
