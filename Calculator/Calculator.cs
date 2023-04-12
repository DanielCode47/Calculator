using System.Runtime.CompilerServices;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private Rectangle buttonOriginalRectangle;
        private Rectangle originalFormSize;

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
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            buttonOriginalRectangle = new Rectangle(TxtBox.Location.X, TxtBox.Location.Y, TxtBox.Width, TxtBox.Size.Height);
            buttonOriginalRectangle = new Rectangle(ClearBtn.Location.X, ClearBtn.Location.Y, ClearBtn.Width, ClearBtn.Height);
            buttonOriginalRectangle = new Rectangle(MinusBtn.Location.X, MinusBtn.Location.Y, MinusBtn.Width, MinusBtn.Height);
            buttonOriginalRectangle = new Rectangle(PlusBtn.Location.X, PlusBtn.Location.Y, PlusBtn.Width, PlusBtn.Height);
            buttonOriginalRectangle = new Rectangle(DevideBtn.Location.X, DevideBtn.Location.Y, DevideBtn.Width, DevideBtn.Height);
            buttonOriginalRectangle = new Rectangle(MultiplyBtn.Location.X, MultiplyBtn.Location.Y, MultiplyBtn.Width, MultiplyBtn.Height);
            buttonOriginalRectangle = new Rectangle(ModuleBtn.Location.X, ModuleBtn.Location.Y, ModuleBtn.Width, ModuleBtn.Size.Height);
            buttonOriginalRectangle = new Rectangle(EqualBtn.Location.X, EqualBtn.Location.Y, EqualBtn.Width, EqualBtn.Size.Height);
            buttonOriginalRectangle = new Rectangle(DotBtn.Location.X, DotBtn.Location.Y, DotBtn.Width, DotBtn.Size.Height);
            buttonOriginalRectangle = new Rectangle(ZeroBtn.Location.X, ZeroBtn.Location.Y, ZeroBtn.Width, ZeroBtn.Size.Height);
            buttonOriginalRectangle = new Rectangle(OneBtn.Location.X, OneBtn.Location.Y, OneBtn.Width, OneBtn.Size.Height);
            buttonOriginalRectangle = new Rectangle(TwoBtn.Location.X, TwoBtn.Location.Y, TwoBtn.Width, TwoBtn.Size.Height);
            buttonOriginalRectangle = new Rectangle(ThreeBtn.Location.X, ThreeBtn.Location.Y, ThreeBtn.Width, ThreeBtn.Size.Height);
            buttonOriginalRectangle = new Rectangle(FourBtn.Location.X, FourBtn.Location.Y, FourBtn.Width, FourBtn.Size.Height);
            buttonOriginalRectangle = new Rectangle(FiveBtn.Location.X, FiveBtn.Location.Y, FiveBtn.Width, FiveBtn.Size.Height);
            buttonOriginalRectangle = new Rectangle(SixBtn.Location.X, SixBtn.Location.Y, SixBtn.Width, SixBtn.Size.Height);
            buttonOriginalRectangle = new Rectangle(SevenBtn.Location.X, SevenBtn.Location.Y, SevenBtn.Width, SevenBtn.Size.Height);
            buttonOriginalRectangle = new Rectangle(EightBtn.Location.X, EightBtn.Location.Y, EightBtn.Width, EightBtn.Size.Height);
            buttonOriginalRectangle = new Rectangle(NineBtn.Location.X, NineBtn.Location.Y, NineBtn.Width, NineBtn.Size.Height);


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

        private void EightBtn_Resize(object sender, EventArgs e)
        {

        }

        private void ResizeControl(Rectangle r, Control c, Button clearBtn)
        {
            float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);

            int newX = (int)(r.Width * xRatio);
            int newY = (int)(r.Height * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void Calculator_Resize(object sender, EventArgs e)
        {
            ResizeControl(buttonOriginalRectangle, ClearBtn);
        }
    }
}