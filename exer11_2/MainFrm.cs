using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }
        //private bool isLogined = false;
        private void tsmLogin_Click(object sender, EventArgs e)
        {
            password PSForm = new password();
            PSForm.ShowDialog();
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmNewCourse_Click(object sender, EventArgs e)
        {
               
        }

        private void tsmAbout_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
            //tssMsg.Text = about.Text;
        }

        //收支
        private void tsmAIO_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("111");
            AIOMsgFrm AForm = new AIOMsgFrm();
            AForm.MdiParent = this;
            AForm.Show();
            //tssMsg.Text = AForm.Text;
           // AForm.ShowDialog();
            //tssMsg.Text = "注意，必须先登录才能使用本系统！";
        }
        //借还
        private void BRManage_Click(object sender, EventArgs e)
        {
            BRmanage BForm = new BRmanage();
            BForm.MdiParent = this;
            BForm.Show();

        }
        //存款计算器
        private void cauclator_Click(object sender, EventArgs e)
        {
            cauclator CForm = new cauclator();
            CForm.MdiParent = this;
            CForm.Show();
        }
        //添加理财
        private void tsmNewFund_Click(object sender, EventArgs e)
        {
            Manmon2 MForm = new Manmon2();
            MForm.MdiParent = this;
            MForm.Show();
        }
        //添加储蓄
        private void tsmSM_Click(object sender, EventArgs e)
        {
            SaveMon SForm = new SaveMon();
            SForm.MdiParent = this;
            SForm.Show();
        }
        //查询收支
        private void tsmCIO_Click(object sender, EventArgs e)
        {
            SearchIO IOFrom = new SearchIO();
            IOFrom.ShowDialog();
        }

        private void TsmNewStock_Click(object sender, EventArgs e)
        {
            SearchManmon SMForm = new SearchManmon();
            SMForm.ShowDialog();
        }

        private void tsmDI_Click(object sender, EventArgs e)
        {
            SearchSaveMon SSMForm = new SearchSaveMon();
            SSMForm.ShowDialog();
        }

        private void tsmNewLoans_Click(object sender, EventArgs e)
        {
            SearchBRman SBRForm = new SearchBRman();
            SBRForm.ShowDialog();
        }

        private void 常见问题ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QAFrm qForm = new QAFrm();
            qForm.ShowDialog();
        }
       

    }
}
