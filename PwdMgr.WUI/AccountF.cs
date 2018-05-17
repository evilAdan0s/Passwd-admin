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
    public partial class AccountF : Form
    {
        public AccountF()
        {
            InitializeComponent();
            this.Text = Tool.GetFormName("帐号信息");
        }

        #region 方法
        public AccountEntity GetFormInfo()
        {
            AccountEntity ent = new AccountEntity();
            ent.AccountName = txtAccount.Text.Trim();
            ent.Pwd = txtPwd.Text.Trim();
            ent.BindPhone = txtPhone.Text.Trim();
            ent.BindEmail = txtEmail.Text.Trim();
            ent.BindOther = txtOtherBind.Text.Trim();
            ent.OtherMessage = txtOtherInfo.Text.Trim();
            ent.Domain = txtWebSite.Text.Trim();
            if (cbLTags.CheckedItems != null && cbLTags.CheckedItems.Count > 0)
            {
                foreach (var item in cbLTags.CheckedItems)
                {
                    ent.Tag += item.ToString() + ",";
                }
                ent.Tag = ent.Tag.Trim(',');
            }

            return ent;
        }

        public void SetForm(AccountEntity ent)
        {
            txtAccount.Text = ent.AccountName;
            txtPwd.Text = ent.Pwd;
            txtPhone.Text = ent.BindPhone;
            txtEmail.Text = ent.BindEmail;
            txtOtherBind.Text = ent.BindOther;
            txtOtherInfo.Text = ent.OtherMessage;
            txtWebSite.Text = ent.Domain;
        }
        public void BindTags()
        {
            cbLTags.DataSource = AccountMgr.GetInstall().GetTags();
        }

        #endregion


        #region 事件
        private void AccountF_Load(object sender, EventArgs e)
        {
            BindTags();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AccountMgr.GetInstall().Add(GetFormInfo());
            this.Close();
        }
        #endregion

        
    }
}
