namespace WinFormsAppTest
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            total = "0";
            calculationNumber = "0";
            grandTotal = "0";
            firstNumber = true;
            this.displayTotal(total);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void displayTotal(string number)
        {
            this.display.Text = String.Format("{0:n0}", decimal.Parse(number));
        }

        private void displayCalculation()
        {
            this.calculationDisplay.Text = String.Format("{0:n0}", decimal.Parse(total)) + " " + symbol;
        }

        private void displayFullCalculation()
        {
            this.calculationDisplay.Text = String.Format("{0:n0}", decimal.Parse(total)) + " " + symbol + " " + String.Format("{0:n0}", decimal.Parse(calculationNumber)) + " =";
            this.display.Text = String.Format("{0:n0}", decimal.Parse(grandTotal));
        }

        private void numericButton_Click(object sender, EventArgs e)
        {
            string number = (sender as Button).Text;

            if (number != null)
            {
                if (firstNumber)
                {
                    if (total == "0")
                    {
                        total = number;
                    }
                    else
                    {
                        total += number;
                    }
                    this.displayTotal(total);

                }
                else
                {
                    if (calculationNumber == "0")
                    {
                        calculationNumber = number;
                    }
                    else
                    {
                        calculationNumber += number;
                    }
                    this.displayTotal(calculationNumber);
                }
            }
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            this.symbol = "÷";
            this.displayCalculation();
            this.firstNumber = false;
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            this.symbol = "×";
            this.displayCalculation();
            this.firstNumber = false;
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            this.symbol = "–";
            this.displayCalculation();
            this.firstNumber = false;
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            this.symbol = "+";
            this.displayCalculation();
            this.firstNumber = false;
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            switch (this.symbol)
            {
                case "÷":
                    grandTotal = String.Format("{0:n0}", decimal.Parse(total) / decimal.Parse(calculationNumber));
                    break;
                case "×":
                    grandTotal = String.Format("{0:n0}", decimal.Parse(total) * decimal.Parse(calculationNumber));
                    break;
                case "–":
                    grandTotal = String.Format("{0:n0}", decimal.Parse(total) - decimal.Parse(calculationNumber));
                    break;
                case "+":
                    grandTotal = String.Format("{0:n0}", decimal.Parse(total) + decimal.Parse(calculationNumber));
                    break;
            }
            this.displayFullCalculation();
            this.total = this.grandTotal;
            this.calculationNumber = "0";
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {

        }


        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {

        }
    }
}