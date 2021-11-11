namespace WB
{
    partial class xiugaimima
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
            this.xinmima2 = new System.Windows.Forms.TextBox();
            this.jiumima = new System.Windows.Forms.TextBox();
            this.xinmima = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.quxiao = new System.Windows.Forms.Button();
            this.updata = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // xinmima2
            // 
            this.xinmima2.Location = new System.Drawing.Point(122, 210);
            this.xinmima2.Margin = new System.Windows.Forms.Padding(4);
            this.xinmima2.MaxLength = 15;
            this.xinmima2.Multiline = true;
            this.xinmima2.Name = "xinmima2";
            this.xinmima2.PasswordChar = '*';
            this.xinmima2.Size = new System.Drawing.Size(167, 25);
            this.xinmima2.TabIndex = 19;
            // 
            // jiumima
            // 
            this.jiumima.Location = new System.Drawing.Point(122, 95);
            this.jiumima.Margin = new System.Windows.Forms.Padding(4);
            this.jiumima.MaxLength = 15;
            this.jiumima.Multiline = true;
            this.jiumima.Name = "jiumima";
            this.jiumima.PasswordChar = '*';
            this.jiumima.Size = new System.Drawing.Size(167, 25);
            this.jiumima.TabIndex = 15;
            this.jiumima.TextChanged += new System.EventHandler(this.jiumima_TextChanged);
            // 
            // xinmima
            // 
            this.xinmima.Location = new System.Drawing.Point(122, 153);
            this.xinmima.Margin = new System.Windows.Forms.Padding(4);
            this.xinmima.MaxLength = 15;
            this.xinmima.Multiline = true;
            this.xinmima.Name = "xinmima";
            this.xinmima.PasswordChar = '*';
            this.xinmima.Size = new System.Drawing.Size(167, 25);
            this.xinmima.TabIndex = 17;
            // 
            // name
            // 
            this.name.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.name.Location = new System.Drawing.Point(122, 37);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.MaxLength = 6;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(167, 25);
            this.name.TabIndex = 16;
            this.name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_KeyPress);
            // 
            // quxiao
            // 
            this.quxiao.Location = new System.Drawing.Point(216, 270);
            this.quxiao.Margin = new System.Windows.Forms.Padding(4);
            this.quxiao.Name = "quxiao";
            this.quxiao.Size = new System.Drawing.Size(73, 29);
            this.quxiao.TabIndex = 15;
            this.quxiao.Text = "取消";
            this.quxiao.UseVisualStyleBackColor = true;
            this.quxiao.Click += new System.EventHandler(this.btn_quxiao_Click);
            // 
            // updata
            // 
            this.updata.Location = new System.Drawing.Point(86, 270);
            this.updata.Margin = new System.Windows.Forms.Padding(4);
            this.updata.Name = "updata";
            this.updata.Size = new System.Drawing.Size(73, 29);
            this.updata.TabIndex = 14;
            this.updata.Text = "修改";
            this.updata.UseVisualStyleBackColor = true;
            this.updata.Click += new System.EventHandler(this.btn_updata_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 221);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "确认密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "旧密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "新密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "会员号";
            // 
            // xiugaimima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 340);
            this.Controls.Add(this.xinmima2);
            this.Controls.Add(this.jiumima);
            this.Controls.Add(this.xinmima);
            this.Controls.Add(this.name);
            this.Controls.Add(this.quxiao);
            this.Controls.Add(this.updata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xiugaimima";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.xiugaimima_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xinmima2;
        private System.Windows.Forms.TextBox jiumima;
        private System.Windows.Forms.TextBox xinmima;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button quxiao;
        private System.Windows.Forms.Button updata;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}