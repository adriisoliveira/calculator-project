using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_project
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        int x, y;
        char operation;
        float results;

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private float plus (int a, int b)
        {
            return a + b;
        }

        private float less (int a, int b)
        {
            return a - b;
        }

        private float split (int a, int b)
        {
            return a / b;
        }

        private float multiply(int a, int b)
        {
            return a * b;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtScreen.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtScreen.Clear();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            operation = '+';
            plus(x, y);
        }

        private void btnLess_Click(object sender, EventArgs e)
        {
            operation = '-';
            less(x, y);
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            operation = '/';
            split(x, y);
        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operation = '*';
            multiply(x, y);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                x = 1;
            }
            else
            {
                y = 1;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                x = 2;
            }
            else
            {
                y = 2;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                x = 3;
            }
            else
            {
                y = 3;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                x = 4;
            }
            else
            {
                y = 4;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                x = 5;
            }
            else
            {
                y = 5;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                x = 6;
            }
            else
            {
                y = 6;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                x = 7;
            }
            else
            {
                y = 7;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                x = 8;
            }
            else
            {
                y = 8;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                x = 9;
            }
            else
            {
                y = 9;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                x = 0;
            }
            else
            {
                y = 0;
            }
        }




    }
}
