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
    public partial class jiemian : Form
    {

        public jiemian()
        {
            //窗体界面皮肤
            string skin = "Skins//DiamondBlue.ssk";
            InitializeComponent();
            skinEngine1.SkinFile = skin;
        }
         
        public jiemian(string qq)
        {
            InitializeComponent();

        }

        private void jiemian_Load(object sender, EventArgs e)
        {
            //调用方法
            InitCardInfo(); //显示会员信息的调用
            ShowRecord();//显示上机记录，营业记录
            CardInfo();//显示电脑信息
            CardIn();//界面各个对应电脑使用状态
           
            


        }
        public void InitCardInfo()//显示会员信息的方法
        {
            //链接数据库  用外接引用
            SqlConnection conn = DBwangba.getConn();
            conn.Open();
            // 验证连接是否成功
            if (conn.State == ConnectionState.Open)
            {
                //查询会员卡号   余额   办卡时间  
                string sql = "select cardId '编号', cardNumber '卡号',cardBalance '余额',transactTime '办卡时间'from cardInfo";
                //string sql = "select cardId as 编号 ,wi.cardNumber as 卡号,cardBalance 余额,transactTime 办卡时间,PCUse as 使用状态 from cardInfo wp,PCInfo wi where wp.wareId = wi.wareId";
                SqlDataAdapter adapte = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adapte.Fill(ds);
                this.data.DataSource = ds.Tables[0].DefaultView;
                conn.Close();
            }
            else
            {
                MessageBox.Show("连接失败");
            }

        }
        public void ShowRecord()//显示上机记录，营业记录方法
        {
            //连接数据库  
            SqlConnection conn = DBwangba.getConn();
            conn.Open();
            // 验证连接是否成功
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                //查询电脑信息
                string sql = "select * from recordInfo order by recordId desc";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                //查询上机  费用信息显示在dataGridView里
                this.dataGridView2.DataSource = ds.Tables[0].DefaultView;
                this.dataGridView2.Columns[0].HeaderText = "记录编号";
                this.dataGridView2.Columns[1].HeaderText = "会员编号";
                this.dataGridView2.Columns[2].HeaderText = "电脑编号";
                this.dataGridView2.Columns[3].HeaderText = "上机时间";
                this.dataGridView2.Columns[4].HeaderText = "下机时间";
                this.dataGridView2.Columns[5].HeaderText = "上机费用";
                conn.Close();
            }
            else
            {
                // 连接失败
                MessageBox.Show("连接失败", "连接提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CardInfo()//显示电脑信息方法
        {
            //连接数据库
            SqlConnection conn = DBwangba.getConn();
            conn.Open();
            //判断是否链接数据库
            if (conn.State == ConnectionState.Open)
            {
                //查询电脑信息
                string sql = string.Format("select PCID as 电脑编号,PCUse as 是否使用,PCNote as 电脑描述 from PCInfo ");
                SqlDataAdapter adaapt= new SqlDataAdapter(sql, conn);
                DataSet dsss = new DataSet();
                adaapt.Fill(dsss);
                this.dataGridView1.DataSource = dsss.Tables[0].DefaultView;
            }
            else
            {
                MessageBox.Show("连接失败");
            }

        }
        

        private void dgv_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgv_data_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lbl_time.Text = "现在时间:" + DateTime.Now.ToString();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_cz_Click(object sender, EventArgs e)
        {


        }

        private void btn_del_Click(object sender, EventArgs e)
        {
        }

        private void btn_zc_Click(object sender, EventArgs e)
        {
        }

        private void btn_updata_Click(object sender, EventArgs e)
        {
            //跳转修改密码界面
            xiugaimima xiu = new xiugaimima();
            xiu.Show();
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //引用刷新
            InitCardInfo();
        }

        private void btn_chaxun_Click(object sender, EventArgs e)
        {
            //ID .Text   用户账号输入框
           string qe = this.ID.Text;
           //把ID .Text 用户账号输入的值  赋值给   qe
            if(qe == ""){
                //判断输入框是否为空

                MessageBox.Show("请输入要查询的会员ID", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            //链接数据库
             SqlConnection conn = DBwangba.getConn();
            conn.Open();
            //判断是否成功链接
            if (conn.State == ConnectionState.Open)
            {
               chaxun a = new chaxun();//团转窗口致用户信息表
                string sql = string.Format("select cardNumber,cardPassword,cardBalance,transactTime from cardInfo where cardNumber = '{0}'", qe);
                //用条件语句查询   用户信息
                SqlCommand cmd = new SqlCommand(sql, conn);
                //打开连接
                //conn.Open();
                //执行操作
                SqlDataReader reader = cmd.ExecuteReader();
                //如果读取到数据就将其显示出来
                if (reader.Read())
                {
                    a.user.Text = reader[0].ToString();
                    a.mima.Text = reader[1].ToString();
                    a.yue.Text = reader[2].ToString();
                    a.xiaji.Text = reader[3].ToString();
                    a.ShowDialog();
                    //输出查询到的信息
                }else
            {
                MessageBox.Show("没有该会员！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               
                    conn.Close();
                    
                    
                }
            
            
        }

        private void btn_cz_Click_1(object sender, EventArgs e)
        {
            chongzhi cz = new chongzhi();
            cz.Show();
           
            
            
        }

        private void btn_del_Click_1(object sender, EventArgs e)
        {
            huiyuanzhuxiao zx = new huiyuanzhuxiao();
            zx.Show();
 
         
        }

        private void btn_zc_Click_1(object sender, EventArgs e)
        {
            huiyuanzhuce hui = new huiyuanzhuce();
            hui.Show();
        }

        private void btn_updata_Click_1(object sender, EventArgs e)
        {

            xiugaimima xiu = new xiugaimima();
            xiu.Show();
        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 上机ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            huiyuanzhuce hui = new huiyuanzhuce();
            hui.Show();
        }

        private void 下机ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xiugaimima xiu = new xiugaimima();
            xiu.Show();
        }

        private void 余额充值ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chongzhi cz = new chongzhi();
            cz.Show();
        }

        private void 会员注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            huiyuanzhuxiao zx = new huiyuanzhuxiao();
            zx.Show();
        }

        private void 会员上机ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            huiyuanshangji shangji = new huiyuanshangji();
            shangji.Show();
        }

        private void 会员下机ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            huiyuanxiaji xiaji = new huiyuanxiaji();
            xiaji.Show();
        }

        private void 会员换机ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            huiyuanhuanji huanji = new huiyuanhuanji();
            huanji.Show();
        }

        private void 银色清爽ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string skin = "Skins//MacOS.ssk";
            skinEngine1.SkinFile = skin;
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否退出？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            if (dr == DialogResult.Yes)
            {
                   Application.Exit();
            } 
         
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void data_SelectionChanged(object sender, EventArgs e)
        {


        }

        private void 黑色大气ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string skin = "Skins//Calmness.ssk";
            skinEngine1.SkinFile = skin;
        }

        private void 漂亮红色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string skin = "Skins//DiamondBlue.ssk";
            skinEngine1.SkinFile = skin;
        }

        private void 黄色秋凉ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string skin = "Skins//XPOrange.ssk";
            skinEngine1.SkinFile = skin;
        }

        private void 绿色春意ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string skin = "Skins//OneGreen.ssk";
            skinEngine1.SkinFile = skin;
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("自己解决！不提供服务！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void 绿色春意ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string skin = "Skins/OneGreen.ssk";
            skinEngine1.SkinFile = skin;
        }

        private void 营业记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void 系统设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void CardIn()//界面各个对应电脑使用状态 方法
        {
            SqlConnection conn = DBwangba.getConn();
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {

                string sql = string.Format("select *  from  PCInfo ");
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string pcid = reader[0].ToString();
                    string pcuse = reader[1].ToString();

                    switch (pcid)
                    {
                        case "1":
                            if (pcuse == "0")
                            {
                                this.name21.Enabled = true;

                            }
                            else
                            {
                                this.name21.Enabled = false;
                            }

                            break;
                        case "2":
                            if (pcuse == "0")
                            {
                                this.name22.Enabled = true;

                            }
                            else
                            {
                                this.name22.Enabled = false;
                            }

                            break;
                        case "3":
                            if (pcuse == "0")
                            {
                                this.name23.Enabled = true;

                            }
                            else
                            {
                                this.name23.Enabled = false;
                            }

                            break;

                        case "4":
                            if (pcuse == "0")
                            {
                                this.name24.Enabled = true;

                            }
                            else
                            {
                                this.name24.Enabled = false;
                            }

                            break;
                        case "5":
                            if (pcuse == "0")
                            {
                                this.name25.Enabled = true;

                            }
                            else
                            {
                                this.name25.Enabled = false;
                            }

                            break;
                        case "6":
                            if (pcuse == "0")
                            {
                                this.name26.Enabled = true;

                            }
                            else
                            {
                                this.name26.Enabled = false;
                            }

                            break;
                        case "7":
                            if (pcuse == "0")
                            {
                                this.name27.Enabled = true;

                            }
                            else
                            {
                                this.name27.Enabled = false;
                            }

                            break;
                        case "8":
                            if (pcuse == "0")
                            {
                                this.name28.Enabled = true;

                            }
                            else
                            {
                                this.name28.Enabled = false;
                            }

                            break;
                        case "9":
                            if (pcuse == "0")
                            {
                                this.name29.Enabled = true;

                            }
                            else
                            {
                                this.name29.Enabled = false;
                            }

                            break;
                        case "10":
                            if (pcuse == "0")
                            {
                                this.name30.Enabled = true;

                            }
                            else
                            {
                                this.name30.Enabled = false;
                            }

                            break;
                        case "11":
                            if (pcuse == "0")
                            {
                                this.name31.Enabled = true;

                            }
                            else
                            {
                                this.name31.Enabled = false;
                            }

                            break;
                        case "12":
                            if (pcuse == "0")
                            {
                                this.name32.Enabled = true;

                            }
                            else
                            {
                                this.name32.Enabled = false;
                            }

                            break;
                        case "13":
                            if (pcuse == "0")
                            {
                                this.name33.Enabled = true;

                            }
                            else
                            {
                                this.name33.Enabled = false;
                            }

                            break;
                        case "14":
                            if (pcuse == "0")
                            {
                                this.name34.Enabled = true;

                            }
                            else
                            {
                                this.name34.Enabled = false;
                            }

                            break;
                        case "15":
                            if (pcuse == "0")
                            {
                                this.name35.Enabled = true;

                            }
                            else
                            {
                                this.name35.Enabled = false;
                            }

                            break;
                        case "16":
                            if (pcuse == "0")
                            {
                                this.name36.Enabled = true;

                            }
                            else
                            {
                                this.name36.Enabled = false;
                            }

                            break;
                        case "17":
                            if (pcuse == "0")
                            {
                                this.name37.Enabled = true;

                            }
                            else
                            {
                                this.name37.Enabled = false;
                            }

                            break;
                        case "18":
                            if (pcuse == "0")
                            {
                                this.name38.Enabled = true;

                            }
                            else
                            {
                                this.name38.Enabled = false;
                            }

                            break;
                        case "19":
                            if (pcuse == "0")
                            {
                                this.name39.Enabled = true;

                            }
                            else
                            {
                                this.name39.Enabled = false;
                            }

                            break;
                        case "20":
                            if (pcuse == "0")
                            {
                                this.name40.Enabled = true;

                            }
                            else
                            {
                                this.name40.Enabled = false;
                            }

                            break;
                        default:
                            break;
                    }
                   
                }
                reader.Close();
                conn.Close();


            }
        }

      

        private void name1_Click(object sender, EventArgs e)
        {
            huiyuanshangji sj = new huiyuanshangji();
            sj.Show();
        }

        private void name2_Click(object sender, EventArgs e)
        {
            huiyuanshangji sj = new huiyuanshangji();
            sj.Show();
        }

        private void name3_Click(object sender, EventArgs e)
        {
            huiyuanshangji sj = new huiyuanshangji();
            sj.Show();
        }

        private void name4_Click(object sender, EventArgs e)
        {
            huiyuanshangji sj = new huiyuanshangji();
            sj.Show();
        }

        private void name5_Click(object sender, EventArgs e)
        {
            huiyuanshangji sj = new huiyuanshangji();
            sj.Show();
        }

        private void name6_Click(object sender, EventArgs e)
        {
            huiyuanshangji sj = new huiyuanshangji();
            sj.Show();
        }

        private void name7_Click(object sender, EventArgs e)
        {
            huiyuanshangji sj = new huiyuanshangji();
            sj.Show();
        }

        private void name8_Click(object sender, EventArgs e)
        {
            huiyuanshangji sj = new huiyuanshangji();
            sj.Show();
        }

        private void name9_Click(object sender, EventArgs e)
        {
            huiyuanshangji sj = new huiyuanshangji();
            sj.Show();
        }

        private void name10_Click(object sender, EventArgs e)
        {
            huiyuanshangji sj = new huiyuanshangji();
            sj.Show();
        }

        private void name11_Click(object sender, EventArgs e)
        {
            huiyuanshangji sj = new huiyuanshangji();
            sj.Show();
        }

        private void name12_Click(object sender, EventArgs e)
        {
            huiyuanshangji sj = new huiyuanshangji();
            sj.Show();
        }

        private void name13_Click(object sender, EventArgs e)
        {
            huiyuanshangji sj = new huiyuanshangji();
            sj.Show();
        }

        private void name14_Click(object sender, EventArgs e)
        {
            huiyuanshangji sj = new huiyuanshangji();
            sj.Show();
        }

        private void name15_Click(object sender, EventArgs e)
        {
            huiyuanshangji sj = new huiyuanshangji();
            sj.Show();
        }

        private void name16_Click(object sender, EventArgs e)
        {
            huiyuanshangji sj = new huiyuanshangji();
            sj.Show();
        }

        private void name17_Click(object sender, EventArgs e)
        {
            huiyuanshangji sj = new huiyuanshangji();
            sj.Show();
        }

        private void name18_Click(object sender, EventArgs e)
        {
            huiyuanshangji sj = new huiyuanshangji();
            sj.Show();
        }

        private void name19_Click(object sender, EventArgs e)
        {
            huiyuanshangji sj = new huiyuanshangji();
            sj.Show();
        }

        private void name20_Click(object sender, EventArgs e)
        {
            huiyuanshangji sj = new huiyuanshangji();
            sj.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            CardIn();
        }

        private void 刷新ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InitCardInfo();
            ShowRecord();
            CardInfo();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8){
                e.Handled = true;
            }else{
                //MessageBox.Show("请输入数字", "错误", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_huanying_Click(object sender, EventArgs e)
        {

        }
    }
}

