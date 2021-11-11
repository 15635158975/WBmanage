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
    public partial class huiyuanshangji : Form
    {
        public huiyuanshangji()
        {
            InitializeComponent();
        }

        private void huiyuanshangji_Load(object sender, EventArgs e)
        {
            
            this.time.Text = DateTime.Now.ToString();
            SqlConnection conn = DBwangba.getConn();
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select PCId from PCInfo where PCUse = 0";
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    this.shangji.Items.Add(rd[0].ToString());
                }
                conn.Close();
                if (this.shangji.Items.Count > 0)
                {
                    this.btnshangji.Enabled = true;
                    this.shangji.SelectedIndex = this.shangji.Items.Count - 9;
                }
                else
                {
                    this.shangji.Items.Add("没有空闲的机器");
                    this.btnshangji.Enabled = false;
                }
            }
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txt_time_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbb_pcid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_shangji_Click(object sender, EventArgs e)
        {
            username();
        }
        public void username()
        {
            // 1. 数据的判断 文本框是否为空
            string name = this.name.Text.Trim();
            string password = this.password.Text.Trim();
            if (name == "" || password == "")
            {
                MessageBox.Show("请输入完整的会员号或者密码", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 2. 判断用户输入的用户名和密码是否正确
            //  创建连接字符串
            string constr = "server=.;database=NetBarDB;uid=sa;pwd=123456";
            //  创建连接对象 设置连接对象属性
            SqlConnection conn = new SqlConnection(constr);
            //  调用连接对象的打开方法
            conn.Open();
            //  判断是否连接成功
            if (conn.State == ConnectionState.Open)
            {
                string sql = string.Format("select cardid,cardPassword,cardBalance from cardInfo where cardNumber = '{0}' and cardPassword = '{1}'", name, password);
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    string cardid = ds.Tables[0].Rows[0]["cardid"].ToString();

                    string cardPassword = ds.Tables[0].Rows[0]["cardPassword"].ToString();
                    string cardBalance = ds.Tables[0].Rows[0]["cardBalance"].ToString();

                    // 创建操作对象
                    SqlCommand cmd = new SqlCommand();
                    // 设置操作对象的属性
                    cmd.Connection = conn;
                    // 3. 判断用户的余额是否大于10
                    if (int.Parse(cardBalance) >= 10)
                    {
                        // 判断会员是否在上机
                        string sql2 = string.Format("select * from recordInfo where cardId='{0}' and beginTime is not null and endTime is null", cardid);
                        cmd.CommandText = sql2;
                        Object obj = cmd.ExecuteScalar();
                        if (obj == null)
                        {
                            // 4. 修改计算机的状态
                            string com = this.shangji.Text;
                            string up = string.Format("update PCInfo set PCUse= 1 where PCId={0}", com);
                            cmd.CommandText = up;
                            // 调用操作对象的改方法
                            int rz = cmd.ExecuteNonQuery();
                            //5.插入上机记录
                            string str3 = this.time.Text;
                            string str4 = this.shangji.Text;
                            string sql3 = string.Format("insert into recordInfo values({0},{1},GETDATE(),null,2)", cardid, str4);
                            cmd.CommandText = sql3;
                            int rd = cmd.ExecuteNonQuery();
                            // 判断操作成功
                            if (rz > 0 && rd > 0)
                            {
                                MessageBox.Show("上机成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("上机失败", "提示");
                                
                            }

                        }
                        else
                        {
                            MessageBox.Show("该会员正在上机", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("您的余额小于10，请及时充值！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("您的账号或者密码有误，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conn.Close();
            }
            else
            {
                // 连接失败
                MessageBox.Show("连接失败", "连接提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
                 


            
        


        

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.time.Text =  DateTime.Now.ToString();
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
