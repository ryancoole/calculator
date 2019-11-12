using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class frmCalculator : Form
    {
        int sign = 0;
        double num1;
        double num2;
        int add = 0;
        int sub = 0;
        int mul = 0;
        int div = 0;
        int modBit = 0;
        bool fl = false;

        public frmCalculator()
        {
            InitializeComponent();
        }

        private void reset_SignBits()
        {
            add = 0;
            sub = 0;
            mul = 0;
            div = 0;
            modBit = 0;
            fl = false;
        }

        private void calculate()
        {
            if (txtInput.Text != ".")
            {
                num2 = Convert.ToDouble(txtInput.Text);

                if (fl == false)
                {
                    num1 = num2;
                }
                else if (add == 1)
                {
                    num1 = num1 + num2;
                }
                else if (sub == 1)
                {
                    num1 = num1 - num2;
                }
                else if (mul == 1)
                {
                    num1 = num1 * num2;
                }
                else if (div == 1)
                {
                    num1 = num1 / num2;
                }
                else if (modBit == 1)
                {
                    num2 = Convert.ToInt32(txtInput.Text);
                    num1 = Convert.ToInt32(num1 % num2);
                }
                else
                {
                    num1 = num2;
                }

                txtInput.Text = Convert.ToString(num1);
            }
        }

        private void numberDisplay(string number)
        {
            if (sign == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(number);
            }
            else if (sign == 1)
            {
                txtInput.Text = Convert.ToString(number);
                sign = 0;
            }

            fl = true;
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar))
            {
                btnAdd_Click(sender, e);
            }

            if (e.KeyChar == 2)
            {
                numberDisplay("2");
            }

            if (e.KeyChar == 3)
            {
                numberDisplay("3");
            }

            if (e.KeyChar == 4)
            {
                numberDisplay("4");
            }

            if (e.KeyChar == 5)
            {
                numberDisplay("5");
            }

            if (e.KeyChar == 6)
            {
                numberDisplay("6");
            }

            if (e.KeyChar == 7)
            {
                numberDisplay("7");
            }

            if (e.KeyChar == 8)
            {
                numberDisplay("8");
            }

            if (e.KeyChar == 9)
            {
                numberDisplay("9");
            }

            if (e.KeyChar == 0)
            {
                numberDisplay("0");
            }

            if (e.KeyChar == (char)Keys.Add)
            {
                if (txtInput.Text.Length != 0)
                {
                    calculate();
                    reset_SignBits();
                    add = 1;
                    sign = 1;
                }
            }
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            numberDisplay("1");
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            numberDisplay("2");
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            numberDisplay("3");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            numberDisplay("4");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            numberDisplay("5");
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            numberDisplay("6");
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            numberDisplay("7");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            numberDisplay("8");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            numberDisplay("9");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            numberDisplay("0");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
                add = 1;
                sign = 1;
            }
        }


        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                num2 = Convert.ToDouble(txtInput.Text);
                calculate();
                reset_SignBits();
                sub = 1;
                sign = 1;
            }
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
                mul = 1;
                sign = 1;
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
                div = 1;
                sign = 1;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
            }

            sign = 1;
        }        

        private void btnDot_Click(object sender, EventArgs e)
        {
            int i = 0;
            char chr = '\0';
            int decimal_Indicator = 0;
            int l = txtInput.Text.Length - 1;

            if (sign != 1)
            {
                for (i = 0; i <= l; i++)
                {
                    chr = txtInput.Text[i];

                    if (chr == '.')
                    {
                        decimal_Indicator = 1;
                    }
                }

                if (decimal_Indicator != 1)
                {
                    txtInput.Text = txtInput.Text + Convert.ToString(".");
                }
            }
        }
    }
}
