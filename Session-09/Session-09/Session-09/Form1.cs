using CalculatorLib;
using System.Text.RegularExpressions;

namespace Session_09 {
    public partial class Form1 : Form {

        private decimal? _value1 = null;
        private decimal? _value2 = null;
        private decimal? _result = null;
        int _equalCount = 0;
        private CalcOperation _calcOperation;
        
       
        enum CalcOperation { 
            Addition,
            Subtraction,
            Multiplication,
            Division,
            RaiseToPower,
            Squareroot

        }
       
        public decimal InputCheck(string substring)
        {
            decimal res = 0;
            if (substring.Contains('.'))
            {
                string[] subArr = substring.Split('.');
                res = Convert.ToDecimal(subArr[0] + "." + subArr[1]);
            }
            else res = Convert.ToDecimal(substring);

            return res;
        }
        public decimal CheckSqRoot(string substring)
        {
            decimal res = 0;

            string[] subArr = substring.Split('√');
           // if (subArr[0] != "")    
            res = Convert.ToDecimal(subArr[1]);   //it screws up if you add the Sqroot AFTER the number
            //else res = Convert.ToDecimal(subArr[0]);

            return res;
        }

        public decimal OperatorSpilt(string textboxCalc)
        {
            //'√'
            string sub1,sub2 = String.Empty;             
            if(textboxCalc.Contains('√'))
            {
               _value1 =  CheckSqRoot(textboxCalc);
            }
            else if(ctrlDisplay.Text != string.Empty){
            string[] subArr = textboxCalc.Split('+', '-', '*', '/', '^' );
              
                sub1 = subArr[0];   // sub1 has value 1, unproccessed
                sub2 = subArr[1];   // sub2 has value 2, unproccessed

                _value1 = InputCheck(sub1);
                _value2 = InputCheck(sub2);
                Array.Clear(subArr);
            }
            return 0;
        }
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
        }
        private void btnEqual_Click(object sender, EventArgs e) 
        {
            
            OperatorSpilt(ctrlDisplay.Text);
            switch (_calcOperation) // could I implement it in a different class and get the enum _calcOperation through a form1 object?
            {                       //partial keyword creating problems 
                case CalcOperation.Addition:
                    Addition addition = new Addition();
                    _result = addition.Op(_value1, _value2);
                    break;
                case CalcOperation.Subtraction:
                    Subtraction sub = new Subtraction();
                    _result = sub.Op(_value1, _value2);
                    break;
                case CalcOperation.Multiplication:
                    Multiplication multi = new Multiplication();
                    _result = multi.Op(_value1, _value2);
                    break;
                case CalcOperation.Division:
                    Division div = new Division();
                    _result = div.Op(_value1, _value2);
                    break;
                case CalcOperation.Squareroot:
                    SquareRoot sqRoot = new SquareRoot();
                    _result = sqRoot.Op(_value1);
                    break;
                case CalcOperation.RaiseToPower:
                    RaiseToPower power = new RaiseToPower();
                    _result = power.Op(_value1, _value2);
                    break;

                default:
                    break;
            }
            ctrlDisplay.Text += " = " + _result;
            _equalCount++;
            if ((ctrlDisplay.Text.Contains('=')) && (_equalCount > 1) && (ctrlDisplay.Text == string.Empty))
            { btnEqual.Enabled = false; }                
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

            ctrlDisplay.Text += "1";

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
            ctrlDisplay.Text += "2";

            if (_value1 == null) {
                _value1 = 2;
            }
            else {
                _value2 = 2;
            }
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

            ctrlDisplay.Text += "3";

            if (_value1 == null)
            {
                _value1 = 3;
            }
            else
            {
                _value2 = 3;
            }

        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += "4";

            if (_value1 == null)
            {
                _value1 = 4;
            }
            else
            {
                _value2 = 4;
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += "5";

            if (_value1 == null)
            {
                _value1 = 5;
            }
            else
            {
                _value2 = 5;
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += "6";

            if (_value1 == null)
            {
                _value1 = 6;
            }
            else
            {
                _value2 = 6;
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += "7";

            if (_value1 == null)
            {
                _value1 = 7;
            }
            else
            {
                _value2 = 7;
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += "8";

            if (_value1 == null)
            {
                _value1 = 8;
            }
            else
            {
                _value2 = 8;
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {
                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += "9";

            if (_value1 == null)
            {
                _value1 = 9;
            }
            else
            {
                _value2 = 9;
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " - ";
            _calcOperation = CalcOperation.Subtraction;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {
                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += "0";

            if (_value1 == null)
            {
                _value1 = 0;
            }
            else
            {
                _value2 = 0;
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " * ";
            _calcOperation = CalcOperation.Multiplication;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " /";
            _calcOperation = CalcOperation.Division;
        }

        private void btnSqRoot_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " √";
            _calcOperation = CalcOperation.Squareroot;
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " ^";
            _calcOperation = CalcOperation.RaiseToPower;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text = String.Empty;
            _equalCount = 0;
        }

        private void ctrlDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFloat_Click(object sender, EventArgs e)
        {
            string[] subArrFloat = ctrlDisplay.Text.Split('.');
            if ((!ctrlDisplay.Text.Contains('.')))
            { ctrlDisplay.Text += "."; }
            else 
            {
                if ((subArrFloat.Length < 3)) { ctrlDisplay.Text += "."; }
            }
        }
    }
}