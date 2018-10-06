/*
Alec Hislop
P452289

PROGRAMMING III
Portfolio Activity 1.7 - Math Library

Version History
v1.00 (this version) - 30/09/2018

Main calculator class.

The user can input digits by keystroke or by clicking the virtual keypad GUI.
The user can select functions by clicking on the virtual keypad.
The user's input is parsed for validity before any calculations commence.
The calculator supports e-notation with e+n and e-n (e.g. 1.61e-35 and 1.42e+32)
*/

using System;
using System.Windows.Forms;
using MathTrigonometry;
using MathArithmetic;
using MathAlgebra;

namespace p452289
{
    public partial class Calculator : Form
    {
        bool btnPlusClicked = false;
        bool btnMinusClicked = false;
        bool btnDivideClicked = false;
        bool btnMultiplyClicked = false;
        bool btnInverseClicked = false;
        bool btnSquareRootClicked = false;
        bool btnCubeRootClicked = false;
        bool btnTanClicked = false;
        bool btnSinClicked = false;
        bool btnCosClicked = false;
        bool canParse = false;
        
        double temp = 0;
        double input = 0;
        double output;

        public Calculator()
        {
            InitializeComponent();
        }

        #region Buttons - Digits
        private void btn0_Click(object sender, EventArgs e)
        {
            txtboxInputOutput.AppendText("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtboxInputOutput.AppendText("1");
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            txtboxInputOutput.AppendText("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtboxInputOutput.AppendText("3");
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            txtboxInputOutput.AppendText("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtboxInputOutput.AppendText("5");
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            txtboxInputOutput.AppendText("6");
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            txtboxInputOutput.AppendText("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtboxInputOutput.AppendText("8");
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            txtboxInputOutput.AppendText("9");
        }
        #endregion

        #region Buttons - Operators
        private void btnDot_Click(object sender, EventArgs e)
        {
            txtboxInputOutput.AppendText(".");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            temp = 0;

            btnPlusClicked = true;
            btnMinusClicked = false;
            btnDivideClicked = false;
            btnMultiplyClicked = false;
            btnInverseClicked = false;
            btnSquareRootClicked = false;
            btnCubeRootClicked = false;
            btnTanClicked = false;
            btnSinClicked = false;
            btnCosClicked = false;

            temp = Parser(txtboxInputOutput.Text);
            txtboxInputOutput.Text = "";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            temp = 0;

            btnPlusClicked = false;
            btnMinusClicked = true;
            btnDivideClicked = false;
            btnMultiplyClicked = false;
            btnInverseClicked = false;
            btnSquareRootClicked = false;
            btnCubeRootClicked = false;
            btnTanClicked = false;
            btnSinClicked = false;
            btnCosClicked = false;

            temp = Parser(txtboxInputOutput.Text);
            txtboxInputOutput.Text = "";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            temp = 0;

            btnPlusClicked = false;
            btnMinusClicked = false;
            btnDivideClicked = true;
            btnMultiplyClicked = false;
            btnInverseClicked = false;
            btnSquareRootClicked = false;
            btnCubeRootClicked = false;
            btnTanClicked = false;
            btnSinClicked = false;
            btnCosClicked = false;

            temp = Parser(txtboxInputOutput.Text);
            txtboxInputOutput.Text = "";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            temp = 0;

            btnPlusClicked = false;
            btnMinusClicked = false;
            btnDivideClicked = false;
            btnMultiplyClicked = true;
            btnInverseClicked = false;
            btnSquareRootClicked = false;
            btnCubeRootClicked = false;
            btnTanClicked = false;
            btnSinClicked = false;
            btnCosClicked = false;

            temp = Parser(txtboxInputOutput.Text);
            txtboxInputOutput.Text = "";
        }

        #endregion

        #region Buttons - Algebraic
        private void btnInverse_Click(object sender, EventArgs e)
        {
            btnPlusClicked = false;
            btnMinusClicked = false;
            btnDivideClicked = false;
            btnMultiplyClicked = false;
            btnInverseClicked = true;
            btnSquareRootClicked = false;
            btnCubeRootClicked = false;
            btnTanClicked = false;
            btnSinClicked = false;
            btnCosClicked = false;
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            btnPlusClicked = false;
            btnMinusClicked = false;
            btnDivideClicked = false;
            btnMultiplyClicked = false;
            btnInverseClicked = false;
            btnSquareRootClicked = true;
            btnCubeRootClicked = false;
            btnTanClicked = false;
            btnSinClicked = false;
            btnCosClicked = false;
        }

        private void btnCubeRoot_Click(object sender, EventArgs e)
        {
            btnPlusClicked = false;
            btnMinusClicked = false;
            btnDivideClicked = false;
            btnMultiplyClicked = false;
            btnInverseClicked = false;
            btnSquareRootClicked = false;
            btnCubeRootClicked = true;
            btnTanClicked = false;
            btnSinClicked = false;
            btnCosClicked = false;
        }
        #endregion

        #region Buttons - Trig
        private void btnTan_Click(object sender, EventArgs e)
        {
            btnPlusClicked = false;
            btnMinusClicked = false;
            btnDivideClicked = false;
            btnMultiplyClicked = false;
            btnInverseClicked = false;
            btnSquareRootClicked = false;
            btnCubeRootClicked = false;
            btnTanClicked = true;
            btnSinClicked = false;
            btnCosClicked = false;
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            btnPlusClicked = false;
            btnMinusClicked = false;
            btnDivideClicked = false;
            btnMultiplyClicked = false;
            btnInverseClicked = false;
            btnSquareRootClicked = false;
            btnCubeRootClicked = false;
            btnTanClicked = false;
            btnSinClicked = true;
            btnCosClicked = false;
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            btnPlusClicked = false;
            btnMinusClicked = false;
            btnDivideClicked = false;
            btnMultiplyClicked = false;
            btnInverseClicked = false;
            btnSquareRootClicked = false;
            btnCubeRootClicked = false;
            btnTanClicked = false;
            btnSinClicked = false;
            btnCosClicked = true;
        }
        #endregion

        // This method parses the user's input.
        // This ensures only valid input is sent to the mathematical functions.
        private double Parser(String inputString)
        {
            bool canParse = Double.TryParse(inputString, out double outputDouble);
            if (canParse == false)
            {
                outputDouble = 0;
            }

            return outputDouble;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            input = Parser(txtboxInputOutput.Text);
            
            if (btnPlusClicked == true)
            {
                output = Arithmetic.Add(temp, input);
            }

            else if (btnMinusClicked == true)
            {
                output = Arithmetic.Subtract(temp, input);
            }

            else if (btnDivideClicked == true)
            {
                output = Arithmetic.Divide(temp, input);
            }

            else if (btnMultiplyClicked == true)
            {
                output = Arithmetic.Multiply(temp, input);
            }

            else if (btnInverseClicked == true)
            {
                output = Algebraic.Inverse(input);
            }

            else if (btnSquareRootClicked == true)
            {
                output = Algebraic.SquareRoot(input);
            }

            else if (btnCubeRootClicked == true)
            {
                output = Algebraic.CubeRoot(input);
            }

            else if (btnTanClicked == true)
            {
                output = Trigonometric.Tan(input);
            }

            else if (btnSinClicked == true)
            {
                output = Trigonometric.Sine(input);
            }

            else if (btnCosClicked == true)
            {
                output = Trigonometric.Cosine(input);
            }

            txtboxInputOutput.Text = output.ToString();
        }

        // Clears the calculator.
        private void btnC_Click(object sender, EventArgs e)
        {
            btnPlusClicked = false;
            btnMinusClicked = false;
            btnDivideClicked = false;
            btnMultiplyClicked = false;
            btnInverseClicked = false;
            btnSquareRootClicked = false;
            btnCubeRootClicked = false;
            btnTanClicked = false;
            btnSinClicked = false;
            btnCosClicked = false;

            temp = 0;
            input = 0;
            txtboxInputOutput.Clear();
        }

        // Validating keystrokes in textbox
        private void txtboxInputOutput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Checks that the character is a digit (excludes . decimal)
            if (!char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') &&
                (e.KeyChar != 'e') &&
                (e.KeyChar != '+') &&
                (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // Checks that there is maximum of one . decimal, one E, one +, one - for E-notation.
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == 'e') && ((sender as TextBox).Text.IndexOf('e') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '+') && ((sender as TextBox).Text.IndexOf('+') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
