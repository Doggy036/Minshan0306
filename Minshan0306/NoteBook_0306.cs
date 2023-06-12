using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minshan0306
{
    public partial class NoteBook_0306 : Form
    {
        public NoteBook_0306()
        {
            InitializeComponent();
            StatusTime.Text = DateTime.Now.ToString();//狀態顯示目前時間
        }
        private void NoteBook_0306_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
        //-------------------設定鍵盤事件-----------------------------------------
        private void NoteBook_0306_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.O)
            {
                btnOpen_Click(sender, e); //Ctrl+S 啟動 開啟
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                toolSave_Click(sender, e); //Ctrl+S 啟動 儲存
            }
            else if (e.Control && e.KeyCode == Keys.U)
            {
                toolUpper_Click(sender, e); //Ctrl+U 啟動 ToUpper
            }
            else if (e.Control && e.KeyCode == Keys.L)
            {
                toolLower_Click(sender, e); //Ctrl+L 啟動 Lowwer
            }
            else if (e.Control && e.KeyCode == Keys.C)
            {
                toolCopy_Click(sender, e); //Ctrl+C 複製
            }
            else if (e.Control && e.KeyCode == Keys.C)
            {
                toolPaste_Click(sender, e); //Ctrl+V 貼上
            }
            else if (e.Control && e.KeyCode == Keys.X)
            {
                toolCut_Click(sender, e); //Ctrl+X 剪下
            }
        }
        //--------------------開啟檔案(OPEN)------------------------------------
        private void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                {
                    rtxtShow.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                    rtxtShow.Text = sr.ReadToEnd();
                }
            }
        }
        private void toolOpen_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
        //------------------儲存檔案(SAVE)---------------------------------
        private void SaveFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                {
                    sw.Write(rtxtShow.Text);
                }
            }
        }
        private void toolSave_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
       
        //--------------------使選擇的字體改變顏色----------------------
        private void toolColor_Click(object sender, EventArgs e)
        {
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            dlgColor.AllowFullOpen = false;
            dlgColor.ShowHelp = true;//顯示說明按鈕
            dlgColor.AnyColor = true;//顯示所有可用基本色彩
            dlgColor.Color = rtxtShow.ForeColor;
            if (dlgColor.ShowDialog() == DialogResult.OK)
                rtxtShow.SelectionColor = dlgColor.Color;
        }
        //-----------------------改變字體-------------------------------
        private void toolFont_Click(object sender, EventArgs e)
        {
            this.dlgFont = new System.Windows.Forms.FontDialog();
            dlgFont.ShowColor = true;
            dlgFont.Font=rtxtShow.Font;//取得系統中的字型
            dlgFont.Color=rtxtShow.ForeColor;//取得前景色彩
            if (dlgFont.ShowDialog() != DialogResult.Cancel)
            { 
                rtxtShow.Font = dlgFont.Font;
                rtxtShow.ForeColor = dlgFont.Color;
           }

        }
        //-----------------字體相關設定(大、小寫)-------------------
        private void toolUpper_Click(object sender, EventArgs e)
        {
            rtxtShow.Text = rtxtShow.Text.ToUpper();
        }

        private void toolLower_Click(object sender, EventArgs e)
        {
            rtxtShow.Text = rtxtShow.Text.ToLower();
        }

        //-----------------------複製、貼上------------------------
        private void toolCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rtxtShow.SelectedText))
            {
                Clipboard.SetText(rtxtShow.SelectedText);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rtxtShow.SelectedText))
            {
                Clipboard.SetText(rtxtShow.SelectedText);
            }
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                rtxtShow.SelectedText = Clipboard.GetText();
            }

        }
        private void toolPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                rtxtShow.SelectedText = Clipboard.GetText();
            }
        }

        //-----------------------剪下文字------------------------
        private void CutSelectedText()
        {
            if (!string.IsNullOrEmpty(rtxtShow.SelectedText))
            {
                Clipboard.SetText(rtxtShow.SelectedText);
                rtxtShow.SelectedText = string.Empty;
            }
        }
        private void toolCut_Click(object sender, EventArgs e)
        {
            CutSelectedText();
        }
        private void btnCut_Click(object sender, EventArgs e)
        {
            CutSelectedText();
        }
        //-----------------------說明-----------------------------------
        private void Description()
        {
            MessageBox.Show("此為李旻珊的C#作品", "說明");
        }
        private void btnDescription_Click(object sender, EventArgs e)
        {
            Description();
        }

        private void toolAbout_Click(object sender, EventArgs e)
        {
            Description();
        }



    }
}
