using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WB
{
    public partial class denglu : Form
    {
        ValidCode code = new ValidCode(6, ValidCode.CodeType.Numbers);//实例化ValidCode类
        public denglu()
        {
            InitializeComponent();
            tishi.Visible = false;
            Bitmap bitmap = new Bitmap(code.CreateCheckCodeImage());
            xianshi.Image = bitmap;
        }
        SqlConnection conn = null;
        private void button1_Click(object sender, EventArgs e)
        {
            string qq = this.username.Text;
            string ww = this.password.Text.Trim();
            string ee = this.textBoxxx.Text;
            if (qq == "" || ww == "" || ee == "")
            {
                Bitmap bitmap = new Bitmap(code.CreateCheckCodeImage());
                xianshi.Image = bitmap;
                MessageBox.Show("请填写完整信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tishi.Visible = true;
                tishi.ForeColor = Color.Red;
                tishi.Text = "验证码错误";
                textBoxxx.Clear();
                textBoxxx.Focus();
                return;
            }


            string constr = "server=.;database=NetBarDB;uid=sa;pwd=123456";
            conn = new SqlConnection();
            conn.ConnectionString = constr;
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = string.Format("select*from admin where admin= '{0}' and password='{1}'", qq, ww);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read() && textBoxxx.Text == code.CheckCode)
                {
                        tishi.Visible = true;
                        tishi.ForeColor = Color.Green;
                        tishi.Text = "验证码正确";
                        MessageBox.Show("登陆成功","提示");
                        jiemian dl = new jiemian();
                        this.Hide();
                        dl.Show();
                }
                else
                {
                    tishi.Visible = true;
                    tishi.ForeColor = Color.Red;
                    tishi.Text = "验证码错误";
                    textBoxxx.Clear();
                    textBoxxx.Focus();
                    Bitmap bitmap = new Bitmap(code.CreateCheckCodeImage());
                    xianshi.Image = bitmap;
                    MessageBox.Show("登录失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show("连接失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void xianshi_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(code.CreateCheckCodeImage());
            xianshi.Image = bitmap;
        }

        private void denglu_Load(object sender, EventArgs e)
        {
            string skin = "Skins//DiamondBlue.ssk";
            skinEngine2.SkinFile = skin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否退出？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            } 
            
        }

        private void textBoxxx_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxxx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else
            {
                //MessageBox.Show("请输入数字", "错误", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void zhuce_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            guanliyuanzhuce guan = new guanliyuanzhuce();
            guan.Show();

        }
    }
}
