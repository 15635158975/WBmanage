namespace WB
{
    partial class guanliyuanzhuce
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
            this.btn_cancle = new System.Windows.Forms.Button();
            this.btn_zhuce = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.password2 = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.skinEngine2 = new Sunisoft.IrisSkin.SkinEngine();
            this.SuspendLayout();
            // 
            // btn_cancle
            // 
            this.btn_cancle.Location = new System.Drawing.Point(220, 246);
            this.btn_cancle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(88, 30);
            this.btn_cancle.TabIndex = 29;
            this.btn_cancle.Text = "取消";
            this.btn_cancle.UseVisualStyleBackColor = true;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // btn_zhuce
            // 
            this.btn_zhuce.Location = new System.Drawing.Point(50, 246);
            this.btn_zhuce.Margin = new System.Windows.Forms.Padding(4);
            this.btn_zhuce.Name = "btn_zhuce";
            this.btn_zhuce.Size = new System.Drawing.Size(88, 30);
            this.btn_zhuce.TabIndex = 28;
            this.btn_zhuce.Text = "注册";
            this.btn_zhuce.UseVisualStyleBackColor = true;
            this.btn_zhuce.Click += new System.EventHandler(this.btn_zhuce_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(124, 94);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.MaxLength = 6;
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(163, 25);
            this.password.TabIndex = 26;
            // 
            // password2
            // 
            this.password2.Location = new System.Drawing.Point(124, 149);
            this.password2.Margin = new System.Windows.Forms.Padding(4);
            this.password2.MaxLength = 6;
            this.password2.Multiline = true;
            this.password2.Name = "password2";
            this.password2.PasswordChar = '*';
            this.password2.Size = new System.Drawing.Size(163, 25);
            this.password2.TabIndex = 25;
            // 
            // name
            // 
            this.name.AcceptsReturn = true;
            this.name.AcceptsTab = true;
            this.name.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.name.Location = new System.Drawing.Point(124, 39);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.MaxLength = 6;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(163, 25);
            this.name.TabIndex = 24;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            this.name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "确认密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "账号";
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
            // guanliyuanzhuce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 306);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.btn_zhuce);
            this.Controls.Add(this.password);
            this.Controls.Add(this.password2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guanliyuanzhuce";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员帐号注册";
            this.Load += new System.EventHandler(this.guanliyuanzhuce_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.Button btn_zhuce;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox password2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Sunisoft.IrisSkin.SkinEngine skinEngine2;
    }
}