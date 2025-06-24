namespace Calculator
{
    public partial class Form1 : Form
    {
        string input = "";
        double result = 0;
        string ope = "";
        bool opepending = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            TxtBox1.Text = input;
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            TxtBox1.Text = input;
        }

        private void BtnThree_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            TxtBox1.Text = input;
        }

        private void BtnFour_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            TxtBox1.Text = input;
        }

        private void BtnFive_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            TxtBox1.Text = input;
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            TxtBox1.Text = input;
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            TxtBox1.Text = input;
        }

        private void BtnEight_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            TxtBox1.Text = input;
        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            TxtBox1.Text = input;
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            TxtBox1.Text = input;
        }

        private void BtnDecimal_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            TxtBox1.Text = input;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (opepending)
            {
                ComputeResult();
            }
            Button button = (Button)sender;
            ope = button.Text;
            result = double.Parse(input);
            input = "";
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
            opepending = false;

        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            ComputeResult();
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            if (opepending)
            {
                ComputeResult();
            }
            Button button = (Button)sender;
            ope = button.Text;
            result = double.Parse(input);
            input = "";
            opepending = true;

        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            if (opepending)
            {
                ComputeResult();
            }
            Button button = (Button)sender;
            ope = button.Text;
            result = double.Parse(input);
            input = "";
            opepending = true;
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            if (opepending)
            {
                ComputeResult();
            }
            Button button = (Button)sender;
            ope = button.Text;
            result = double.Parse(input);
            input = "";
            opepending = true;
        }

        private void BtnINClear_Click(object sender, EventArgs e)
        {
            TxtBox1.Text = " ";
        }

        private void BtnPercent_Click(object sender, EventArgs e)
        {
            
        }

        private void ComputeResult()
        {
            if (opepending)
            {
                double secondNum = double.Parse(input);
                switch (ope)
                {
                    case "add":
                        result += secondNum;
                        break;
                    case "sub":
                        result -= secondNum;
                        break;
                    case "mul":
                        result *= secondNum;
                        break;
                    case "/":
                        if (secondNum != 0)
                        {
                            result /= secondNum;
                        }
                        else
                        {
                            TxtBox1.Text = "Cannot divide by zero";
                            return;
                        }
                        break;
                }

                TxtBox1.Text = result.ToString();
                input = "";
                opepending = false;
            }
        }
    }
}
