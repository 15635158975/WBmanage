namespace WB
{
    partial class huiyuanshangji
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
            this.btn_cancle = new System.Windows.Forms.Button();
            this.btnshangji = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.shangji = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_cancle
            // 
            this.btn_cancle.Location = new System.Drawing.Point(195, 264);
            this.btn_cancle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(87, 32);
            this.btn_cancle.TabIndex = 19;
            this.btn_cancle.Text = "取消";
            this.btn_cancle.UseVisualStyleBackColor = true;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // btnshangji
            // 
            this.btnshangji.Location = new System.Drawing.Point(66, 264);
            this.btnshangji.Margin = new System.Windows.Forms.Padding(4);
            this.btnshangji.Name = "btnshangji";
            this.btnshangji.Size = new System.Drawing.Size(87, 32);
            this.btnshangji.TabIndex = 18;
            this.btnshangji.Text = "上机";
            this.btnshangji.UseVisualStyleBackColor = true;
            this.btnshangji.Click += new System.EventHandler(this.btn_shangji_Click);
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(83, 197);
            this.time.Margin = new System.Windows.Forms.Padding(4);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(187, 25);
            this.time.TabIndex = 17;
            this.time.TextChanged += new System.EventHandler(this.txt_time_TextChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(83, 137);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.MaxLength = 15;
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(187, 25);
            this.password.TabIndex = 16;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(83, 77);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.MaxLength = 6;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(187, 25);
            this.name.TabIndex = 15;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            this.name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_KeyPress);
            // 
            // shangji
            // 
            this.shangji.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shangji.FormattingEnabled = true;
            this.shangji.Location = new System.Drawing.Point(83, 25);
            this.shangji.Margin = new System.Windows.Forms.Padding(4);
            this.shangji.MaxDropDownItems = 100;
            this.shangji.Name = "shangji";
            this.shangji.Size = new System.Drawing.Size(187, 23);
            this.shangji.TabIndex = 100;
            this.shangji.SelectedIndexChanged += new System.EventHandler(this.cmbb_pcid_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "卡号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "时间";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "机器";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // huiyuanshangji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 325);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.btnshangji);
            this.Controls.Add(this.time);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Controls.Add(this.shangji);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "huiyuanshangji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会员上机";
            this.Load += new System.EventHandler(this.huiyuanshangji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.Button btnshangji;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.ComboBox shangji;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}