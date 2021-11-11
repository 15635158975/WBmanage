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
    public partial class guanliyuanzhuce : Form
    {
        public guanliyuanzhuce()
        {
            InitializeComponent();
        }

        private void guanliyuanzhuce_Load(object sender, EventArgs e)
        {
            string skin = "Skins//DiamondBlue.ssk";
            skinEngine2.SkinFile = skin;
        }

        private void btn_zhuce_Click(object sender, EventArgs e)
        {
            string qq = this.name.Text;
            string ww = this.password.Text.Trim();
            string ee = this.password2.Text.Trim();
            if (qq == "" || ww == "" || ee == "")
            {
                MessageBox.Show("请填写完整信息！");
                return;
            }
            if (qq.Length < 6 || ww.Length < 6)
            {
                MessageBox.Show("用户名或密码不能小于6位！");
                return;
            }
           
            if (ww != ee)
            {
                MessageBox.Show("两次密码不一致！请重新输入！");
                return;
            }
            string name = this.name.Text;
            string password = this.password.Text;
            SqlConnection conn = DBwangba.getConn();
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {

                string we = string.Format("select * from admin where admin = '{0}'", qq);
                SqlCommand cmd = new SqlCommand(we, conn);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    MessageBox.Show("卡号已存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {


                    string sql = string.Format("insert into admin values('{0}','{1}')", name, password);
                    int rz = DBwangba.BaseExec(sql);
                    if (rz > 0)
                    {
                        MessageBox.Show("添加成功！");
                        this.Hide();
                        denglu denglu = new denglu ();
                        denglu.ShowDialog();
                        this.Close();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("添加失败！");
                    }
                }


            }
        }

        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            //{
            //    e.Handled = true;
            //}
            //else
            //{
            //    //MessageBox.Show("请输入数字", "错误", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //}
            if (e.KeyChar < 'A' || e.KeyChar > 'Z' && e.KeyChar < 'a' || e.KeyChar > 'z')
            {

                e.Handled = true;

            }

            //此为退格键可以输入

            if (e.KeyChar == 8)
            {

                e.Handled = false;

            }
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            this.Hide();
            denglu  deng = new denglu();
            deng.ShowDialog();
            this.Close();

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
