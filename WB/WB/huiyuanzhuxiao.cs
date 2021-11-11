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
    public partial class huiyuanzhuxiao : Form
    {
        public huiyuanzhuxiao()
        {
            InitializeComponent();
        }

        private void huiyuanzhuxiao_Load(object sender, EventArgs e)
        {
           zhuxiao();
        }

        private void btn_queding_Click(object sender, EventArgs e)
        {
           
            int id = int.Parse(this.dgvWarePrice.CurrentRow.Cells[0].Value.ToString());
            SqlConnection con = DBwangba.getConn();
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string sql = "delete cardInfo where cardId = {0}";
                sql = string.Format(sql, id);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                int i = cmd.ExecuteNonQuery();
                if (i == 0)
                {
                    MessageBox.Show("删除失败");
                }
                else
                {
                    MessageBox.Show("删除成功");
                    zhuxiao();
                    this.Hide();
                    jiemian chuang = new jiemian();
                    chuang.ShowDialog();
                    this.Close();

                }
                
            }
        }

        private void dgvWarePrice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int cardId = int.Parse(this.dgvWarePrice.Rows[e.RowIndex].Cells[0].Value.ToString());
            float cardNumber = float.Parse(this.dgvWarePrice.Rows[e.RowIndex].Cells[2].Value.ToString());
            int cardBalance = int.Parse(this.dgvWarePrice.Rows[e.RowIndex].Cells[3].Value.ToString());
            string transactTime = this.dgvWarePrice.Rows[e.RowIndex].Cells[4].Value.ToString();
            SqlConnection con = DBwangba.getConn();
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string sql = "update cardInfo set cardId = {0},cardNumber ={1},cardBalance='{2}'where cardInfo={3}";
                sql = string.Format(sql, cardId, cardNumber, cardBalance, transactTime);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                int i = cmd.ExecuteNonQuery();
                if (i == 0)
                {
                    MessageBox.Show("更新失败");
                }
                else
                {
                    MessageBox.Show("更新成功");
                    this.Hide();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("数据库连接失败");
            }
        }
        public void zhuxiao()
        {
            SqlConnection con = DBwangba.getConn();
            con.Open();
            if(con.State == ConnectionState.Open){
                string sql = "select cardId as ID ,cardNumber  会员账号,cardBalance 账户余额,transactTime 注册时间 from cardInfo";
                SqlDataAdapter adapter = new SqlDataAdapter(sql,con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                if(ds.Tables[0].Rows.Count >0){
                    this.dgvWarePrice.DataSource = ds.Tables[0].DefaultView;

                
                }


            
            }
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        }
    }

