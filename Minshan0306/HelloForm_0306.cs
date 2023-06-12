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
    public partial class HelloForm_0306 : Form
    {
        public HelloForm_0306()
        {
            InitializeComponent();
        }

        private void ShowMessage(string greeting)
        {
            string UserNAme = txtUserName.Text;
            string EngNAme = txtEngName.Text;
            string Sex = txtSex.Text;
            string Star = txtStar.Text;

            MessageBox.Show(greeting + ",我是," + UserNAme +"\n" +"英文名字是" + EngNAme + "\n" +"性別是," + Sex + "\n" +"星座是," + Star + "\n" +"很高興認識你。");
        }

        private void btnHello_Click(object sender, EventArgs e)
        { 
            ShowMessage("Hello");
        }

        private void btnHi_Click(object sender, EventArgs e)
        { 
            ShowMessage("Hi");
        }
    }
}
