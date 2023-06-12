using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Minshan0306
{
    public partial class Grade_0306 : Form
    {
        public Grade_0306()
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

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtChi.Text) || string.IsNullOrWhiteSpace(txtEng.Text) || string.IsNullOrWhiteSpace(txtMath.Text))
            {
                MessageBox.Show("請輸入姓名及成績", "錯誤訊息", MessageBoxButtons.OK);
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
                    richTextBox.Text += stu.GetScoreResult();
                    btnstatistics.Enabled = true;
                }
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
                richTextBox.Text += stu.GetScoreResult();
                btnstatistics.Enabled = true;
            }
        }


        private void btnRandom_Click(object sender, EventArgs e)
        {
            GenerateRandomScore();
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

            foreach (string line in richTextBox.Lines)
            {
                if (line.Length >= 155) // 確保字串長度足夠進行字串符提取
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
                Richstatistics.Text = $"總分：{totalChineseScore,18}" + $"{totalEnglishScore,18}" + $"  {totalMathScore,15} " + "\n" +
                                      $"平均：{avgChineseScore,17}" + $"{avgEnglishScore,17}" + $" {avgMathScore,17}\n" +
                                      $"最高分：{maxChineseScore,15}" + $"{maxEnglishScore,15}" + $" {maxMathScore,20}\n";
                
            }

            btnstatistics.Enabled = true;
        }
            private void btnClear_Click(object sender, EventArgs e)
            {
                txtName.Text = "";
                txtChi.Text = "";
                txtEng.Text = "";
                txtMath.Text = "";
                Richstatistics.Text = "";
                richTextBox.Text = "";
                btnstatistics.Enabled = false;

            }

            private void btn20_Click(object sender, EventArgs e)
            {
                GenerateRandomScore(20);


            }
        }
    }

  

