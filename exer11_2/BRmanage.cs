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
    public partial class BRmanage : Form
    {
        public BRmanage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int money = Convert.ToInt32(txtBorrow.Text);
            string sql = String.Format("INSERT INTO BRmanage(Borrow,Btime)VALUES('{0}','{1}')",
                money,dtBtime.Value);
            string connString = @"Data source=.\SQLEXPRESS;Initial Catalog=ManaSys;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("成功添加借款信息！", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("未能成功添加借款信息...", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int money = Convert.ToInt32(txtReturn.Text);
            string sql = String.Format("INSERT INTO BRmanage(ReturnMoney,Rtime)VALUES('{0}','{1}')",
                money, dtRtime.Value);
            string connString = @"Data source=.\SQLEXPRESS;Initial Catalog=ManaSys;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("成功添加还款信息！", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("未能成功添加还款信息...", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int money = Convert.ToInt32(txtLoansBox.Text);
            double rate = Convert.ToDouble(LoansRate.Value);
            double Lmoney = money * (rate*0.01);
            txtLoansRMoney.Text = Lmoney.ToString();
            string sql = String.Format("INSERT INTO BRmanage(Loans,LRate,Lmoney)VALUES('{0}','{1}',{2})",
                money, rate,Lmoney);
            string connString = @"Data source=.\SQLEXPRESS;Initial Catalog=ManaSys;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("成功添加贷款信息！", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("未能成功添加贷款信息...", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
