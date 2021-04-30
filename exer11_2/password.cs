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
    public partial class password : Form
    {
        public password()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            //string user = textBox1.Text;
            string cpwd = txtpsd.Text;
            string mpwd = txtmpsd.Text;
            if (cpwd == mpwd) {
                string connString = @"Data source=.\SQLEXPRESS;Initial Catalog=ManaSys;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                   // conn.Open();
                    //执行con对象的函数，返回一个SqlCommand类型的对象
                    SqlCommand cmd = conn.CreateCommand();
                    //拼写语句
                    cmd.CommandText = "update person set password=" + cpwd;
                    
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("修改成功");
                    }
                    conn.Close();
                }
            }
            else
            {
                label1.Visible = true;
                MessageBox.Show("修改失败");
            }
        }
    }
}
