namespace Calculator
{
    public partial class Form1 : Form
    {
       
        double result = 0;
        string ope = "";
        bool opepending = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            if ((TxtBox1.Text == "0") || opepending)
                TxtBox1.Clear();

            opepending = false;
            Button one = (Button)sender;
            if (one.Text == ".")
            {
                if (!TxtBox1.Text.Contains("."))
                    TxtBox1.Text += one.Text;
            }
            else
            {
                TxtBox1.Text += one.Text;
            }
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            if ((TxtBox1.Text == "0") || opepending)
                TxtBox1.Clear();

            opepending = false;
            Button two = (Button)sender;
            if (two.Text == ".")
            {
                if (!TxtBox1.Text.Contains("."))
                    TxtBox1.Text += two.Text;
            }
            else
            {
                TxtBox1.Text += two.Text;
            }
        }

        private void BtnThree_Click(object sender, EventArgs e)
        {
            if ((TxtBox1.Text == "0") || opepending)
                TxtBox1.Clear();

            opepending = false;
            Button three = (Button)sender;
            if (three.Text == ".")
            {
                if (!TxtBox1.Text.Contains("."))
                    TxtBox1.Text += three.Text;
            }
            else
            {
                TxtBox1.Text += three.Text;
            }
        }

        private void BtnFour_Click(object sender, EventArgs e)
        {
            if ((TxtBox1.Text == "0") || opepending)
                TxtBox1.Clear();

            opepending = false;
            Button four = (Button)sender;
            if (four.Text == ".")
            {
                if (!TxtBox1.Text.Contains("."))
                    TxtBox1.Text += four.Text;
            }
            else
            {
                TxtBox1.Text += four.Text;
            }
        }

        private void BtnFive_Click(object sender, EventArgs e)
        {
            if ((TxtBox1.Text == "0") || opepending)
                TxtBox1.Clear();

            opepending = false;
            Button five = (Button)sender;
            if (five.Text == ".")
            {
                if (!TxtBox1.Text.Contains("."))
                    TxtBox1.Text += five.Text;
            }
            else
            {
                TxtBox1.Text += five.Text;
            }
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {
            if ((TxtBox1.Text == "0") || opepending)
                TxtBox1.Clear();

            opepending = false;
            Button six = (Button)sender;
            if (six.Text == ".")
            {
                if (!TxtBox1.Text.Contains("."))
                    TxtBox1.Text += six.Text;
            }
            else
            {
                TxtBox1.Text += six.Text;
            }
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {
            if ((TxtBox1.Text == "0") || opepending)
                TxtBox1.Clear();

            opepending = false;
            Button seven = (Button)sender;
            if (seven.Text == ".")
            {
                if (!TxtBox1.Text.Contains("."))
                    TxtBox1.Text += seven.Text;
            }
            else
            {
                TxtBox1.Text += seven.Text;
            }
        }

        private void BtnEight_Click(object sender, EventArgs e)
        {
            if ((TxtBox1.Text == "0") || opepending)
                TxtBox1.Clear();

            opepending = false;
            Button eight = (Button)sender;
            if (eight.Text == ".")
            {
                if (!TxtBox1.Text.Contains("."))
                    TxtBox1.Text += eight.Text;
            }
            else
            {
                TxtBox1.Text += eight.Text;
            }
        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            if ((TxtBox1.Text == "0") || opepending)
                TxtBox1.Clear();

            opepending = false;
            Button nine = (Button)sender;
            if (nine.Text == ".")
            {
                if (!TxtBox1.Text.Contains("."))
                    TxtBox1.Text += nine.Text;
            }
            else
            {
                TxtBox1.Text += nine.Text;
            }
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {
            if ((TxtBox1.Text == "0") || opepending)
                TxtBox1.Clear();

            opepending = false;
            Button zero = (Button)sender;
            if (zero.Text == ".")
            {
                if (!TxtBox1.Text.Contains("."))
                    TxtBox1.Text += zero.Text;
            }
            else
            {
                TxtBox1.Text += zero.Text;
            }
        }

        private void BtnDecimal_Click(object sender, EventArgs e)
        {
            if ((TxtBox1.Text == "0") || opepending)
                TxtBox1.Clear();

            opepending = false;
            Button dot = (Button)sender;
            if (dot.Text == ".")
            {
                if (!TxtBox1.Text.Contains("."))
                    TxtBox1.Text += dot.Text;
            }
            else
            {
                TxtBox1.Text += dot.Text;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Button add = (Button)sender;
            ope = add.Text;
            result = double.Parse(TxtBox1.Text);
            opepending = true;

        }

        private void BtnErase_Click(object sender, EventArgs e)
        {
            if (TxtBox1.Text.Length > 0)
            {
                TxtBox1.Text = TxtBox1.Text.Remove(TxtBox1.Text.Length - 1, 1);
                if (TxtBox1.Text == "")
                    TxtBox1.Text = "0";

            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtBox1.Text = "0";
            TxtBox2.Text = " ";
            result = 0;
            ope = "";

        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            switch (ope)
            {
                case "+":
                    TxtBox1.Text = (result + double.Parse(TxtBox1.Text)).ToString();
                    break;
                case "-":
                    TxtBox1.Text = (result - double.Parse(TxtBox1.Text)).ToString();
                    break;
                case "*":
                    TxtBox1.Text = (result * double.Parse(TxtBox1.Text)).ToString();
                    break;
                case "/":
                    if (double.Parse(TxtBox1.Text) == 0)
                    {
                        MessageBox.Show("Cannot divide by zero!");
                        TxtBox1.Text = "0";
                    }
                    else
                    {
                        TxtBox1.Text = (result / double.Parse(TxtBox1.Text)).ToString();
                    }
                    break;
            }
            result = double.Parse(TxtBox1.Text);
            ope = "";
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            Button sub = (Button)sender;
            ope = sub.Text;
            result = double.Parse(TxtBox1.Text);
            opepending = true;

        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            Button mul = (Button)sender;
            ope = mul.Text;
            result = double.Parse(TxtBox1.Text);
            opepending = true;
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            Button divide = (Button)sender;
            ope = divide.Text;
            result = double.Parse(TxtBox1.Text);
            opepending = true;
        }

        private void BtnINClear_Click(object sender, EventArgs e)
        {
            TxtBox1.Text = " ";
        }

        private void BtnPercent_Click(object sender, EventArgs e)
        {
            TxtBox1.Text = (double.Parse(TxtBox1.Text) / 100).ToString();
        }
    }
}
