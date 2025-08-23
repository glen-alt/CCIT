namespace A01_Calculator
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
            components = new System.ComponentModel.Container();
            textEquation = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btn0 = new Button();
            btnplus = new Button();
            btnDat = new Button();
            btnEqual = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnMinus = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnDivide = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnTimes = new Button();
            btnErase = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            textDisplay = new TextBox();
            btnSettings = new Button();
            lblhistory = new Label();
            textstorage = new TextBox();
            SuspendLayout();
            // 
            // textEquation
            // 
            textEquation.BackColor = SystemColors.Info;
            textEquation.Location = new Point(12, 33);
            textEquation.Name = "textEquation";
            textEquation.Size = new Size(213, 23);
            textEquation.TabIndex = 0;
            textEquation.TextChanged += textEquation_TextChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.GradientInactiveCaption;
            btn0.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.Location = new Point(21, 297);
            btn0.Name = "btn0";
            btn0.Size = new Size(41, 43);
            btn0.TabIndex = 2;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += Load_key;
            // 
            // btnplus
            // 
            btnplus.BackColor = SystemColors.GradientInactiveCaption;
            btnplus.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnplus.Location = new Point(115, 297);
            btnplus.Name = "btnplus";
            btnplus.Size = new Size(41, 43);
            btnplus.TabIndex = 3;
            btnplus.Text = "+";
            btnplus.UseVisualStyleBackColor = false;
            btnplus.Click += Operator;
            // 
            // btnDat
            // 
            btnDat.BackColor = SystemColors.GradientInactiveCaption;
            btnDat.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDat.Location = new Point(68, 297);
            btnDat.Name = "btnDat";
            btnDat.Size = new Size(41, 43);
            btnDat.TabIndex = 4;
            btnDat.Text = ".";
            btnDat.UseVisualStyleBackColor = false;
            btnDat.Click += Load_key;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = SystemColors.ActiveCaption;
            btnEqual.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEqual.Location = new Point(162, 297);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(41, 43);
            btnEqual.TabIndex = 5;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.GradientInactiveCaption;
            btn1.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(21, 248);
            btn1.Name = "btn1";
            btn1.Size = new Size(41, 43);
            btn1.TabIndex = 6;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += Load_key;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.GradientInactiveCaption;
            btn2.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(68, 248);
            btn2.Name = "btn2";
            btn2.Size = new Size(41, 43);
            btn2.TabIndex = 7;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += Load_key;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.GradientInactiveCaption;
            btn3.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(115, 248);
            btn3.Name = "btn3";
            btn3.Size = new Size(41, 43);
            btn3.TabIndex = 8;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += Load_key;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = SystemColors.GradientInactiveCaption;
            btnMinus.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(162, 248);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(41, 43);
            btnMinus.TabIndex = 9;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += Operator;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.GradientInactiveCaption;
            btn4.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(21, 199);
            btn4.Name = "btn4";
            btn4.Size = new Size(41, 43);
            btn4.TabIndex = 10;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += Load_key;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.GradientInactiveCaption;
            btn5.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(68, 199);
            btn5.Name = "btn5";
            btn5.Size = new Size(41, 43);
            btn5.TabIndex = 11;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += Load_key;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.GradientInactiveCaption;
            btn6.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(115, 199);
            btn6.Name = "btn6";
            btn6.Size = new Size(41, 43);
            btn6.TabIndex = 12;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += Load_key;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = SystemColors.GradientInactiveCaption;
            btnDivide.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDivide.Location = new Point(162, 199);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(41, 43);
            btnDivide.TabIndex = 13;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += Operator;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.GradientInactiveCaption;
            btn7.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(21, 150);
            btn7.Name = "btn7";
            btn7.Size = new Size(41, 43);
            btn7.TabIndex = 14;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += Load_key;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.GradientInactiveCaption;
            btn8.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.Location = new Point(68, 150);
            btn8.Name = "btn8";
            btn8.Size = new Size(41, 43);
            btn8.TabIndex = 15;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += Load_key;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.GradientInactiveCaption;
            btn9.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.Location = new Point(115, 150);
            btn9.Name = "btn9";
            btn9.Size = new Size(41, 43);
            btn9.TabIndex = 16;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += Load_key;
            // 
            // btnTimes
            // 
            btnTimes.BackColor = SystemColors.GradientInactiveCaption;
            btnTimes.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimes.Location = new Point(162, 150);
            btnTimes.Name = "btnTimes";
            btnTimes.Size = new Size(41, 43);
            btnTimes.TabIndex = 17;
            btnTimes.Text = "*";
            btnTimes.UseVisualStyleBackColor = false;
            btnTimes.Click += Operator;
            // 
            // btnErase
            // 
            btnErase.BackColor = SystemColors.GradientInactiveCaption;
            btnErase.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnErase.Location = new Point(162, 101);
            btnErase.Name = "btnErase";
            btnErase.Size = new Size(41, 43);
            btnErase.TabIndex = 18;
            btnErase.Text = "⌫";
            btnErase.UseVisualStyleBackColor = false;
            btnErase.Click += btnErase_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.GradientInactiveCaption;
            btnClear.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(115, 101);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(41, 43);
            btnClear.TabIndex = 19;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.GradientInactiveCaption;
            btnDelete.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(68, 101);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(41, 43);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "CE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // textDisplay
            // 
            textDisplay.Location = new Point(12, 68);
            textDisplay.Name = "textDisplay";
            textDisplay.Size = new Size(213, 23);
            textDisplay.TabIndex = 21;
            textDisplay.TextChanged += textDisplay_TextChanged;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = SystemColors.GradientActiveCaption;
            btnSettings.Font = new Font("SimSun", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettings.Location = new Point(154, 4);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(62, 23);
            btnSettings.TabIndex = 22;
            btnSettings.Text = "Show";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // lblhistory
            // 
            lblhistory.AutoSize = true;
            lblhistory.Location = new Point(231, 7);
            lblhistory.Name = "lblhistory";
            lblhistory.Size = new Size(45, 15);
            lblhistory.TabIndex = 23;
            lblhistory.Text = "History";
            // 
            // textstorage
            // 
            textstorage.Location = new Point(241, 33);
            textstorage.Multiline = true;
            textstorage.Name = "textstorage";
            textstorage.Size = new Size(102, 307);
            textstorage.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 352);
            Controls.Add(textstorage);
            Controls.Add(lblhistory);
            Controls.Add(btnSettings);
            Controls.Add(textDisplay);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnErase);
            Controls.Add(btnTimes);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnDivide);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnMinus);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnEqual);
            Controls.Add(btnDat);
            Controls.Add(btnplus);
            Controls.Add(btn0);
            Controls.Add(textEquation);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textEquation;
        private ContextMenuStrip contextMenuStrip1;
        private Button btn0;
        private Button btnplus;
        private Button btnDat;
        private Button btnEqual;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnMinus;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnDivide;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnTimes;
        private Button btnErase;
        private Button btnClear;
        private Button btnDelete;
        private TextBox textDisplay;
        private Button btnSettings;
        private Label lblhistory;
        private TextBox textstorage;
    }
}
