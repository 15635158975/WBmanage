namespace WB
{
    partial class huiyuanxiaji
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
            this.components = new System.ComponentModel.Container();
            this.label8 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.xiaji = new System.Windows.Forms.ComboBox();
            this.btn_quxiao = new System.Windows.Forms.Button();
            this.btn_xiaji = new System.Windows.Forms.Button();
            this.downtime = new System.Windows.Forms.TextBox();
            this.shangjiyongshi = new System.Windows.Forms.TextBox();
            this.feiyong = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(296, 270);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 15);
            this.label8.TabIndex = 33;
            this.label8.Text = "元";
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(124, 116);
            this.time.Margin = new System.Windows.Forms.Padding(4);
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Size = new System.Drawing.Size(163, 25);
            this.time.TabIndex = 30;
            this.time.TextChanged += new System.EventHandler(this.time_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 124);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "上机时间";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "机器编号";
            // 
            // xiaji
            // 
            this.xiaji.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xiaji.FormattingEnabled = true;
            this.xiaji.Location = new System.Drawing.Point(124, 29);
            this.xiaji.Margin = new System.Windows.Forms.Padding(4);
            this.xiaji.Name = "xiaji";
            this.xiaji.Size = new System.Drawing.Size(160, 23);
            this.xiaji.TabIndex = 27;
            this.xiaji.SelectedIndexChanged += new System.EventHandler(this.xiaji_SelectedIndexChanged);
            // 
            // btn_quxiao
            // 
            this.btn_quxiao.Location = new System.Drawing.Point(206, 322);
            this.btn_quxiao.Margin = new System.Windows.Forms.Padding(4);
            this.btn_quxiao.Name = "btn_quxiao";
            this.btn_quxiao.Size = new System.Drawing.Size(81, 29);
            this.btn_quxiao.TabIndex = 26;
            this.btn_quxiao.Text = "取消";
            this.btn_quxiao.UseVisualStyleBackColor = true;
            this.btn_quxiao.Click += new System.EventHandler(this.btn_quxiao_Click);
            // 
            // btn_xiaji
            // 
            this.btn_xiaji.Location = new System.Drawing.Point(117, 322);
            this.btn_xiaji.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xiaji.Name = "btn_xiaji";
            this.btn_xiaji.Size = new System.Drawing.Size(81, 29);
            this.btn_xiaji.TabIndex = 25;
            this.btn_xiaji.Text = "下机";
            this.btn_xiaji.UseVisualStyleBackColor = true;
            this.btn_xiaji.Click += new System.EventHandler(this.btn_xiaji_Click);
            // 
            // downtime
            // 
            this.downtime.Location = new System.Drawing.Point(124, 164);
            this.downtime.Margin = new System.Windows.Forms.Padding(4);
            this.downtime.Name = "downtime";
            this.downtime.ReadOnly = true;
            this.downtime.Size = new System.Drawing.Size(163, 25);
            this.downtime.TabIndex = 24;
            this.downtime.TextChanged += new System.EventHandler(this.downtime_TextChanged);
            // 
            // shangjiyongshi
            // 
            this.shangjiyongshi.Location = new System.Drawing.Point(124, 212);
            this.shangjiyongshi.Margin = new System.Windows.Forms.Padding(4);
            this.shangjiyongshi.Name = "shangjiyongshi";
            this.shangjiyongshi.ReadOnly = true;
            this.shangjiyongshi.Size = new System.Drawing.Size(163, 25);
            this.shangjiyongshi.TabIndex = 23;
            // 
            // feiyong
            // 
            this.feiyong.Location = new System.Drawing.Point(124, 259);
            this.feiyong.Margin = new System.Windows.Forms.Padding(4);
            this.feiyong.Name = "feiyong";
            this.feiyong.ReadOnly = true;
            this.feiyong.Size = new System.Drawing.Size(163, 25);
            this.feiyong.TabIndex = 22;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(124, 76);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(163, 25);
            this.name.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "下机时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 263);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "本次费用";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 216);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "上机用时";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "会员账号";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 218);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 34;
            this.label7.Text = "小时";
            // 
            // huiyuanxiaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 392);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.xiaji);
            this.Controls.Add(this.btn_quxiao);
            this.Controls.Add(this.btn_xiaji);
            this.Controls.Add(this.downtime);
            this.Controls.Add(this.shangjiyongshi);
            this.Controls.Add(this.feiyong);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "huiyuanxiaji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会员下机";
            this.Load += new System.EventHandler(this.huiyuanxiaji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox xiaji;
        private System.Windows.Forms.Button btn_quxiao;
        private System.Windows.Forms.Button btn_xiaji;
        private System.Windows.Forms.TextBox downtime;
        private System.Windows.Forms.TextBox shangjiyongshi;
        private System.Windows.Forms.TextBox feiyong;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
    }
}