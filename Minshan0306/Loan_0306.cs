using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Minshan0306
{
    public partial class Loan_0306 : Form
    {
        public Loan_0306()
        {
            InitializeComponent();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtLoanMoney.Text) ||
                string.IsNullOrWhiteSpace(txtDeadline.Text) ||
                string.IsNullOrWhiteSpace(txtRate.Text) ||
                string.IsNullOrWhiteSpace(txtDownpay.Text))
            {
                MessageBox.Show("貸款金額、期限、利率、頭期款為必填資料", "錯誤訊息", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        public double Calculate(double money, double deadline, double rate)
        {
            return money * Math.Pow((1 + (rate / 1200)), (deadline * 12)) * ((rate / 1200) / (Math.Pow((1 + (rate / 1200)), (deadline * 12)) - 1));
        }



       public void btnPMT_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                double Money = double.Parse(txtLoanMoney.Text);
                double Deadline = double.Parse(txtDeadline.Text);
                double Rate = double.Parse(txtRate.Text);
                double Downpay = double.Parse(txtDownpay.Text);

                double PMT = Calculate(Money, Deadline, Rate);
                int roundedPMT = (int)Math.Round(PMT);
                MessageBox.Show("月付額: " + roundedPMT.ToString("N0") + "元");
            }
        }

        public void btnTotal_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                double Money = double.Parse(txtLoanMoney.Text);
                double Deadline = double.Parse(txtDeadline.Text);
                double Rate = double.Parse(txtRate.Text);
                double Downpay = double.Parse(txtDownpay.Text);

                double PMT = Calculate(Money, Deadline, Rate);
                int roundedPMT = (int)Math.Round(PMT);
                double totalPay = roundedPMT * Deadline * 12;

                MessageBox.Show("總付款:" + totalPay.ToString("N0") + "元");
            }

        }

        public void btnReport_Click(object sender, EventArgs e)
        {
            Report_0306 report = new Report_0306();
            report.Show();
        }
    }
}
