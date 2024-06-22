namespace Gonzaga_Calculator
{
    public partial class Form1 : Form
    {
        Double numResult = 0;
        String mathOperation = "";
        bool isMathOperation = false;

        public Form1()
        {
            InitializeComponent();
            
          
        }
        private void button_click(object sender, EventArgs e)
        {
            if ((txtField_result.Text == "0") || (isMathOperation))
            {
                txtField_result.Clear();
            }
            isMathOperation=false;
            Button button = (Button)sender;
            if (button.Text == ".") {
                if (!txtField_result.Text.Contains(".")) {
                    txtField_result.Text = txtField_result.Text + button.Text;
                }
            }
            else { 
                txtField_result.Text = txtField_result.Text + button.Text; 
            }

        }

        private void button_operation(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (numResult != 0)
            {
                btn_equal.PerformClick();
                mathOperation = button.Text;
                txtBox_currentInput.Text = numResult + " " + mathOperation;
                isMathOperation = true;
            }
            else {
                mathOperation = button.Text;
                numResult = double.Parse(txtField_result.Text);
                txtBox_currentInput.Text = numResult + " " + mathOperation;
                isMathOperation = true;
            }

        }

        private void button_clearAll(object sender, EventArgs e)
        {
            txtField_result.Clear();
            txtBox_currentInput.Clear();
        }

        private void button_backspace(object sender, EventArgs e)
        {
            if (txtField_result.Text.Length > 0)
            {
                txtField_result.Text = txtField_result.Text.Substring(0, txtField_result.Text.Length - 1);
            }
        }

        private void button_solve(object sender, EventArgs e)
        {
            switch (mathOperation)
            {
                case "+":
                    txtField_result.Text = (numResult + Double.Parse(txtField_result.Text)).ToString();
                    break;
                case "-":
                    txtField_result.Text = (numResult - Double.Parse(txtField_result.Text)).ToString();
                    break;
                case "*":
                    txtField_result.Text = (numResult * Double.Parse(txtField_result.Text)).ToString();
                    break;
                case "/":
                    txtField_result.Text = (numResult / Double.Parse(txtField_result.Text)).ToString();
                    break;
                default:
                    break;
            }

            numResult = Double.Parse(txtField_result.Text);
            txtBox_currentInput.Text = "";
        }
    }
}
