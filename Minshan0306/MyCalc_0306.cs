using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minshan0306
{
    public partial class MyCalc_0306 : Form
    {
        public MyCalc_0306()
        {
            InitializeComponent();
        }
        //加法運算
        private void btnPlus_Click_1(object sender, EventArgs e)
        {
            double a = double.Parse(txtNum1.Text);
            double b = double.Parse(txtNum2.Text);
            double c = a + b;
            txtAnswer.Text = c.ToString();
        }
       
        //減法運算
        private void btnSubtract_Click_1(object sender, EventArgs e)
        {
            double a = double.Parse(txtNum1.Text);
            double b = double.Parse(txtNum2.Text);
            double c = a - b;
            txtAnswer.Text = c.ToString();
        }

        //乘法運算
        private void btnMultiply_Click_1(object sender, EventArgs e)
        {
            double a = double.Parse(txtNum1.Text);
            double b = double.Parse(txtNum2.Text);
            double c = a * b;
            txtAnswer.Text = c.ToString();
        }

        //除法運算
        private void btnDivide_Click_1(object sender, EventArgs e)
        {
            double a = double.Parse(txtNum1.Text);
            double b = double.Parse(txtNum2.Text);
            double c = a / b;
            txtAnswer.Text = c.ToString();
        }


    }
}
