using System.Numerics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        enum Operators
        {
                None,
                Add,
                Subtract,
                Multiply,
                Divide,
                Result
        }
        Operators currentOperator = Operators.None;
        Boolean operatorChangeFlag = false;
        double firstOperand = 0;
        double secondOperand = 0;

        public Form1()
        {

            InitializeComponent();
        }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            secondOperand = double.Parse(Display.Text);
            if(currentOperator == Operators.Add)
            {
                firstOperand += secondOperand;
                Display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Subtract)
            {
                firstOperand -= secondOperand;
                Display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Multiply)
            {
                firstOperand *= secondOperand;
                Display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Divide)
            {
                if(secondOperand == 0)
                {
                    MessageBox.Show("0으로는 나눌 수 없습니다.");
                }
                else
                {
                    firstOperand /= secondOperand;
                    Display.Text = firstOperand.ToString();
                }

            }
        }

        private void ButtonSeven_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "7";
            double doubleNumber = double.Parse(strNumber);
            Display.Text = doubleNumber.ToString();
        }

        private void ButtonEight_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "8";
            double doubleNumber = double.Parse(strNumber);
            Display.Text = doubleNumber.ToString();
        }

        private void ButtonNine_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "9";
            double doubleNumber = double.Parse(strNumber);
            Display.Text = doubleNumber.ToString();
        }

        private void ButtonFour_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "4";
            double doubleNumber = double.Parse(strNumber);
            Display.Text = doubleNumber.ToString();
        }

        private void ButtonFive_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "5";
            double doubleNumber = double.Parse(strNumber);
            Display.Text = doubleNumber.ToString();
        }

        private void ButtonSix_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "6";
            double doubleNumber = double.Parse(strNumber);
            Display.Text = doubleNumber.ToString();

        }

        private void ButtonOne_Click(object sender, EventArgs e)
        {
            if(operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "1";
            double doubleNumber = double.Parse(strNumber);
            Display.Text = doubleNumber.ToString();

        }

        private void ButtonTwo_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "2";
            double doubleNumber = double.Parse(strNumber);
            Display.Text = doubleNumber.ToString();
        }

        private void ButtonThree_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "3";
            double doubleNumber = double.Parse(strNumber);
            Display.Text = doubleNumber.ToString();
        }

        private void ButtonZero_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "0";
            double doubleNumber = double.Parse(strNumber);
            Display.Text = doubleNumber.ToString();
        }

        private void ButtonDot_Click(object sender, EventArgs e)
        {
            if (Display.Text.Contains("."))
                return;

            if (operatorChangeFlag == true)
            {
                Display.Text = "0.";
                operatorChangeFlag = false;
            }
            else
            {
                Display.Text += ".";
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            firstOperand = 0;
            secondOperand = 0;
            currentOperator = Operators.None;
            Display.Text = "0";
        }

        private void ButtonAddition_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(Display.Text);
            currentOperator = Operators.Add;
            operatorChangeFlag = true;
        }

        private void ButtonSubtraction_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(Display.Text);
            currentOperator = Operators.Subtract;
            operatorChangeFlag = true;
        }

        private void ButtonDivsion_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(Display.Text);
            currentOperator = Operators.Divide;
            operatorChangeFlag = true;
        }

        private void ButtonMultiplication_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(Display.Text);
            currentOperator = Operators.Multiply;
            operatorChangeFlag = true;
        }
    }
}
