using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Minshan0306
{
    public partial class Report_0306 : Form
    {
 
        public Report_0306()
        {
            InitializeComponent();
        }



        //public string LoanMoneyText
        //{
        //    get { return loanForm.txtLoanMoney.Text; }
        //}

        //public string DeadlineText
        //{
        //    get { return loanForm.txtDeadline.Text; }
        //}

        //public string RateText
        //{
        //    get { return loanForm.txtRate.Text; }
        //}

        //public void UpdateValues()
        //{

        //    txtLoanMoney.Text = loanForm.LoanMoneyText;
        //    txtDeadline.Text = loanForm.DeadlineText;
        //    txtRate.Text = loanForm.RateText;

        //    // 使用 Loan_0306 类的计算结果更新另一个类中的文本框值
        //    double PMT = loanForm.Calculate(double.Parse(loanForm.LoanMoneyText),
        //                                    double.Parse(loanForm.DeadlineText),
        //                                    double.Parse(loanForm.RateText));
        //    int roundedPMT = (int)Math.Round(PMT);
        //    txtPMT.Text = roundedPMT.ToString("N0");
        //    //textbox5.Text = loanForm.totalPay.ToString("N0");
    }

}



