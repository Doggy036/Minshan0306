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
    public partial class Score_0306 : Form
    {
        public Score_0306()
        {
            InitializeComponent();
        }
        string ScoreResult = "";
        int Max_Score = 0;
        int Min_Score = 0;
        string Max_Result = "";
        string Min_Result = "";
        int[] ScoreArray = new int[3];
        bool isclick = false;
        //利用布林值設定儲存成績按鈕
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            isclick = true;
        }
        //顯示成績按鈕，有儲存的資料才呈現
        private void btnShow_Click_1(object sender, EventArgs e)
        {
            if (isclick == true)
            {
                StuScore Stu = new StuScore(txtName.Text,
             int.Parse(txtCh.Text), int.Parse(txtEng.Text),
             int.Parse(txtMath.Text));
                //判斷輸入的成績是否在100內
                if (Stu.Chinese > 100 || Stu.English > 100 || Stu.Math > 100)
                {
                    MessageBox.Show("請輸入100以內分數", "錯誤訊息", MessageBoxButtons.OK);//（“要顯示的內容”，“標題”，OK按鈕）
                }
                else //顯示成績
                {
                    ScoreResult += "姓名:" + Stu.Name + "\n" +
                        "國文:" + Stu.Chinese + "\n" +
                        "英文:" + Stu.English + "\n" +
                        "數學:" + Stu.Math;
                    labScore.Text = ScoreResult;
                }
            }
            else
            {
                MessageBox.Show("尚未儲存成績資料", "錯誤訊息");
            }
        }

        //連結Stdeunt.cs的結構函式
        //顯示最高分、最低分科目及分數(利用陣列)
        private void btnMaxMin_Click_1(object sender, EventArgs e)
        {
            if (isclick == true)
            {
                StuScore Stu = new StuScore(txtName.Text, int.Parse(txtCh.Text), int.Parse(txtEng.Text), int.Parse(txtMath.Text));
                int[] ScoreArray = new int[3] { Stu.Chinese, Stu.English, Stu.Math };
                //myIntArray.Max();   // 最大值
                //myIntArray.Min();   // 最小值
                Max_Score = ScoreArray.Max();
                Min_Score = ScoreArray.Min();
                Max_Result += Max_Score;
                Min_Result += Min_Score;
                string[] subjectArray = new string[3] { "國文", "英文", "數學" };//再宣告一個科目的陣列
                Max_Result = subjectArray[Array.IndexOf(ScoreArray, Max_Score)];//取得最大值的索引位址，對照到科目
                Min_Result = subjectArray[Array.IndexOf(ScoreArray, Min_Score)];//取得最小值的索引位址，對照到科
                labMax.Text = Max_Result + Max_Score + "分";//顯示最高分科目+分數
                labMin.Text = Min_Result + Min_Score + "分";//顯示最低分科目+分數
            }
            else
            {
                MessageBox.Show("尚未儲存成績資料", "錯誤訊息");

            }
        }

    }



}

