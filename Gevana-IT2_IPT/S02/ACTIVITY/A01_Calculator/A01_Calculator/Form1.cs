using System.Data.OleDb;
using System.Drawing.Text;
using System.Text;

namespace A01_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        bool isNewEntry = false;
        double firstNumber = 0;
        string operation = "";
        private int originalWidth;

        string dbPath = @"C:\LOCALDB\Calculator.accdb";
       

        private void btn0_Click(object sender, EventArgs e)
        {

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Total();

        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {


        }

        private void btn5_Click(object sender, EventArgs e)
        {


        }

        private void btn6_Click(object sender, EventArgs e)
        {


        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (this.Width >= 370)
            {
                this.Width = originalWidth;
            }
            else
            {
                this.Width = 380;
            }
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text.Length > 0)
            {
                textDisplay.Text = textDisplay.Text.Substring(0, textDisplay.Text.Length - 1);

                if (textEquation.Text.Length > 0)
                {
                    textEquation.Text = textEquation.Text.Substring(0, textEquation.Text.Length - 1);
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "0";

            isNewEntry = true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "0";

            textEquation.Text = "";

            isNewEntry = true;

        }

        private void textDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void textEquation_TextChanged(object sender, EventArgs e)
        {

        }
        private void Load_key(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (isNewEntry)
            {
                textDisplay.Text = "";
                isNewEntry = false;
            }
            if (textDisplay.Text == "0" && btn.Text != ".")
            {
                textDisplay.Text = "";
            }
            int dotCount = textDisplay.Text.Count(c => c == '.');
            if (dotCount >= 1)
            {
                if (btn.Text != ".")
                {
                    textDisplay.Text += btn.Text;
                }

            }
            else if (textDisplay.Text == "" && btn.Text == ".")
            {
                textDisplay.Text = "0. ";
            }
            else
            {
                textDisplay.Text += btn.Text;
                if (textDisplay.Text.Contains(".."))
                {
                    textDisplay.Text = textDisplay.Text.Replace("..", ".");
                }
            }

            textEquation.Text += btn.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 253;
            originalWidth = this.Width;
        }

        private void btn7_Click(object sender, EventArgs e)
        {

        }

        private void btn8_Click(object sender, EventArgs e)
        {

        }
        private void Operator(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (double.TryParse(textDisplay.Text, out firstNumber))
            {
                operation = btn.Text;
                isNewEntry = true;

                textEquation.Text = firstNumber.ToString() + " " + operation + " ";
            }
        }
        private void Total()
        {
            double secondNumber;

            double result = 0;

            if (!double.TryParse(textDisplay.Text, out secondNumber))
                return;

            if (operation == "+")
            {
                result = firstNumber + secondNumber;
            }
            else if (operation == "-")
            {
                result = firstNumber - secondNumber;
            }
            else if (operation == "*")
            {
                result = firstNumber * secondNumber;
            }
            else if (operation == "/")
            {
                if (secondNumber == 0)
                {
                    MessageBox.Show("Cannot divide by zero");
                }
                result = firstNumber / secondNumber;
            }
            textDisplay.Text = result.ToString();
            textEquation.Text += "= " + result.ToString();

            InsertEquationToDatabase(textEquation.Text);
            DisplayDBToTB();

            isNewEntry = true;
        }

        private void InsertEquationToDatabase(string text)
        {
            string connStr = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};";

            string insertQuery = "INSERT INTO tbl_Calculator_History (Equation) VALUES (@equation)";

            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                try
                {
                    conn.Open();
                    OleDbCommand insertCmd = new OleDbCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@equation", textEquation.Text);
                    insertCmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert error: " + ex.Message);
                }
            }
        }
        private void DisplayDBToTB()
        {
            string dbPath = @"C:\LOCALDB\Calculator.accdb";
            string connStr = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};";
            string query = "SELECT equation FROM tbl_Calculator_History order by ID desc";

            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                try
                {
                    conn.Open();
                    OleDbCommand insertCmd = new OleDbCommand(query, conn);
                    OleDbDataReader reader = insertCmd.ExecuteReader();
                    StringBuilder sb = new StringBuilder();

                    while (reader.Read())
                    {
                        string equation = reader["Equation"].ToString();

                        sb.AppendLine(equation);
                    }
                    textstorage.Multiline = true;
                    textstorage.ScrollBars = ScrollBars.Vertical;
                    textstorage.Text = sb.ToString();

                    reader.Close();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: +  ex.Message");
                }

            }
        }
    }
}

