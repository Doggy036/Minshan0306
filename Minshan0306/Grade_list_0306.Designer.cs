using System;

namespace Minshan0306
{
    partial class Grade_list_0306
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grade_list_0306));
            this.label1 = new System.Windows.Forms.Label();
            this.Richstatistics = new System.Windows.Forms.RichTextBox();
            this.btn20 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnstatistics = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.richScoreShow = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.labName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labChi = new System.Windows.Forms.Label();
            this.txtChi = new System.Windows.Forms.TextBox();
            this.labEng = new System.Windows.Forms.Label();
            this.txtEng = new System.Windows.Forms.TextBox();
            this.labMath = new System.Windows.Forms.Label();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comSelect = new System.Windows.Forms.ComboBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelect = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(818, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名          國文          英文          數學          總分          平均          最低       " +
    "   最高";
            // 
            // Richstatistics
            // 
            this.Richstatistics.Location = new System.Drawing.Point(351, 398);
            this.Richstatistics.Name = "Richstatistics";
            this.Richstatistics.Size = new System.Drawing.Size(881, 181);
            this.Richstatistics.TabIndex = 15;
            this.Richstatistics.Text = "";
            // 
            // btn20
            // 
            this.btn20.Location = new System.Drawing.Point(24, 272);
            this.btn20.Margin = new System.Windows.Forms.Padding(4);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(285, 34);
            this.btn20.TabIndex = 21;
            this.btn20.Text = "隨機加入20筆";
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.btn20_Click);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(24, 353);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(285, 34);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "清空所有資料";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnstatistics
            // 
            this.btnstatistics.Enabled = false;
            this.btnstatistics.Location = new System.Drawing.Point(947, 586);
            this.btnstatistics.Margin = new System.Windows.Forms.Padding(4);
            this.btnstatistics.Name = "btnstatistics";
            this.btnstatistics.Size = new System.Drawing.Size(285, 34);
            this.btnstatistics.TabIndex = 19;
            this.btnstatistics.Text = "各科統計";
            this.btnstatistics.UseVisualStyleBackColor = true;
            this.btnstatistics.Click += new System.EventHandler(this.btnstatistics_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(24, 230);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(285, 34);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "加入學生資料";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // richScoreShow
            // 
            this.richScoreShow.Location = new System.Drawing.Point(0, 52);
            this.richScoreShow.Name = "richScoreShow";
            this.richScoreShow.Size = new System.Drawing.Size(880, 308);
            this.richScoreShow.TabIndex = 0;
            this.richScoreShow.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.richScoreShow);
            this.panel1.Location = new System.Drawing.Point(352, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 364);
            this.panel1.TabIndex = 22;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Linen;
            this.flowLayoutPanel2.Controls.Add(this.labName);
            this.flowLayoutPanel2.Controls.Add(this.txtName);
            this.flowLayoutPanel2.Controls.Add(this.labChi);
            this.flowLayoutPanel2.Controls.Add(this.txtChi);
            this.flowLayoutPanel2.Controls.Add(this.labEng);
            this.flowLayoutPanel2.Controls.Add(this.txtEng);
            this.flowLayoutPanel2.Controls.Add(this.labMath);
            this.flowLayoutPanel2.Controls.Add(this.txtMath);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(24, 27);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(8, 8, 2, 8);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(285, 186);
            this.flowLayoutPanel2.TabIndex = 16;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(12, 8);
            this.labName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(97, 40);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名 :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(117, 12);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(134, 29);
            this.txtName.TabIndex = 1;
            // 
            // labChi
            // 
            this.labChi.AutoSize = true;
            this.labChi.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChi.Location = new System.Drawing.Point(12, 48);
            this.labChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labChi.Name = "labChi";
            this.labChi.Size = new System.Drawing.Size(97, 40);
            this.labChi.TabIndex = 2;
            this.labChi.Text = "國文 :";
            // 
            // txtChi
            // 
            this.txtChi.Location = new System.Drawing.Point(117, 52);
            this.txtChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtChi.Name = "txtChi";
            this.txtChi.Size = new System.Drawing.Size(134, 29);
            this.txtChi.TabIndex = 3;
            // 
            // labEng
            // 
            this.labEng.AutoSize = true;
            this.labEng.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEng.Location = new System.Drawing.Point(12, 88);
            this.labEng.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labEng.Name = "labEng";
            this.labEng.Size = new System.Drawing.Size(97, 40);
            this.labEng.TabIndex = 4;
            this.labEng.Text = "英文 :";
            // 
            // txtEng
            // 
            this.txtEng.Location = new System.Drawing.Point(117, 92);
            this.txtEng.Margin = new System.Windows.Forms.Padding(4);
            this.txtEng.Name = "txtEng";
            this.txtEng.Size = new System.Drawing.Size(134, 29);
            this.txtEng.TabIndex = 5;
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(12, 128);
            this.labMath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(97, 40);
            this.labMath.TabIndex = 6;
            this.labMath.Text = "數學 :";
            // 
            // txtMath
            // 
            this.txtMath.Location = new System.Drawing.Point(117, 132);
            this.txtMath.Margin = new System.Windows.Forms.Padding(4);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(134, 29);
            this.txtMath.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "------搜尋科目成績範圍------";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comSelect
            // 
            this.comSelect.FormattingEnabled = true;
            this.comSelect.Items.AddRange(new object[] {
            "國文",
            "英文",
            "數學"});
            this.comSelect.Location = new System.Drawing.Point(8, 123);
            this.comSelect.Name = "comSelect";
            this.comSelect.Size = new System.Drawing.Size(121, 26);
            this.comSelect.TabIndex = 25;
            this.comSelect.Text = "科目選擇";
            this.comSelect.SelectedIndexChanged += new System.EventHandler(this.comSelect_SelectedIndexChanged_1);
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(8, 53);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(121, 29);
            this.txtMin.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(3, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "2.下拉選擇欲查詢科目";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtMax);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtMin);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.comSelect);
            this.panel2.Location = new System.Drawing.Point(24, 398);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 205);
            this.panel2.TabIndex = 28;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSearch.Font = new System.Drawing.Font("Segoe Script", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(154, 152);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 49);
            this.btnSearch.TabIndex = 31;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(154, 50);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(117, 29);
            this.txtMax.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "~";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(3, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "1.輸入欲查詢成績範圍";
            // 
            // btnDelect
            // 
            this.btnDelect.Enabled = false;
            this.btnDelect.Location = new System.Drawing.Point(24, 311);
            this.btnDelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelect.Name = "btnDelect";
            this.btnDelect.Size = new System.Drawing.Size(285, 34);
            this.btnDelect.TabIndex = 29;
            this.btnDelect.Text = "刪除加入資料";
            this.btnDelect.UseVisualStyleBackColor = true;
            this.btnDelect.Click += new System.EventHandler(this.btnDelect_Click);
            // 
            // Grade_list_0306
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1248, 622);
            this.Controls.Add(this.btnDelect);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Richstatistics);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnstatistics);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "Grade_list_0306";
            this.Text = "Grade_list";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void comSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Richstatistics;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnstatistics;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox richScoreShow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labChi;
        private System.Windows.Forms.TextBox txtChi;
        private System.Windows.Forms.Label labEng;
        private System.Windows.Forms.TextBox txtEng;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comSelect;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelect;
    }
}