using PwdMgr.Lib;
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
    public partial class LoginF : Form
    {

        LoginMgr loginMgr;

        public LoginF()
        {
            InitializeComponent();
            this.Text = Tool.GetFormName("登录");
            loginMgr = new LoginMgr();
        }

        //加载
        private void LoginF_Load(object sender, EventArgs e)
        {
            if(loginMgr.CheckAutoLoginCookie())
            {
                //this.DialogResult = DialogResult.OK;
            }
        }

        //登录
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = DialogResult.OK;

        }


    }
}
