namespace WB
{
    partial class huiyuanzhuxiao
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
            this.btn_queding = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvWarePrice = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarePrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancle
            // 
            this.btn_cancle.Location = new System.Drawing.Point(360, 317);
            this.btn_cancle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(123, 39);
            this.btn_cancle.TabIndex = 11;
            this.btn_cancle.Text = "取消";
            this.btn_cancle.UseVisualStyleBackColor = true;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // btn_queding
            // 
            this.btn_queding.Location = new System.Drawing.Point(95, 317);
            this.btn_queding.Margin = new System.Windows.Forms.Padding(4);
            this.btn_queding.Name = "btn_queding";
            this.btn_queding.Size = new System.Drawing.Size(123, 39);
            this.btn_queding.TabIndex = 8;
            this.btn_queding.Text = "注销";
            this.btn_queding.UseVisualStyleBackColor = true;
            this.btn_queding.Click += new System.EventHandler(this.btn_queding_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvWarePrice);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 271);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // dgvWarePrice
            // 
            this.dgvWarePrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWarePrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWarePrice.Location = new System.Drawing.Point(3, 21);
            this.dgvWarePrice.Margin = new System.Windows.Forms.Padding(4);
            this.dgvWarePrice.MultiSelect = false;
            this.dgvWarePrice.Name = "dgvWarePrice";
            this.dgvWarePrice.RowTemplate.Height = 23;
            this.dgvWarePrice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWarePrice.Size = new System.Drawing.Size(616, 247);
            this.dgvWarePrice.TabIndex = 1;
            this.dgvWarePrice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWarePrice_CellContentClick);
            // 
            // huiyuanzhuxiao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 383);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.btn_queding);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "huiyuanzhuxiao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会员注销";
            this.Load += new System.EventHandler(this.huiyuanzhuxiao_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarePrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.Button btn_queding;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvWarePrice;
    }
}