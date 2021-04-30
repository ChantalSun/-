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
    public partial class SearchBRman : Form
    {
        public SearchBRman()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            string connString = @"Data source=.\SQLEXPRESS;Initial Catalog=ManaSys;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                //SqlCommand comm = new SqlCommand(sql, conn);
                //MessageBox.Show("111");
                string strSQL = "select [dbo].[GetLoansSum]() ";
                string returnSQL = "select [dbo].[GetReturnSum]()";
                // SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(strSQL, conn);
                SqlCommand cmo = new SqlCommand(returnSQL, conn);
                string A = cmd.ExecuteScalar().ToString();
                string B = cmo.ExecuteScalar().ToString();
                txtSumLoans.Text = A;
                txtSumReturn.Text = B;
            }
        }
    }
}

