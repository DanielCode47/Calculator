using System.Runtime.CompilerServices;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private decimal _valueFirst = 0.0m;
        private decimal _valueSecond = 0.0m;
        private decimal _Result = 0.0m;
        private string _operators = "+";
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "1";
            }
            else
            {
                TxtBox.Text += "1";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            _valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            _operators = "*";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            _valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            _operators = "%";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            _valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            _operators = "+";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            _valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            _operators = "-";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            _valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            _operators = "/";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text.Contains("-"))
            {
                TxtBox.Text = TxtBox.Text.Trim('-');
            }
            else
            {
                TxtBox.Text = "-" + TxtBox.Text;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            _valueFirst = 0.0m;
            _valueSecond = 0.0m;
            TxtBox.Text = "0";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "0";
            }
            else
            {
                TxtBox.Text += "0";
            }
        }

        private void DotBtn_Click(object sender, EventArgs e)
        {
            if (!TxtBox.Text.Contains("."))
            {
                TxtBox.Text += ".";
            }
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "2";
            }
            else
            {
                TxtBox.Text += "2";
            }
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "3";
            }
            else
            {
                TxtBox.Text += "3";
            }
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "4";
            }
            else
            {
                TxtBox.Text += "4";
            }
        }

        private void FIveBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "5";
            }
            else
            {
                TxtBox.Text += "5";
            }
        }

        private void SIxBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "6";
            }
            else
            {
                TxtBox.Text += "6";
            }
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "7";
            }
            else
            {
                TxtBox.Text += "7";
            }
        }

        private void EIghtBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "8";
            }
            else
            {
                TxtBox.Text += "8";
            }
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "9";
            }
            else
            {
                TxtBox.Text += "9";
            }
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            switch (_operators) 
            {
                case "-":
                    _valueSecond = decimal.Parse(TxtBox.Text);
                    _Result = _valueFirst - _valueSecond;
                    TxtBox.Text = _Result.ToString();
                    break;

                case "+":
                    _valueSecond = decimal.Parse(TxtBox.Text);
                    _Result = _valueFirst + _valueSecond;
                    TxtBox.Text = _Result.ToString();
                    break;

                case "*":
                    _valueSecond = decimal.Parse(TxtBox.Text);
                    _Result = _valueFirst * _valueSecond;
                    TxtBox.Text = _Result.ToString();
                    break;

                case "/":
                    _valueSecond = decimal.Parse(TxtBox.Text);
                    _Result = _valueFirst / _valueSecond;
                    TxtBox.Text = _Result.ToString();
                    break;

                case "%":
                    _valueSecond = decimal.Parse(TxtBox.Text);
                    _Result = _valueFirst % _valueSecond;
                    TxtBox.Text = _Result.ToString();
                    break;
            }
        }
    }
}