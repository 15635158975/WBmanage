using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WB
{

    class DBwangba
    {
        /// <summary>
        /// 数据库连接的数据库操作  增删改操作 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        /// 


        
        public static int BaseExec(string sql)
        {
            int rz = 0;
            SqlConnection conn = new SqlConnection();
            
            conn.ConnectionString = "server=.;database=NetBarDB;uid=sa;pwd=123456";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql,conn);
            rz = cmd.ExecuteNonQuery();
            conn.Close();
            return rz;
        }

        /// <summary>
        /// 用户获取数据库连接
        /// </summary>
        /// <returns></returns>
        public static SqlConnection getConn()
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "server=.;database=NetBarDB;uid=sa;pwd=123456";
            return conn;
        }

    }
}
