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
    public partial class Manmon2 : Form
    {
        public Manmon2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string gname = txtSname.Text.ToString();
                 //Convert.ToInt32(txtSName.Text);//股票名称
            string num = txtSCoding.Text.ToString();
                 // Convert.ToInt32(txtSCoding.Text);
             double tzmoney = Convert.ToDouble(txtSmoney.Text);//股票投资金额数
             double scmoney = Convert.ToDouble(txtSPmoney.Text);//该股票每股市场价格
             string sql = String.Format("INSERT INTO ManMon(Gpname,Gpnumber,Gpmoney,Sj,Gpdate)VALUES('{0}','{1}','{2}','{3}','{4}')",
                 gname,num,tzmoney, scmoney, dtSotckdate.Value);
             string connString = @"Data source=.\SQLEXPRESS;Initial Catalog=ManaSys;Integrated Security=True";
             using (SqlConnection conn = new SqlConnection(connString))
             {
                 conn.Open();
                 SqlCommand comm = new SqlCommand(sql,conn);
                 //MessageBox.Show("111");
                 int n = comm.ExecuteNonQuery();
                 
                 if (n > 0)
                 {
                     MessageBox.Show("成功添加股票信息！", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
                 else
                     MessageBox.Show("未能成功添加股票信息...", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
         }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int jcoding = Convert.ToInt32(txtJcoding.Text);
            String jname = txtJMC.Text.ToString();//基金名称名称
            double zemoney = Convert.ToDouble(txtJZE.Text);//基金总金额

            //double symoney = txtJSY.Text.ToDouble();
            double symoney = Convert.ToDouble(txtJSY.Text);//基金收益率
            double dsmoney = Convert.ToDouble(txtJDS.Text);//txtJDS.Text.ToDouble();//基金跌损率
            double fhmoney = Convert.ToDouble(txtJFH.Text);//分红
            string sql = String.Format("INSERT INTO manFund(Jumber,Jname,Jmoney,Jsyl,Jdsl,Jdate,Jfh)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                jcoding,jname, zemoney, symoney, dsmoney, dtFunddate.Value, fhmoney);
            string connString = @"Data source=.\SQLEXPRESS;Initial Catalog=ManaSys;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("成功添加股票信息！", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("未能成功添加股票信息...", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //MessageBox.Show("成功添加活期信息！");
        }
    }
}
