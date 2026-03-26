namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        private double firstNumber = 0;
        private string operation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void HandleNumberInput(string digit)
        {
            if (txtInputWindow.Text == "0")
                txtInputWindow.Text = digit;
            else
                txtInputWindow.Text += digit;
        }

        private void btnNum0_Click(object sender, EventArgs e) { HandleNumberInput("0"); }
        private void btnNum1_Click(object sender, EventArgs e) { HandleNumberInput("1"); }
        private void btnNum2_Click(object sender, EventArgs e) { HandleNumberInput("2"); }
        private void btnNum3_Click(object sender, EventArgs e) { HandleNumberInput("3"); }
        private void btnNum4_Click(object sender, EventArgs e) { HandleNumberInput("4"); }
        private void btnNum5_Click(object sender, EventArgs e) { HandleNumberInput("5"); }
        private void btnNum6_Click(object sender, EventArgs e) { HandleNumberInput("6"); }
        private void btnNum7_Click(object sender, EventArgs e) { HandleNumberInput("7"); }
        private void btnNum8_Click(object sender, EventArgs e) { HandleNumberInput("8"); }
        private void btnNum9_Click(object sender, EventArgs e) { HandleNumberInput("9"); }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(txtInputWindow.Text);
            operation = "+";
            txtInputWindow.Text += "+";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(txtInputWindow.Text);
            operation = "-";
            txtInputWindow.Text += "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(txtInputWindow.Text);
            operation = "×";
            txtInputWindow.Text += "×";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(txtInputWindow.Text);
            operation = "÷";
            txtInputWindow.Text += "÷";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            string input = txtInputWindow.Text;
            double result = 0;

            if (input.Contains("+"))
            {
                string[] parts = input.Split('+');
                result = double.Parse(parts[0]) + double.Parse(parts[1]);
            }
            else if (input.Contains("-"))
            {
                string[] parts = input.Split('-');
                result = double.Parse(parts[0]) - double.Parse(parts[1]);
            }
            else if (input.Contains("×"))
            {
                string[] parts = input.Split('×');
                result = double.Parse(parts[0]) * double.Parse(parts[1]);
            }
            else if (input.Contains("÷"))
            {
                string[] parts = input.Split('÷');
                if (double.Parse(parts[1]) == 0)
                {
                    txtOutputWindow.Text = "0으로 나눌 수 없음";
                    return;
                }
                result = double.Parse(parts[0]) / double.Parse(parts[1]);
            }

            txtInputWindow.Text += "=" + result.ToString();
            txtOutputWindow.Text = result.ToString();
        }

        private void btnFuncC_Click(object sender, EventArgs e)
        {
            txtInputWindow.Text = "0";
            txtOutputWindow.Text = "0";
        }

        private void btnFuncCE_Click(object sender, EventArgs e)
        {
            string input = txtInputWindow.Text;

            if (input.Contains("+"))
            {
                txtInputWindow.Text = input.Substring(0, input.IndexOf('+') + 1);
            }
            else if (input.Contains("-"))
            {
                txtInputWindow.Text = input.Substring(0, input.IndexOf('-') + 1);
            }
            else if (input.Contains("×"))
            {
                txtInputWindow.Text = input.Substring(0, input.IndexOf('×') + 1);
            }
            else if (input.Contains("÷"))
            {
                txtInputWindow.Text = input.Substring(0, input.IndexOf('÷') + 1);
            }
            else
            {
                txtInputWindow.Text = "0";
            }
        }



        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void button4_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void btnFuncDel_Click(object sender, EventArgs e)
        {
            string input = txtInputWindow.Text;

            if (input.Length > 1)
                txtInputWindow.Text = input.Substring(0, input.Length - 1);
            else
                txtInputWindow.Text = "0";
        }
    }
}
