namespace S01_OOPOperator_Win
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
            txtAddends1 = new TextBox();
            lblName2 = new Label();
            txtAddends2 = new TextBox();
            lblName3 = new Label();
            txtSum = new TextBox();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(203, 70);
            lblName.Name = "lblName";
            lblName.Size = new Size(97, 15);
            lblName.TabIndex = 0;
            lblName.Text = "WEEK 1 ACTIVITY";
            // 
            // txtAddends1
            // 
            txtAddends1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddends1.Location = new Point(219, 109);
            txtAddends1.Name = "txtAddends1";
            txtAddends1.Size = new Size(50, 57);
            txtAddends1.TabIndex = 1;
            // 
            // lblName2
            // 
            lblName2.AutoSize = true;
            lblName2.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName2.Location = new Point(275, 120);
            lblName2.Name = "lblName2";
            lblName2.Size = new Size(31, 33);
            lblName2.TabIndex = 2;
            lblName2.Text = "+";
            // 
            // txtAddends2
            // 
            txtAddends2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddends2.Location = new Point(312, 109);
            txtAddends2.Name = "txtAddends2";
            txtAddends2.Size = new Size(56, 57);
            txtAddends2.TabIndex = 3;
            // 
            // lblName3
            // 
            lblName3.AutoSize = true;
            lblName3.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName3.Location = new Point(374, 124);
            lblName3.Name = "lblName3";
            lblName3.Size = new Size(30, 33);
            lblName3.TabIndex = 4;
            lblName3.Text = "=";
            // 
            // txtSum
            // 
            txtSum.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSum.Location = new Point(410, 112);
            txtSum.Name = "txtSum";
            txtSum.Size = new Size(100, 54);
            txtSum.TabIndex = 5;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = SystemColors.ActiveCaption;
            btnCalculate.Location = new Point(410, 172);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(102, 23);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "CALCULATE";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 390);
            Controls.Add(btnCalculate);
            Controls.Add(txtSum);
            Controls.Add(lblName3);
            Controls.Add(txtAddends2);
            Controls.Add(lblName2);
            Controls.Add(txtAddends1);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtAddends1;
        private Label lblName2;
        private TextBox txtAddends2;
        private Label lblName3;
        private TextBox txtSum;
        private Button btnCalculate;
    }
}
