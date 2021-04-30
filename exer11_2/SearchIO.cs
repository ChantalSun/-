using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management
{
    public partial class SearchIO : Form
    {
        public SearchIO()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            /*string sql = String.Format("INSERT INTO ManMon(Gpname,Gpnumber,Gpmoney,Sj,Gpdate)VALUES('{0}','{1}','{2}','{3}','{4}')",
                 gname, num, tzmoney, scmoney, dtSotckdate.Value);*/
            string connString = @"Data source=.\SQLEXPRESS;Initial Catalog=ManaSys;Integrated Security=True";//创建连接字符
            using (SqlConnection conn = new SqlConnection(connString))//连接数据库
            {
                conn.Open();//打开数据库
                //SqlCommand comm = new SqlCommand(sql, conn);
                //MessageBox.Show("111");
                string strSQL = "select [dbo].[GetSum]() ";//打开SQL函数GetSum，获取收入金额总额并返回值
                string outSQL = "select [dbo].[GetOutputSum]()";//打开SQL函数GetOutSum，获取支出金额总额并返回值
               // SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(strSQL, conn);//执行strSQL所含sql语句
                SqlCommand cmo = new SqlCommand(outSQL, conn);//执行outSQL所含sql语句
                string A = cmd.ExecuteScalar().ToString();//将收入总额返回值转换为字符
                string B = cmo.ExecuteScalar().ToString();//将支出总额返回值转换为字符并反馈到文本框
                txtSumincome.Text = A;//反馈到文本框
                txtSumOutput.Text = B;
            }
        }
    }
}
