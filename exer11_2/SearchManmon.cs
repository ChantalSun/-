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
    public partial class SearchManmon : Form
    {
        public SearchManmon()
        {
            InitializeComponent();
            current = 1;
            //ShowCurrent();
        }
        private int current = 1;
        string connString = @"Data source=.\SQLEXPRESS;Initial Catalog=ManaSys;Integrated Security=True";
        private void ShowCurrent()
        {
            string sql = String.Format("SELECT * FROM ManMon where Gpnumber='{0}'",current);//SQL语句
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);//创建Command对象
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())//读取数据行
                {
                    txtSCoding.Text = reader.GetString(1);
                    txtSname.Text = Convert.ToString(reader["Gpname"]);
                    txtSmoney.Text =( Convert.ToDouble(reader["Gpmoney"])).ToString();
                    txtSPmoney.Text = ( Convert.ToDouble(reader["Sj"])).ToString();
                    dtSotckdate.Value =Convert.ToDateTime(reader["Gpdate"]);                        
                }
                else
                {
                    MessageBox.Show("前面或后面已无数据了", "没有数据", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                reader.Close();
            }
        }
        //private string name = "";
        private void ShowCurrent2()
        {
            string sql = String.Format("SELECT * FROM manFund where Jumber='{0}'", current);//SQL语句
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);//创建Command对象
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())//读取数据行
                {
                    txtJMC.Text = reader.GetString(1);
                    txtJZE.Text = Convert.ToString(reader["Jmoney"]);
                    txtJSY.Text =( Convert.ToDecimal(reader["Jsyl"])).ToString();
                    txtJDS.Text = ( Convert.ToDecimal(reader["Jdsl"])).ToString();
                    dtFunddate.Value = Convert.ToDateTime(reader["Jdate"]);
                    txtJFH.Text = (Convert.ToDouble(reader["Jfh"])).ToString();       
                }
                else
                {
                    MessageBox.Show("前面或后面已无数据了", "没有数据", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                reader.Close();
            }
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            current--;
            ShowCurrent();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            current++;
            ShowCurrent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = String.Format("DELETE FROM ManMon where Gpnumber='{0}'", current);
            string connString = @"Data source=.\SQLEXPRESS;Initial Catalog=ManaSys;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                //MessageBox.Show("111");
                int n = comm.ExecuteNonQuery();

                if (n <= 0)
                {
                    MessageBox.Show("删除失败，请与管理员联系！", "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    current--;
                    ShowCurrent();
                }
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPrevious2_Click(object sender, EventArgs e)
        {
            current--;
            ShowCurrent2();
        }
        private void btnNext2_Click(object sender, EventArgs e)
        {
            current++;
            ShowCurrent2();
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            string sql = String.Format("DELETE FROM ManFund where Jumber='{0}'", current);
            string connString = @"Data source=.\SQLEXPRESS;Initial Catalog=ManaSys;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                //MessageBox.Show("111");
                int n = comm.ExecuteNonQuery();

                if (n <= 0)
                {
                    MessageBox.Show("删除失败，请与管理员联系！", "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    current--;
                    ShowCurrent2();
                }
            }
        }

        private void btnYes2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
