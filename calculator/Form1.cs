namespace calculator
{
    public partial class Form1 : Form
    {
        string total;
        int num1;
        int num2;
        String option;
        int result;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + button1.Text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + button2.Text;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + button8.Text;
        }

      

        private void button11_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(txt.Text);
            txt.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(txt.Text);
            txt.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            
                txt.Text = txt.Text + button3.Text;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + button7.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            option = "+";
            num1= int.Parse(txt.Text);
            txt.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(txt.Text);
            txt.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num2=int.Parse(txt.Text);

            if (option== "+")
            {
                result = num1 + num2;
            }
            if (option == "-")
            {
                result = num1 - num2;
            }
            if (option == "*")
            {
                result = num1 * num2;
            }
            if (option == "/")
            {
                result = num1 / num2;
            }
            txt.Clear();
            txt.Text = result + "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            txt.Clear();
        }
    }
}