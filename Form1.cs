namespace เครือ่งคิดเลข
{
    public partial class Form1 : Form
    {
        double num1,num3 =0 ;
        double num2 = 0;
        string op = "";
    public Form1()
        {
            InitializeComponent();
        }

        public Form1(double num2)
        {
            this.num2 = num2;
        }

        // 7
        private void button1_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "7";
            Display2.Text = Display2.Text + "7";
        }
        // 8
        private void button2_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "8";
            Display2.Text = Display2.Text + "8";
        }
        // 9
        private void button3_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "9";
            Display2.Text = Display2.Text + "9";
        }
      
        private void button11_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + ".";
            Display2.Text = Display2.Text + ".";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "6";
            Display2.Text = Display2.Text + "6";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "5";
            Display2.Text = Display2.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "4";
            Display2.Text = Display2.Text + "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "3";
            Display2.Text = Display2.Text + "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "2";
            Display2.Text = Display2.Text + "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(Display.Text);
            Display.Text = "";
            Display2.Text =Display2.Text+"+";
            op = "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(Display.Text);
            Display.Text = "";
            Display2.Text = Display2.Text + "-";
            op = "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(Display.Text);
            Display.Text = "";
            Display2.Text = Display2.Text + "x";
            op = "x";
        }

        private void button16_Click(object sender, EventArgs e)
        {

            num1 = double.Parse(Display.Text);
            Display.Text = "";
            Display2.Text = Display2.Text + "÷";
            op = "÷";
        }
        
        private void button17_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(Display.Text);
           
            this.Display2.Text = num1 + op + num2 + "=";
            if (op == "+")
            {
                num3 = num1 + num2;
                Display.Text = num3.ToString("N2");
            }
            if (op == "-")
            {
                num3 = num1 - num2;
                Display.Text = num3.ToString("N2");
            }
            if (op == "x")
            {
                num3 = num1 * num2;
                Display.Text = num3.ToString("N2");
            }
            if (op == "÷")
            {
                num3 = num1 / num2;
                Display.Text = num3.ToString("N2");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            Display2.Text = "";
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "1";
            Display2.Text = Display2.Text + "1";
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "0";
            Display2.Text = Display2.Text + "0";
        }
       
    }

}