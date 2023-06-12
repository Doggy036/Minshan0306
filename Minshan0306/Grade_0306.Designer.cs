namespace Minshan0306
{
    partial class Grade_0306
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grade_0306));
            this.btn20 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnstatistics = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.labName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labChi = new System.Windows.Forms.Label();
            this.txtChi = new System.Windows.Forms.TextBox();
            this.labEng = new System.Windows.Forms.Label();
            this.txtEng = new System.Windows.Forms.TextBox();
            this.labMath = new System.Windows.Forms.Label();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.Richstatistics = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn20
            // 
            this.btn20.Location = new System.Drawing.Point(18, 567);
            this.btn20.Margin = new System.Windows.Forms.Padding(4);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(285, 34);
            this.btn20.TabIndex = 13;
            this.btn20.Text = "隨機加入20筆";
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.btn20_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(18, 524);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(285, 34);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "重設所有資料";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnstatistics
            // 
            this.btnstatistics.Enabled = false;
            this.btnstatistics.Location = new System.Drawing.Point(18, 364);
            this.btnstatistics.Margin = new System.Windows.Forms.Padding(4);
            this.btnstatistics.Name = "btnstatistics";
            this.btnstatistics.Size = new System.Drawing.Size(285, 34);
            this.btnstatistics.TabIndex = 11;
            this.btnstatistics.Text = "各科統計";
            this.btnstatistics.UseVisualStyleBackColor = true;
            this.btnstatistics.Click += new System.EventHandler(this.btnstatistics_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(18, 308);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(4);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(285, 34);
            this.btnRandom.TabIndex = 10;
            this.btnRandom.Text = "隨機儲存資料";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(18, 250);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(285, 34);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "加入學生資料";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.flowLayoutPanel2.Location = new System.Drawing.Point(18, 34);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(8, 8, 2, 8);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(285, 186);
            this.flowLayoutPanel2.TabIndex = 8;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.richTextBox);
            this.panel1.Location = new System.Drawing.Point(346, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 364);
            this.panel1.TabIndex = 14;
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
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(0, 52);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(880, 308);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // Richstatistics
            // 
            this.Richstatistics.Location = new System.Drawing.Point(346, 424);
            this.Richstatistics.Name = "Richstatistics";
            this.Richstatistics.Size = new System.Drawing.Size(878, 181);
            this.Richstatistics.TabIndex = 0;
            this.Richstatistics.Text = "";
            // 
            // Grade_0306
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1239, 616);
            this.Controls.Add(this.Richstatistics);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnstatistics);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Grade_0306";
            this.Text = "Grade";
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnstatistics;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labChi;
        private System.Windows.Forms.TextBox txtChi;
        private System.Windows.Forms.Label labEng;
        private System.Windows.Forms.TextBox txtEng;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Richstatistics;
    }
}