using PwdMgr.Lib;
using PwdMgr.Lib.DataMgr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PwdMgr.WUI
{
    public partial class MainF : Form
    {
        public MainF()
        {
            InitializeComponent();
            this.Text = Tool.GetFormName("主窗体");

        }

        #region 方法
        private void BindData()
        {
            BindAccountInfo();
            BindTags();
        }

        public void BindTags()
        {
            cbLTags.DataSource = AccountMgr.GetInstall().GetTags();
        }

        public void BindAccountInfo()
        {
            
            dgvData.DataSource = AccountMgr.GetInstall().GetAccount(GetQueryInfo());
        }

        public AccountQueryEntity GetQueryInfo()
        {
            AccountQueryEntity qEnt = new AccountQueryEntity();
            if (cbLTags.CheckedItems != null && cbLTags.CheckedItems.Count > 0)
            {
                foreach (var item in cbLTags.CheckedItems)
                {
                    qEnt.Tag += item.ToString() + ",";
                }
                qEnt.Tag = qEnt.Tag.Trim(',');
            }
            if (!string.IsNullOrWhiteSpace(txtRemark.Text))
            {
                qEnt.Remark = txtRemark.Text.Trim();
            }
            if (!string.IsNullOrWhiteSpace(txtAccount.Text))
            {
                qEnt.AccountName = txtAccount.Text.Trim();
            }
            return qEnt;
        }

        #endregion


        #region 事件

        private void MainF_Load(object sender, EventArgs e)
        {
            BindData();
        }


        private void btnSelect_Click(object sender, EventArgs e)
        {
            BindAccountInfo();
        }



        #endregion

        private void 新增帐号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AccountF().Show();
        }

        private void 密码生成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Passcreate().Show();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("比赛作品...");
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
