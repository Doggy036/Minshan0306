namespace Minshan0306
{
    partial class MyCalc_0306
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
            this.lab1 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.labAns = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.labOption = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab1.Location = new System.Drawing.Point(24, 37);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(77, 24);
            this.lab1.TabIndex = 0;
            this.lab1.Text = "Num1 :";
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab2.Location = new System.Drawing.Point(24, 80);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(77, 24);
            this.lab2.TabIndex = 1;
            this.lab2.Text = "Num2 :";
            // 
            // labAns
            // 
            this.labAns.AutoSize = true;
            this.labAns.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAns.Location = new System.Drawing.Point(24, 128);
            this.labAns.Name = "labAns";
            this.labAns.Size = new System.Drawing.Size(89, 24);
            this.labAns.TabIndex = 2;
            this.labAns.Text = "Answer :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(24, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(322, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "---------------------------------------";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(123, 39);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(207, 22);
            this.txtNum1.TabIndex = 4;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(123, 79);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(207, 22);
            this.txtNum2.TabIndex = 5;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(123, 128);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(207, 22);
            this.txtAnswer.TabIndex = 6;
            // 
            // labOption
            // 
            this.labOption.AutoSize = true;
            this.labOption.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labOption.Location = new System.Drawing.Point(409, 9);
            this.labOption.Name = "labOption";
            this.labOption.Size = new System.Drawing.Size(86, 24);
            this.labOption.TabIndex = 7;
            this.labOption.Text = "計算選項";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnDivide);
            this.panel1.Controls.Add(this.btnMultiply);
            this.panel1.Controls.Add(this.btnSubtract);
            this.panel1.Controls.Add(this.btnPlus);
            this.panel1.Location = new System.Drawing.Point(370, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 111);
            this.panel1.TabIndex = 8;
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(94, 40);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 23);
            this.btnDivide.TabIndex = 3;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click_1);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(3, 40);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(75, 23);
            this.btnMultiply.TabIndex = 2;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click_1);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(94, 3);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(75, 23);
            this.btnSubtract.TabIndex = 1;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click_1);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(3, 3);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click_1);
            // 
            // MyClac_0306
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 170);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labOption);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labAns);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.lab1);
            this.Name = "MyClac_0306";
            this.Text = "MyClac_0306";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Label labAns;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label labOption;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnPlus;
    }
}