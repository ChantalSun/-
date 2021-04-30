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
    public partial class login : Form
    {
       // private string name;
        public login()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            string userName = txtName.Text;//获取用户信息
            string password = txtPwd.Text;//获取密码信息
            string connString = @"Data source=.\sqlexpress; Initial Catalog=ManaSys;Integrated Security=true";//创建连接字符
           SqlConnection conn = new SqlConnection(connString);
           string sql = String.Format("select count(*)from[person]where name='{0}' and password='{1}'", userName, password);//将用户输入的用户信息与存储在数据库中的信息验证对比
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);//执行
                int n = (int)comm.ExecuteScalar();//执行验证后返回值
                Console.WriteLine(n);
                if (n == 1)//验证成功，进入系统
                {
                    this.DialogResult = DialogResult.OK;
                    this.Tag = true;
                    MainFrm mainfrm = new MainFrm();//打开管理系统
                    mainfrm.ShowDialog();
                }
                //验证失败，向用户发送密码或用户错误提示信息
                else
                {
                    MessageBox.Show("您输入的用户名或密码错误！", "登陆失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Tag = false;
                }
            }
            //验证失败，向用户发送程序或数据库端相关错误信息
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Tag = false;
            }
            //关闭数据库
            finally
            {
                conn.Close();
            }    
        }
        //点击取消则清空用户之前输入信息
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPwd.Text = "";
            txtName.Focus();
        }
    }
}
