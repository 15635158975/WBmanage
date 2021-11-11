namespace WB
{
    partial class chaxun
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
            this.user = new System.Windows.Forms.TextBox();
            this.btn_guanbi = new System.Windows.Forms.Button();
            this.xiaji = new System.Windows.Forms.TextBox();
            this.mima = new System.Windows.Forms.TextBox();
            this.yue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(86, 35);
            this.user.Margin = new System.Windows.Forms.Padding(4);
            this.user.Name = "user";
            this.user.ReadOnly = true;
            this.user.Size = new System.Drawing.Size(189, 25);
            this.user.TabIndex = 18;
            // 
            // btn_guanbi
            // 
            this.btn_guanbi.Location = new System.Drawing.Point(111, 236);
            this.btn_guanbi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guanbi.Name = "btn_guanbi";
            this.btn_guanbi.Size = new System.Drawing.Size(97, 34);
            this.btn_guanbi.TabIndex = 17;
            this.btn_guanbi.Text = "关闭";
            this.btn_guanbi.UseVisualStyleBackColor = true;
            this.btn_guanbi.Click += new System.EventHandler(this.btn_guanbi_Click);
            // 
            // xiaji
            // 
            this.xiaji.Location = new System.Drawing.Point(86, 189);
            this.xiaji.Margin = new System.Windows.Forms.Padding(4);
            this.xiaji.Name = "xiaji";
            this.xiaji.ReadOnly = true;
            this.xiaji.Size = new System.Drawing.Size(189, 25);
            this.xiaji.TabIndex = 16;
            // 
            // mima
            // 
            this.mima.Location = new System.Drawing.Point(86, 86);
            this.mima.Margin = new System.Windows.Forms.Padding(4);
            this.mima.Name = "mima";
            this.mima.ReadOnly = true;
            this.mima.Size = new System.Drawing.Size(189, 25);
            this.mima.TabIndex = 15;
            // 
            // yue
            // 
            this.yue.Location = new System.Drawing.Point(86, 138);
            this.yue.Margin = new System.Windows.Forms.Padding(4);
            this.yue.Name = "yue";
            this.yue.ReadOnly = true;
            this.yue.Size = new System.Drawing.Size(189, 25);
            this.yue.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "办卡时间";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "余   额";
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "密   码";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "会员卡号";
            this.label1.UseWaitCursor = true;
            // 
            // chaxun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 307);
            this.Controls.Add(this.user);
            this.Controls.Add(this.btn_guanbi);
            this.Controls.Add(this.xiaji);
            this.Controls.Add(this.mima);
            this.Controls.Add(this.yue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "chaxun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "信息查询";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Button btn_guanbi;
        public System.Windows.Forms.TextBox xiaji;
        public System.Windows.Forms.TextBox mima;
        public System.Windows.Forms.TextBox yue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}