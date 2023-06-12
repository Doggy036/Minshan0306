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
    public partial class Home : Form
    {
        private Form currentForm; // 目前顯示的視窗
        private string currentButtonType; // 判斷要打開的視窗
        public Home()
        {
            InitializeComponent();
        }
        private void ShowForm(Form form, string buttonType)
        {
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }

            currentForm = form;
            currentForm.TopLevel = false;
            currentForm.Parent = this.splitContainer1.Panel2;
            currentForm.Show();

            currentButtonType = buttonType;
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            if (currentButtonType == "POS")
                return; 

            ShowForm(new POS_0306(), "POS");
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            if (currentButtonType == "Score")
                return; 

            ShowForm(new Score_0306(), "Score");

        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            if (currentButtonType == "Hello")
                return;

            ShowForm(new HelloForm_0306(), "Hello");

        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            if (currentButtonType == "Grade")
                return; 

            ShowForm(new Grade_0306(), "Grade");

        }
        private void btnLoan_Click(object sender, EventArgs e)
        {
            if (currentButtonType == "Loan")
                return;

            ShowForm(new Loan_0306(), "Loan");
        }

        private void btnGradeList_Click(object sender, EventArgs e)
        {

            if (currentButtonType == "Grade_list")
                return;

            ShowForm(new Grade_list_0306(), "Grade_list");
        }

        private void btnNB_Click(object sender, EventArgs e)
        {
            if (currentButtonType == "NoteBook")
                return;

            ShowForm(new NoteBook_0306(), "NoteBook");
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (currentButtonType == "Calculator")
                return;

            ShowForm(new MyCalc_0306(), "Calculator");
        }

    }
}
