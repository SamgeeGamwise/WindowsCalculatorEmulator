using System.Globalization;

namespace WinFormsAppTest
{
    public partial class Calculator : Form
    {
        const int MAX_LENGTH = 16;

        public Calculator()
        {
            InitializeComponent();
            operandOne = 0;
            operandTwo = 0;
            total = 0;
            symbol = "+";
            isFirst = true;
            hasDecimal = false;
            calculated = false;
            displayTotal(total);
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void reset()
        {
            operandOne = 0;
            operandTwo = 0;
            total = 0;
            symbol = "+";
            isFirst = true;
            hasDecimal = false;
            calculated = false;
            hideFullCalculation();
            displayTotal(total);
        }

        private void concatenateNumber(ref decimal operand, string number)
        {


            if (operand.ToString().Length >= MAX_LENGTH)
            {
                return;
            }
            else if (hasDecimal && operand % 1 == 0)
            {
                if (operand.ToString().Contains("."))
                {
                    operand = Decimal.Parse(operand.ToString() + number);
                }
                else
                {
                    operand = Decimal.Parse(operand.ToString() + "." + number);

                }
                displayTotal(operand, true);
                return;
            }
            else if (operand == 0)
            {
                operand = Decimal.Parse(number);
            }
            else
            {
                operand = Decimal.Parse(operand.ToString() + number);
            }
            displayTotal(operand);
        }

        private void numericButton_Click(object sender, EventArgs e)
        {
            string number = (sender as Button).Text ?? "0";

            if (isFirst)
            {
                if (calculated)
                {
                    operandOne = 0;
                    calculated = false;
                }
                concatenateNumber(ref operandOne, number);
            }
            else
            {
                if (calculated)
                {
                    operandTwo = 0;
                    calculated = false;
                }
                concatenateNumber(ref operandTwo, number);
            }
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            symbol = "÷";
            displayOperation();
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            symbol = "×";
            displayOperation();
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            symbol = "-";
            displayOperation();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            symbol = "+";
            displayOperation();
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            try
            {
                total = symbol switch
                {
                    "÷" => operandOne / operandTwo,
                    "×" => operandOne * operandTwo,
                    "-" => operandOne - operandTwo,
                    "+" => operandOne + operandTwo,
                    _ => 0
                };

                displayCalculation();
                operandOne = total;
                calculated = true;
            }
            catch (OverflowException)
            {
                reset();
                display.Font = new Font("Segoe UI", 24, FontStyle.Bold);
                display.Text = "Number too large";
            }
            catch (DivideByZeroException)
            {
                reset();
                display.Font = new Font("Segoe UI", 20, FontStyle.Bold);
                display.Text = "Cannot divide by zero";
            }
            catch (Exception)
            {
                reset();
                display.Font = new Font("Segoe UI", 30, FontStyle.Bold);
                display.Text = "Error!";
            }
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            if (!hasDecimal)
            {
                hasDecimal = true;

                if (!isFirst && (operandTwo == 0 || calculated))
                {
                    display.Text = "0.";
                }
                else
                {
                    display.Text += ".";
                }
            }
        }

        private void deleteCharacter(ref decimal operand)
        {
            if (operand != 0)
            {
                string operandString = operand.ToString();
                if (operandString.Length > 1)
                {
                    operand = decimal.Parse(operandString.Remove(operandString.Length - 1, 1));
                }
                else
                {
                    operand = 0;
                }
            }
            displayTotal(operand);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                deleteCharacter(ref operandOne);
            }
            else
            {
                deleteCharacter(ref operandTwo);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void clearEntryButton_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                operandOne = 0;
                hideFullCalculation();
                displayTotal(operandOne);
            }
            else
            {
                operandTwo = 0;
                displayTotal(operandTwo);
            }
        }

        private void displayTotal(decimal number, bool trailing = false)
        {
            fontChange(number.ToString());
            display.Text = displayDecimal(number, true, trailing);
        }

        private void displayOperation()
        {
            string displayText = displayDecimal(operandOne) + " " + symbol;
            fontChange(displayText.ToString());
            calculationDisplay.Text = displayText;
            isFirst = false;
            hasDecimal = false;
        }

        private void displayCalculation()
        {
            string displayText = displayDecimal(operandOne) + " " + symbol + " " + displayDecimal(operandTwo) + " =";
            calculationDisplay.Text = displayText;
            displayTotal(total);
            hasDecimal = !(total % 1 == 0);
        }

        private void hideFullCalculation()
        {
            fontChange("");
            calculationDisplay.Text = "";
        }

        private string displayDecimal(decimal value, bool commas = false, bool trailing = false)
        {
            try
            {
                decimal roundedValue = Decimal.Round(value, MAX_LENGTH - (((int)value).ToString().Length + 1));

            if (roundedValue.ToString().Length > MAX_LENGTH)
            {
                return value.ToString("e11", CultureInfo.InvariantCulture);
            }
            else
            {

                if (value % 1 == 0)
                {

                     if (commas && trailing)
                    {
                        return roundedValue.ToString();
                    }
                    else if (commas)
                    {
                        return String.Format("{0:n0}", roundedValue);

                    }
                    else
                    {
                        return roundedValue.ToString();
                    }
                }
                else
                {
                    return normalize(roundedValue).ToString();
                }

            }
        }
            catch (Exception)
            {
                return value.ToString("e11", CultureInfo.InvariantCulture);
            }
}

        private static decimal normalize(decimal value)
        {
            return value / 1.000000000000000000000000000000000m;
        }

        private void fontChange(string displayValue)
        {
            int length = displayValue.Length;

            switch (length)
            {
                case int when length >= MAX_LENGTH:
                    display.Font = new Font("Segoe UI", 21, FontStyle.Bold);
                    break;
                case int when length == (MAX_LENGTH - 1):
                    display.Font = new Font("Segoe UI", 22.5f, FontStyle.Bold);
                    break;
                case int when length == (MAX_LENGTH - 2):
                    display.Font = new Font("Segoe UI", 24, FontStyle.Bold);
                    break;
                case int when length == (MAX_LENGTH - 3):
                    display.Font = new Font("Segoe UI", 25.5f, FontStyle.Bold);
                    break;
                case int when length == (MAX_LENGTH - 4):
                    display.Font = new Font("Segoe UI", 27, FontStyle.Bold);
                    break;
                case int when length == (MAX_LENGTH - 5):
                    display.Font = new Font("Segoe UI", 28.5f, FontStyle.Bold);
                    break;
                case int when length < (MAX_LENGTH - 6):
                    display.Font = new Font("Segoe UI", 30, FontStyle.Bold);
                    break;
            }
        }
    }
}