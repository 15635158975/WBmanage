namespace WB
{
    partial class huiyuanhuanji
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
            this.button2 = new System.Windows.Forms.Button();
            this.huanji = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cnew = new System.Windows.Forms.ComboBox();
            this.cmbb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 127);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 29);
            this.button2.TabIndex = 13;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // huanji
            // 
            this.huanji.Location = new System.Drawing.Point(76, 127);
            this.huanji.Margin = new System.Windows.Forms.Padding(4);
            this.huanji.Name = "huanji";
            this.huanji.Size = new System.Drawing.Size(88, 29);
            this.huanji.TabIndex = 12;
            this.huanji.Text = "换机";
            this.huanji.UseVisualStyleBackColor = true;
            this.huanji.Click += new System.EventHandler(this.btn_huanji_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "现在的机器";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "要换到的机器";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "换到";
            // 
            // cnew
            // 
            this.cnew.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cnew.FormattingEnabled = true;
            this.cnew.Location = new System.Drawing.Point(219, 76);
            this.cnew.Margin = new System.Windows.Forms.Padding(4);
            this.cnew.Name = "cnew";
            this.cnew.Size = new System.Drawing.Size(96, 23);
            this.cnew.TabIndex = 8;
            // 
            // cmbb
            // 
            this.cmbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbb.FormattingEnabled = true;
            this.cmbb.Location = new System.Drawing.Point(67, 76);
            this.cmbb.Margin = new System.Windows.Forms.Padding(4);
            this.cmbb.Name = "cmbb";
            this.cmbb.Size = new System.Drawing.Size(96, 23);
            this.cmbb.TabIndex = 7;
            // 
            // huiyuanhuanji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 236);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.huanji);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cnew);
            this.Controls.Add(this.cmbb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "huiyuanhuanji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会员换机";
            this.Load += new System.EventHandler(this.huiyuanhuanji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button huanji;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cnew;
        private System.Windows.Forms.ComboBox cmbb;
    }
}