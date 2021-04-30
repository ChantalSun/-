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
    public partial class SaveMon : Form
    {
        public SaveMon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Hnum = Convert.ToInt32(txtHcoding.Text);
            double Hmoney = Convert.ToDouble(txtHL.Text);//活期利息
            double money = Convert.ToDouble(txtHTY.Text);//活期投入金额
            double rate = Convert.ToDouble(txtHrate.Text);//活期利率
            string sql = String.Format("INSERT INTO SaveMon(Hnumber,Hdate,Hmoney,Hbanlance,Hrate)VALUES('{0}','{1}','{2}','{3}','{4}')",
               Hnum, dtHdate.Value, money, Hmoney, rate);
            string connString = @"Data source=.\SQLEXPRESS;Initial Catalog=ManaSys;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("成功添加活期信息！", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("未能成功添加活期信息...", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //MessageBox.Show("成功添加活期信息！");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Dnum = Convert.ToInt32(txtIDCoding.Text);
            string Jmoney = txtDJ.Text.ToString();//定期投入金额
            string Ymoney = txtDY.Text.ToString();//定期余额
            string sql = String.Format("INSERT INTO DODMon(Dnumber,Ddate,Dmoney,Dbalance)VALUES('{0}','{1}','{2}','{3}')",
               Dnum, dtDdate.Value, Jmoney, Ymoney);
            string connString = @"Data source=.\SQLEXPRESS;Initial Catalog=ManaSys;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("成功添加定期信息！", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("未能成功添加定期信息...", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
