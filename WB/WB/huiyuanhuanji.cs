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
    public partial class huiyuanhuanji : Form
    {
        public huiyuanhuanji()
        {
            InitializeComponent();
        }

        private void huiyuanhuanji_Load(object sender, EventArgs e)
        {
            this.cmbb.Items.Clear();
            this.cnew.Items.Clear();

            SqlConnection conn = DBwangba.getConn();
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from PCInfo where PCUse = 1";
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string PCid = rd[0].ToString();
                    this.cmbb.Items.Add(PCid);
                }
                rd.Close();
                if (cmbb.Items.Count > 0)
                {
                    this.cmbb.SelectedIndex = this.cmbb.Items.Count - 1;
                }

                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = "select * from PCInfo where PCUse = 0";
                SqlDataReader rd2 = cmd2.ExecuteReader();

                while (rd2.Read())
                {
                    string PCid2 = rd2[0].ToString();
                    this.cnew.Items.Add(PCid2);
                }
                if (cnew.Items.Count > 0)
                {
                    this.cnew.SelectedIndex = this.cnew.Items.Count - 1;
                }
                rd2.Close();
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_huanji_Click(object sender, EventArgs e)
        {
            string str1 = this.cmbb.Text;
            string str2 = this.cnew.Text;
            SqlConnection conn = DBwangba.getConn();
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {

                string sql2 = string.Format("update PCInfo set PCUse ='0'where PCId = '{0}'", str1);
                int rz = DBwangba.BaseExec(sql2);
                string sql3 = string.Format("update PCInfo set PCUse = '1' where PCId = '{0}'", str2);
                int rd = DBwangba.BaseExec(sql3);
                string hj = string.Format("update recordInfo set PCId = {0} where pcid = {1}  and endTime is null", str2, str1);
                int rf = DBwangba.BaseExec(hj);
                if (rz > 0 && rd > 0 && rf > 0)
                {
                    string aa = string.Format("换机成功,由{0}换到{1}", str1, str2);
                    MessageBox.Show(aa, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("换机失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();

            }
            else
            {
                MessageBox.Show("连接失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        
    }
}
        
    

