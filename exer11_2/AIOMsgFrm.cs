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
    public partial class AIOMsgFrm : Form
    {
        /*string courseName;
        string courseClass;
        string required;
        int credit;
        int prelectionCredit;
        int experinmentCredit;*/
        public AIOMsgFrm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void CourseMsgFrm_Load(object sender, EventArgs e)
        {

        }


       

        private void btnIYes_Click(object sender, EventArgs e)
        {
            string incomeclass =cboInput.SelectedItem.ToString();
            string incomeusers = txtUser.Text.ToString();
            double money = Convert.ToDouble(txtmoney.Text);//创建连接字符
            string sql = String.Format("INSERT INTO Income(Incomedate,Incomeclass,IncomeUserCard,Incomemoney)VALUES('{0}','{1}','{2}','{3}')",
                dtIncomedate.Value, incomeclass, incomeusers, money);//创建插入语句
            string connString = @"Data source=.\SQLEXPRESS;Initial Catalog=ManaSys;Integrated Security=True";//连接数据库
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();//打开数据库
                SqlCommand comm = new SqlCommand(sql, conn);//执行
                int n = comm.ExecuteNonQuery();//获取反馈值
                if (n > 0)//成功执行
                {
                    MessageBox.Show("成功添加收入信息！", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else//未能成功执行
                    MessageBox.Show("未能成功添加收入信息...", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //MessageBox.Show("成功添加收入信息！");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string outcomeclass = cbooutcome.SelectedItem.ToString();
            string outcomeusers = usertxtbox.Text.ToString();
            int money = Convert.ToInt32(txtMoneyBox.Text);
            string sql = String.Format("INSERT INTO Outcome(Outcomedate,Outcomeclass,OutcomeUserCard,Outcomemoney)VALUES('{0}','{1}','{2}','{3}')",
                dtoutcomedate.Value, outcomeclass, outcomeusers, money);
            string connString = @"Data source=.\SQLEXPRESS;Initial Catalog=ManaSys;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("成功添加支出信息！", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("未能成功添加支出信息...", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           // MessageBox.Show("成功添加支出信息！");
        }
    }
}
