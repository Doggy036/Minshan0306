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
    public partial class POS_0306 : Form
    {
        public POS_0306()
        {
            InitializeComponent();
        }
        //建立菜單Class來表示菜單項目的名稱和價格
        class MenuItem
        {
            public string Name { get; set; }
            public int Price { get; set; }
        }

        //定義List，< >內接收 MenuItem的型別
        List<MenuItem> menuItems = new List<MenuItem>();

        //初始化菜單設定
        private void InitializeMenuItems()
        {
            menuItems.Add(new MenuItem()
            {
                Name = "雙層牛肉吉事堡",
                Price = 70
            });

            menuItems.Add(new MenuItem()
            {
                Name = "美味蟹堡",
                Price = 55
            });

            menuItems.Add(new MenuItem()
            {
                Name = "可口可樂",
                Price = 20
            });
            menuItems.Add(new MenuItem()
            {
                Name = "冰紅茶(檸檬風味)",
                Price = 15
            });
        }
        int btnBeefClickCount = 0;
        int btnHamClickCount = 0;
        int btnColaClickCount = 0;
        int RedteaClickCount = 0;
        bool isClicked = false;
        bool isCashClicked = false;//判斷是否現金付款

        private void CountButtonClicks()
        {
            if (isClicked == true)
            {
                string text = "";
                int pay = 0;
                int totalPay = 0;// 新增一個變數用於儲存總金額

                if (btnBeefClickCount > 0)
                {
                    pay = menuItems[0].Price * btnBeefClickCount;
                    totalPay += pay;// 將每個項目的 pay 加到總金額上
                    text += $"品名: {menuItems[0].Name}, 單價: {menuItems[0].Price}" + "\n" + $"購買數量: {btnBeefClickCount} , 總金額 NT$:{pay}" + "\n";
                }

                if (btnHamClickCount > 0)
                {
                    pay = menuItems[1].Price * btnHamClickCount;
                    totalPay += pay;// 將每個項目的 pay 加到總金額上
                    text += $"品名: {menuItems[1].Name}, 單價: {menuItems[1].Price}" + "\n" + $"購買數量: {btnHamClickCount} , 總金額 NT$:{pay}" + "\n";
                }

                if (btnColaClickCount > 0)
                {
                    pay = menuItems[2].Price * btnColaClickCount;
                    totalPay += pay;// 將每個項目的 pay 加到總金額上
                    text += $"品名: {menuItems[2].Name}, 單價: {menuItems[2].Price}" + "\n" + $"購買數量: {btnColaClickCount} , 總金額 NT$:{pay}" + "\n";
                }

                if (RedteaClickCount > 0)
                {
                    pay = menuItems[3].Price * RedteaClickCount;
                    totalPay += pay;// 將每個項目的 pay 加到總金額上
                    text += $"品名: {menuItems[3].Name}, 單價: {menuItems[3].Price}" + "\n" + $"購買數量: {RedteaClickCount} , 總金額 NT$:{pay}" + "\n";
                }

                richTextBox.Text = text;
                textBox1.Text = $" NT$:{totalPay}";



            }
            else if(isClicked&&!isCashClicked==true)
            {
                btnBeefClickCount = 0;
                btnHamClickCount = 0;
                btnColaClickCount = 0;
                RedteaClickCount = 0;
                richTextBox.Text = null;
                richTextBox.Text = "尚未點餐";
            }
        }

        private void btnBeef_Click(object sender, EventArgs e)
        {
            InitializeMenuItems();
            btnBeefClickCount++;
            isClicked = true;
            CountButtonClicks();
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            InitializeMenuItems();
            btnHamClickCount++;
            isClicked = true;
            CountButtonClicks();
        }

        private void btnCola_Click(object sender, EventArgs e)
        {
            InitializeMenuItems();
            btnColaClickCount++;
            isClicked = true;
            CountButtonClicks();
        }

        private void btnRedtea_Click(object sender, EventArgs e)
        {

            InitializeMenuItems();
            RedteaClickCount++;
            isClicked = true;
            CountButtonClicks();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            isClicked = true;
            isCashClicked = false;
            CountButtonClicks();
            btnBeefClickCount = 0;
            btnHamClickCount = 0;
            btnColaClickCount = 0;
            RedteaClickCount = 0;
            richTextBox.Text = null;
            richTextBox.Text = "尚未點餐";
            textBox1.Text = null;
        }
        private void btnCash_Click(object sender, EventArgs e)
        {
            int pay = menuItems[0].Price * btnBeefClickCount + menuItems[1].Price * btnHamClickCount + menuItems[2].Price * btnColaClickCount + menuItems[3].Price * RedteaClickCount;
            string money = $"總金額:{pay}";
            MessageBox.Show(money);
        }
        private void btnCredict_Click(object sender, EventArgs e)
        {
            int pay = menuItems[0].Price * btnBeefClickCount + menuItems[1].Price * btnHamClickCount + menuItems[2].Price * btnColaClickCount + menuItems[3].Price * RedteaClickCount;
            string credit = $"總金額:{pay}" + "\n" + $"折扣後金額:{Math.Round(pay * 0.9)}";
            MessageBox.Show(credit);
        }
    }
}
