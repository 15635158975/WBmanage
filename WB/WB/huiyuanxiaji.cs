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
    public partial class huiyuanxiaji : Form
    {
        public huiyuanxiaji()
        {
            InitializeComponent();
        }

        private void huiyuanxiaji_Load(object sender, EventArgs e)
        {
            this.xiaji.Items.Clear();

            SqlConnection conn = DBwangba.getConn();
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                string sql = "select * from pcInfo where PCUse=1";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string pcid = rd[0].ToString();
                    this.xiaji.Items.Add(pcid);

                }

                if (xiaji.Items.Count > 0)
                {
                    this.xiaji.SelectedIndex = this.xiaji.Items.Count - 1;
                }
                rd.Close();
                conn.Close();
            }
            else
            {
                MessageBox.Show("连接失败", "连接提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DateTime dt = DateTime.Now;
            this.downtime.Text = dt.ToString();
        }
        
        private void btn_quxiao_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void xiaji_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = this.xiaji.Text;


            SqlConnection conn = DBwangba.getConn();
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {

                string sql = "select recordId,cardNumber,a.PCId,a.beginTime from recordInfo as a join cardInfo as b on a.cardId = b.cardId where endTime is null and pcid=" + str;
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string cardNumber = reader[1].ToString();
                    string beginTime = reader[3].ToString();
                    this.name.Text = cardNumber;
                    this.time.Text = beginTime;
                    reader.Close();
                    conn.Close();
                    DateTime bt = Convert.ToDateTime(this.time.Text);   //获取上机时间
                    DateTime et = DateTime.Now;                             // 获取下机时间 当前系统时间
                    TimeSpan ts = Convert.ToDateTime(et).Subtract(bt);      // 系统时间减去上机时间
                    int seconds = (int)ts.TotalSeconds;
                    // 得到连个时间间隔的总秒数(将时间转换为秒)
                    int minutes = seconds / 60;                             // 得到分钟数
                    if (seconds % 60 > 0)
                    {
                        minutes += 1;                                       // 如果描述不能被60整数，则分钟数加1
                    }
                    int hours = minutes / 60;                               // 得到小时数
                    if (minutes % 60 > 0)
                    {
                        hours += 1;                                         // 如果分钟数不能被60整除，则小时数加1
                    }
                    int i = hours * 15;
                    string a = string.Format("{0}", hours);
                    this.shangjiyongshi.Text = a;
                    string b = string.Format("{0}", i);
                    this.feiyong.Text = b;
                }
                else
                {
                    MessageBox.Show("查找不到结果", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
            }
        }

        private void btn_xiaji_Click(object sender, EventArgs e)
        {
            string str1 = this.xiaji.Text;
            string str2 = this.name.Text;
            string str3 = this.time.Text;
            string str4 = this.downtime.Text;
            string str5 = this.shangjiyongshi.Text;
            string str6 = this.feiyong.Text;
            SqlConnection conn = DBwangba.getConn();
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = string.Format("select cardBalance from cardInfo where cardNumber = '{0}'", str2);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    string cardBalance = rd[0].ToString();
                    rd.Close();
                    if (int.Parse(cardBalance) < int.Parse(str6))
                    {
                        MessageBox.Show("您的余额不足，请充值", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        chongzhi cz = new chongzhi();
                        cz.Show();

                    }
                    else
                    {

                        string sql = string.Format("update recordInfo set endTime ='{0}',free='{1}' where pcid ={2} and endtime is null", str4, str6,str1);
                        int rz = DBwangba.BaseExec(sql);
                        string sql2 = string.Format("update PCInfo set PCUse = 0 where PCId = '{0}'", str1);
                        int rx = DBwangba.BaseExec(sql2);
                        string sql3 = string.Format("update cardInfo set cardBalance = cardBalance - '{0}' where cardNumber= '{1}'", str6, str2);
                        int rc = DBwangba.BaseExec(sql3);
                        if (rz > 0 && rx > 0 && rc > 0)
                        {
                            MessageBox.Show("下机成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("下机失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }

                    }

                }
                conn.Close();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.downtime.Text = dt.ToString();
        }

        private void time_TextChanged(object sender, EventArgs e)
        {

        }

        private void downtime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
