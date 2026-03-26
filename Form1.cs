namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
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


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //txtInputWindow.Text = "0";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //txtOutputWindow.Text = "0";
        }
    }
}
