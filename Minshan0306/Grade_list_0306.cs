using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Minshan0306
{
    public partial class Grade_list_0306 : Form
    {
        public Grade_list_0306()
        {
            InitializeComponent();

        }



        //繼承StuScore Class的Attribute、Method(Student.cs)
        public class GradeScore : StuScore
        {

            public GradeScore(string name, int chinese, int english, int math)
                : base(name, chinese, english, math)
            {

            }

        }

        private List<GradeScore> gradeScores = new List<GradeScore>();
        bool hasData = false;


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
       string.IsNullOrWhiteSpace(txtChi.Text) ||
       string.IsNullOrWhiteSpace(txtEng.Text) ||
       string.IsNullOrWhiteSpace(txtMath.Text))
            {
                MessageBox.Show("請輸入姓名及成績", "錯誤訊息", MessageBoxButtons.OK);
                hasData = true;
            }
            else
            {
                StuScore stu = new StuScore(txtName.Text, int.Parse(txtChi.Text), int.Parse(txtEng.Text), int.Parse(txtMath.Text));

                if (!stu.IsValid())
                {
                    MessageBox.Show("請輸入100以內分數", "錯誤訊息", MessageBoxButtons.OK);
                }
                else
                {
                    richScoreShow.Text += stu.GetScoreResult();
                    btnstatistics.Enabled = true;
                    btnClear.Enabled = true;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (hasData == true)
            {
                btnClear.Enabled = true;
                txtName.Text = "";
                txtChi.Text = "";
                txtEng.Text = "";
                txtMath.Text = "";
                Richstatistics.Text = "";
                richScoreShow.Text = "";
                btnstatistics.Enabled = false;
            }
        }

        //產生隨機分數
        private void GenerateRandomScore(int count = 1)
        {
            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                // 產生隨機的成績
                int chineseScore = random.Next(0, 101);
                int englishScore = random.Next(0, 101);
                int mathScore = random.Next(0, 101);

                // 建立 StuScore 物件並計算相關統計數據
                StuScore stu = new StuScore($"{i + 1}", chineseScore, englishScore, mathScore);

                // 顯示成績
                richScoreShow.Text += stu.GetScoreResult();
                btnstatistics.Enabled = true;
            }
            hasData = true;
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            GenerateRandomScore(20);
            btnClear.Enabled = true;
        }

        //建立查詢方法
        private void FilterScores()
        {
            if (string.IsNullOrWhiteSpace(txtMin.Text) || string.IsNullOrWhiteSpace(txtMax.Text))
            { MessageBox.Show("請先輸入成績範圍，再選擇科目", "提示訊息"); }

            else
            {
                string selectedSubject = comSelect.SelectedItem.ToString();
                int minScore = int.Parse(txtMin.Text);
                int maxScore = int.Parse(txtMax.Text);

                List<string> filteredScores = new List<string>();

                foreach (string line in richScoreShow.Lines)
                {
                    if (line.Length >= 155)
                    {
                        string name = line.Substring(0, 15).Trim();
                        string chineseStr = line.Substring(15, 20).Trim();
                        string englishStr = line.Substring(35, 20).Trim();
                        string mathStr = line.Substring(55, 20).Trim();

                        int subjectScore = 0;
                        if (selectedSubject == "國文")
                        {
                            subjectScore = int.Parse(chineseStr);
                        }
                        else if (selectedSubject == "英文")
                        {
                            subjectScore = int.Parse(englishStr);
                        }
                        else if (selectedSubject == "數學")
                        {
                            subjectScore = int.Parse(mathStr);
                        }

                        if (subjectScore >= minScore && subjectScore <= maxScore)
                        {
                            filteredScores.Add(line);
                        }
                    }
                    richScoreShow.Lines = filteredScores.ToArray();
                }
            }
        }

        //下拉式選單，選擇欲查詢科目
        private void comSelect_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (hasData == false) // 若無成績資料，則不能進行查詢
            {
                MessageBox.Show("無成績資料可進行查詢", "錯誤訊息", MessageBoxButtons.OK);
            }
            else // 進行查詢
            {
                FilterScores();
            }
        }

        //搜尋成績範圍區間
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (hasData == true) // 若有成績資料且已選擇科目，才進行查詢
            {
                FilterScores();
            }
            else
            {
                MessageBox.Show("請先選擇科目及輸入成績查詢範圍", "錯誤訊息", MessageBoxButtons.OK);
            }
        }
        List<StuScore> scores = new List<StuScore>();
        private void btnstatistics_Click(object sender, EventArgs e)
        {
            // 計算各科目的統計數據
            int totalChineseScore = 0;
            int totalEnglishScore = 0;
            int totalMathScore = 0;
            int count = 0;
            int maxChineseScore = int.MinValue;
            int minChineseScore = int.MaxValue;
            int maxEnglishScore = int.MinValue;
            int minEnglishScore = int.MaxValue;
            int maxMathScore = int.MinValue;
            int minMathScore = int.MaxValue;

            foreach (string line in richScoreShow.Lines)
            {
                if (line.Length >= 155) 
                {
                    string name = line.Substring(0, 15).Trim();
                    string chineseStr = line.Substring(15, 20).Trim();
                    string englishStr = line.Substring(35, 20).Trim();
                    string mathStr = line.Substring(55, 20).Trim();
                    string sumScoreStr = line.Substring(75, 20).Trim();
                    string avgScoreStr = line.Substring(95, 20).Trim();
                    string minScoreStr = line.Substring(115, 20).Trim();
                    string maxScoreStr = line.Substring(135, 20).Trim();


                    int chineseScore = int.Parse(chineseStr);
                    int englishScore = int.Parse(englishStr);
                    int mathScore = int.Parse(mathStr);


                    // 更新各科目的最高分和最低分
                    maxChineseScore = Math.Max(maxChineseScore, chineseScore);
                    minChineseScore = Math.Min(minChineseScore, chineseScore);
                    maxEnglishScore = Math.Max(maxEnglishScore, englishScore);
                    minEnglishScore = Math.Min(minEnglishScore, englishScore);
                    maxMathScore = Math.Max(maxMathScore, mathScore);
                    minMathScore = Math.Min(minMathScore, mathScore);

                    //計算總分
                    totalChineseScore += chineseScore;
                    totalEnglishScore += englishScore;
                    totalMathScore += mathScore;

                    count++;
                }
                // 計算平均分數
                double avgChineseScore = count > 0 ? (double)totalChineseScore / count : 0;
                double avgEnglishScore = count > 0 ? (double)totalEnglishScore / count : 0;
                double avgMathScore = count > 0 ? (double)totalMathScore / count : 0;

                // 顯示統計數據
                Richstatistics.Text = $"總分：{totalChineseScore,20}" + $"{totalEnglishScore,20}" + $"  {totalMathScore,18} " + "\n" +
                                      $"平均：{avgChineseScore,20}" + $"{avgEnglishScore,20}" + $" {avgMathScore,18}\n" +
                                      $"最高分：{maxChineseScore,15}" + $"{maxEnglishScore,20}" + $" {maxMathScore,20}\n";

            }

            btnstatistics.Enabled = true;
        }

        private void btnDelect_Click(object sender, EventArgs e)
        {
            if (richScoreShow.Lines.Length > 0)
            {
                // 抓最後一行
                string lastLine = richScoreShow.Lines[richScoreShow.Lines.Length - 1];

                // 移除最後一行
                richScoreShow.Text = richScoreShow.Text.Remove(richScoreShow.Text.LastIndexOf(lastLine));

     
            }
        }
    }
}

