using CalculatorLib;

namespace Session_09 {
    public partial class Form1 : Form {

        private decimal? _value1 = null;
        private decimal? _value2 = null;
        private decimal? _result = null;

        private CalcOperation _calcOperation;

        enum CalcOperation { 
            Addition,
            Subtraction,
            Multiplication,
            Division,
            RaiseToPower,
            Squareroot

        }


        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }


        private void btnThree_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += " 3 ";

            if (_value1 == null)
            {
                _value1 = 3;
            }
            else
            {
                _value2 = 3;
            }

            //-------------------------------------------------------------------------
            switch (_calcOperation) 
            {
                case CalcOperation.Addition:
                    Addition addition = new Addition();
                    _result = addition.Add(_value1, _value2);
                    break;
                case CalcOperation.Subtraction:
                    Subtraction sub = new Subtraction();
                    _result = sub.Subtract(_value1, _value2);
                    break;
                case CalcOperation.Multiplication:
                    Multiplication multi = new Multiplication();
                    _result = multi.Multiply(_value1, _value2);
                    break;
                case CalcOperation.Division:
                    Divide div = new Divide();
                    _result = div.Division(_value1, _value2);
                    break;
                case CalcOperation.Squareroot:
                    SquareRoot sqRoot = new SquareRoot();
                    _result = sqRoot.SqrRoot(_value1);
                    break;
                case CalcOperation.RaiseToPower:
                    RaiseToPower power = new RaiseToPower();
                    _result = power.RaiseToP(_value1, _value2);
                    break;

                default:
                    break;
            }

            ctrlDisplay.Text += _result;
        }

        

        private void btnAddition_Click(object sender, EventArgs e) {
            ctrlDisplay.Text += " + ";
            _calcOperation = CalcOperation.Addition;
        }
        private void btnOne_Click(object sender, EventArgs e)
        {

            if (_result != null)
            {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += " 1 ";

            if (_value1 == null)
            {
                _value1 = 1;
            }
            else
            {
                _value2 = 1;
            }

        }

        private void btnTwo_Click(object sender, EventArgs e) {
            
            if (_result != null) {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += " 2 ";

            if (_value1 == null) {
                _value1 = 2;
            }
            else {
                _value2 = 2;
            }
        }

        

        
    }
}