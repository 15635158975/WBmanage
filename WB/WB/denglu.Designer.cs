namespace WB
{
    partial class denglu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tishi = new System.Windows.Forms.Label();
            this.xianshi = new System.Windows.Forms.PictureBox();
            this.yanzhengma = new System.Windows.Forms.Label();
            this.textBoxxx = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.yonghu = new System.Windows.Forms.Label();
            this.mima = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.skinEngine2 = new Sunisoft.IrisSkin.SkinEngine();
            this.zhuce = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xianshi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.zhuce);
            this.groupBox1.Controls.Add(this.tishi);
            this.groupBox1.Controls.Add(this.xianshi);
            this.groupBox1.Controls.Add(this.yanzhengma);
            this.groupBox1.Controls.Add(this.textBoxxx);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.yonghu);
            this.groupBox1.Controls.Add(this.mima);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(89, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 276);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "网吧计费后台登录";
            // 
            // tishi
            // 
            this.tishi.AutoSize = true;
            this.tishi.Location = new System.Drawing.Point(128, 188);
            this.tishi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tishi.Name = "tishi";
            this.tishi.Size = new System.Drawing.Size(55, 15);
            this.tishi.TabIndex = 13;
            this.tishi.Text = "label1";
            // 
            // xianshi
            // 
            this.xianshi.Location = new System.Drawing.Point(232, 148);
            this.xianshi.Margin = new System.Windows.Forms.Padding(4);
            this.xianshi.Name = "xianshi";
            this.xianshi.Size = new System.Drawing.Size(127, 26);
            this.xianshi.TabIndex = 12;
            this.xianshi.TabStop = false;
            this.xianshi.Click += new System.EventHandler(this.xianshi_Click);
            // 
            // yanzhengma
            // 
            this.yanzhengma.AutoSize = true;
            this.yanzhengma.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yanzhengma.Location = new System.Drawing.Point(36, 150);
            this.yanzhengma.Name = "yanzhengma";
            this.yanzhengma.Size = new System.Drawing.Size(66, 19);
            this.yanzhengma.TabIndex = 11;
            this.yanzhengma.Text = "验证码";
            // 
            // textBoxxx
            // 
            this.textBoxxx.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxxx.Location = new System.Drawing.Point(131, 146);
            this.textBoxxx.MaxLength = 4;
            this.textBoxxx.Name = "textBoxxx";
            this.textBoxxx.Size = new System.Drawing.Size(87, 28);
            this.textBoxxx.TabIndex = 10;
            this.textBoxxx.TextChanged += new System.EventHandler(this.textBoxxx_TextChanged);
            this.textBoxxx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxxx_KeyPress);
            // 
            // username
            // 
            this.username.AcceptsReturn = true;
            this.username.AcceptsTab = true;
            this.username.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.username.Location = new System.Drawing.Point(131, 55);
            this.username.MaxLength = 10;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(195, 25);
            this.username.TabIndex = 0;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(131, 99);
            this.password.MaxLength = 10;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(195, 25);
            this.password.TabIndex = 5;
            this.password.UseSystemPasswordChar = true;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // yonghu
            // 
            this.yonghu.AutoSize = true;
            this.yonghu.BackColor = System.Drawing.Color.Transparent;
            this.yonghu.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yonghu.Location = new System.Drawing.Point(33, 55);
            this.yonghu.Name = "yonghu";
            this.yonghu.Size = new System.Drawing.Size(66, 19);
            this.yonghu.TabIndex = 1;
            this.yonghu.Text = "用户名";
            // 
            // mima
            // 
            this.mima.AutoSize = true;
            this.mima.BackColor = System.Drawing.Color.Transparent;
            this.mima.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mima.Location = new System.Drawing.Point(32, 105);
            this.mima.Name = "mima";
            this.mima.Size = new System.Drawing.Size(67, 19);
            this.mima.TabIndex = 4;
            this.mima.Text = "密  码";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // skinEngine2
            // 
            this.skinEngine2.@__DrawButtonFocusRectangle = true;
            this.skinEngine2.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine2.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine2.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine2.SerialNumber = "";
            this.skinEngine2.SkinFile = null;
            // 
            // zhuce
            // 
            this.zhuce.AutoSize = true;
            this.zhuce.Location = new System.Drawing.Point(239, 188);
            this.zhuce.Name = "zhuce";
            this.zhuce.Size = new System.Drawing.Size(82, 15);
            this.zhuce.TabIndex = 14;
            this.zhuce.TabStop = true;
            this.zhuce.Text = "管理员注册";
            this.zhuce.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.zhuce_LinkClicked);
            // 
            // denglu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(585, 399);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "denglu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "denglu";
            this.Load += new System.EventHandler(this.denglu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xianshi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label tishi;
        private System.Windows.Forms.PictureBox xianshi;
        private System.Windows.Forms.Label yanzhengma;
        private System.Windows.Forms.TextBox textBoxxx;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label yonghu;
        private System.Windows.Forms.Label mima;
        private System.Windows.Forms.Button button1;
        private Sunisoft.IrisSkin.SkinEngine skinEngine2;
        private System.Windows.Forms.LinkLabel zhuce;
    }
}