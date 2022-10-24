namespace Calculator
{
    public partial class Form1 : Form
    {
        private string num1 = "";
        private string sign = "";
        private string num2 = "";
        private float? result = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateTextBox() 
        {
            string resultString = num1.ToString();
            if (sign != ""){
                resultString += " " + sign;
                if (num2 != ""){
                    resultString += " " + num2;
                    if (result != null)
                        resultString += " = " + result.ToString();
                }
            }

            textBox.Text = resultString;
        }

        public void NumberButtonClick(object? sender, EventArgs e) 
        {
            string? buttonText =  (sender as Button)?.Text;

            float number = 0;

            if (result == null && float.TryParse(buttonText, out number))
            {
                //Работа над первым числом
                if (sign == ""){
                    if (num1.Length > 0 && num1[0] == '0') num1 = buttonText;
                    else num1 += buttonText;
                }

                //Работа над вторым числом
                else{
                    if (num2.Length > 0 && num2[0] == '0') num2 = buttonText;
                    else num2 += buttonText;
                }

                UpdateTextBox();
            }
        }

        private void GetResult() 
        {
            if (num1.Length > 0 && sign.Length > 0 && num2.Length > 0)
            {
                switch (sign)
                {
                    case "+":
                        result = float.Parse(num1) + float.Parse(num2);
                        break;
                    case "-":
                        result = float.Parse(num1) - float.Parse(num2);
                        break;
                    case "*":
                        result = float.Parse(num1) * float.Parse(num2);
                        break;
                    case "/":
                        result = float.Parse(num1) / float.Parse(num2);
                        break;
                }
            }
        }

        private void ChangeSign(string sign) 
        {
            if (result != null) 
            {
                num1 = result.ToString() ?? "";
                num2 = "";
                this.sign = "";
                result = null;
            }

            if (num2.Length == 0) 
                this.sign = sign;
        }

        private void SpecialButtonClick(object? sender, EventArgs e)
        {
            string? buttonText = (sender as Button)?.Text;

            switch (buttonText)
            {
                case "=":
                    GetResult();
                    break;

                case "CE":
                    num1 = num2 = sign = "";
                    result = null;
                    break;

                case "C":
                    if (sign == "" && num1.Length > 0) num1 = num1.Remove(num1.Length - 1);
                    else if (sign != "" && num2.Length == 0) sign = "";
                    else if (num2.Length > 0 && result == null) num2 = num2.Remove(num2.Length - 1);
                    if (result != null) result = null;
                    break;

                case "+":
                    ChangeSign("+");
                    break;
                case "-":
                    ChangeSign("-");
                    break;
                case "/":
                    ChangeSign("/");
                    break;
                case "*":
                    ChangeSign("*");
                    break;
            }

            UpdateTextBox();
        }
    }
}