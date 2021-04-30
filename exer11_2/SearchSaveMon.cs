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
    public partial class SearchSaveMon : Form
    {
        public SearchSaveMon()
        {
            InitializeComponent();
        }
        private int current = 1;
        string connString = @"Data source=.\SQLEXPRESS;Initial Catalog=ManaSys;Integrated Security=True";
        //活期
        private void ShowCurrent()
        {
            string sql = String.Format("SELECT * FROM SaveMon where Hnumber='{0}'", current);//SQL语句
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);//创建Command对象
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())//读取数据行
                {
                    txtHcoding.Text = Convert.ToString(reader["Hnumber"]);
                    dtHdate.Value = Convert.ToDateTime(reader["Hdate"]);
                    txtHTY.Text = (Convert.ToDouble(reader["Hmoney"])).ToString();
                    txtHL.Text = (Convert.ToDouble(reader["Hbanlance"])).ToString();
                    txtHrate.Text = Convert.ToString(reader["Hrate"]);
                }
                else
                {
                    MessageBox.Show("前面或后面已无数据了", "没有数据", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                reader.Close();
            }
        }
       
            //MessageBox.Show("成功添加活期信息！")

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

       }

       private void button1_Click(object sender, EventArgs e)
       {
           this.Close();
       }
      //定期
        private void ShowCurrent2()
       {
           string sql = String.Format("SELECT * FROM DODMon where Dnumber='{0}'", current);//SQL语句
           using (SqlConnection conn = new SqlConnection(connString))
           {
               conn.Open();
               SqlCommand comm = new SqlCommand(sql, conn);//创建Command对象
               SqlDataReader reader = comm.ExecuteReader();
               if (reader.Read())//读取数据行
               {
                   txtIDCoding.Text = Convert.ToString(reader["Dnumber"]);
                   dtDdate.Value = Convert.ToDateTime(reader["Ddate"]);
                   txtDJ.Text = (Convert.ToDouble(reader["Dmoney"])).ToString();
                   txtDY.Text = (Convert.ToDouble(reader["Dbanlance"])).ToString();
                   //txtHrate.Text = Convert.ToString(reader["Hrate"]);
               }
               else
               {
                   MessageBox.Show("前面或后面已无数据了", "没有数据", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               }
               reader.Close();
           }
       }
        //previous
        private void button4_Click(object sender, EventArgs e)
        {
            current--;
            ShowCurrent2();
        }
        //next
        private void button5_Click(object sender, EventArgs e)
        {
            current++;
            ShowCurrent2();
        }
        //yes
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //delete
        private void button3_Click(object sender, EventArgs e)
        {

        }
       
    }
}
