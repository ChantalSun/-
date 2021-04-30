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
    public partial class cauclator : Form
    {
        public cauclator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double interests;//利息
            if (cboSave.Text == "活期")
            {
                double Initial = Convert.ToDouble(txtInitial.Text);//初始金额
                //txtDate.ReadOnly = true;
                cboDate.DropDownStyle = ComboBoxStyle.DropDownList;
                txtmoney.ReadOnly = true;
                txtRate.Text = "0.3";
                interests = Initial * 0.3;
                txtInterests.Text = interests.ToString();
                txtSummary.Text = interests.ToString();
            }
            if (cboSave.Text == "整存整取")
            {
                double Initial = Convert.ToDouble(txtInitial.Text);//初始金额
                txtmoney.ReadOnly = true;
                // if (cboDate.Text == "六个月") { }
                switch (cboDate.Text.ToString())
                {
                    case "六个月":
                        txtRate.Text = "1.55";
                        interests = 0.0155 / 2 * Initial;
                        txtInterests.Text = interests.ToString();
                        txtSummary.Text = (interests + Initial).ToString();
                        break;
                    case "一年":
                        txtRate.Text = "1.75";
                        interests = Initial * 1.75;
                        txtInterests.Text = interests.ToString();
                        txtSummary.Text = (interests + Initial).ToString();
                        break;
                    case "三年":
                        txtRate.Text = "2.75";
                        interests = Initial * 0.0275 * 3;
                        txtInterests.Text = interests.ToString();
                        txtSummary.Text = (interests + Initial).ToString();
                        break;
                    case "五年":
                        txtRate.Text = "2.75";
                        interests = Initial * 0.0275 * 5;
                        txtInterests.Text = interests.ToString();
                        txtSummary.Text = (interests + Initial).ToString();
                        break;
                }
            }
                if (cboSave.Text == "教育储蓄")
                {

                    double money = Convert.ToDouble(txtmoney.Text);//月存入金额
                    double Initial = Convert.ToDouble(txtInitial.Text);//初始金额
                    switch (cboDate.Text.ToString())
                    {
                        case "一年":
                            txtRate.Text = "1.75";
                            interests = money * 0.0175;
                            txtInterests.Text = interests.ToString();
                            txtSummary.Text = (interests + Initial).ToString();
                            break;
                        case "三年":
                            txtRate.Text = "2.75";
                            interests = money * 0.0275 * 3;
                            txtInterests.Text = interests.ToString();
                            txtSummary.Text = (interests + Initial).ToString();
                            break;
                        case "六年":
                            txtRate.Text = "2.75";
                            interests = Initial * 0.0275 * 6;
                            txtInterests.Text = interests.ToString();
                            txtSummary.Text = (interests + Initial).ToString();
                            break;
                    }
                }
            }
        }
    }

