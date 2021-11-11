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
    public partial class xiugaimima : Form
    {
        public xiugaimima()
        {
            InitializeComponent();
        }

        private void xiugaimima_Load(object sender, EventArgs e)
        {

        }

        private void btn_quxiao_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_updata_Click(object sender, EventArgs e)
        {
            //判断文本框不能为空值
            string qq = this.name.Text;
            string ww = this.jiumima.Text.Trim();
            string ee = this.xinmima.Text.Trim();
            string rr = this.xinmima2.Text.Trim();
            if (qq == "" || ww == "" || ee == "" || rr == "")
            {
                MessageBox.Show("请填写完整信息！");
                return;
            }
           
            if (ee != rr)
            {
                MessageBox.Show("两次密码不一致！请重新输入！");
                return;
            }
            if (ee.Length < 6 )
            {
                MessageBox.Show("新密码密码不能小于6位！");
                return;
            }
            SqlConnection conn = DBwangba.getConn();
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = string.Format("select*from  cardInfo where cardNumber= '{0}' and cardPassword='{1}'", qq, ww);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    MessageBox.Show("用户确认成功！");
                    wareName();
                    this.Hide();
                }else{
                    MessageBox.Show("用户确认失败！请重新输入！");
                }
            }
            
        }
                public void wareName()
        {
            SqlConnection conn = DBwangba.getConn();
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                string jiumima = this.xinmima.Text;
                string name = this.name.Text;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                //string sqq = this.comboBox1.Text;
                string sql = string.Format("update cardInfo set cardPassword={0} where  cardNumber='{1}' ", jiumima, name);
                //sql = sqq + money;
                cmd.CommandText = sql;
                int rz = cmd.ExecuteNonQuery();

                if (rz > 0)
                {
                    MessageBox.Show("修改成功！");
                    this.Hide();
                    return;
                }
                else
                {
                    MessageBox.Show("修改失败！");
                }
            }
                }

                private void jiumima_TextChanged(object sender, EventArgs e)
                {
                    
                }

                private void name_KeyPress(object sender, KeyPressEventArgs e)
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
            }
        }
    

