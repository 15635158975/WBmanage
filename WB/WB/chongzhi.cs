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
    public partial class chongzhi : Form
    {
        public chongzhi()
        {
            InitializeComponent();
        }

        private void chongzhi_Load(object sender, EventArgs e)
        {
            wareName();
        }
        public void wareName()
        {
            SqlConnection conn = DBwangba.getConn();
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                string sql = "select * from cardInfo";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                if (ds.Tables[0].DefaultView != null)
                {
                    this.comboBox1.DataSource = ds.Tables[0].DefaultView;
                    this.comboBox1.DisplayMember = "cardNumber";
                    this.comboBox1.ValueMember = "cardId";
                }
                if (this.comboBox1.Items.Count > 0)
                {
                    //默认选择最后一项
                    this.comboBox1.SelectedIndex = this.comboBox1.Items.Count -9 ;
                }
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string qq = this.money.Text;
            if (qq == "" )
            {
                MessageBox.Show("请输入金额！");
                return;
            }
            SqlConnection conn = DBwangba.getConn();
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {

                string money = this.money.Text;
                string cardNumber = this.comboBox1.Text;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                string sql = string.Format("update cardInfo set cardBalance=cardBalance+{0} where  cardNumber='{1}' ", money, cardNumber);
                cmd.CommandText = sql;
                int rz = cmd.ExecuteNonQuery();
                if (rz > 0)
                {    

                    MessageBox.Show("充值成功！");
                    this.Hide();
                    jiemian chuang = new jiemian();
                    chuang.ShowDialog();
                    this.Close();
                    return;

                }
                else
                {
                    MessageBox.Show("充值失败！");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void money_TextChanged(object sender, EventArgs e)
        {
           

            
            }

        private void money_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8){
                e.Handled = true;
            }else{
                //MessageBox.Show("请输入数字", "错误", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        
        }
    }
}
