using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PwdMgr.Lib.DataMgr
{
    /// <summary>
    /// 帐号管理
    /// </summary>
    public class AccountEntity:BaseEntity
    {
        public int SysNo { get; set; }

        public string AccountName { get; set; }

        public string PwdEncrypt { get; set; }

        public string Pwd { get; set; }

        public string Domain { get; set; }

        public string BindPhone { get; set; }

        public string BindEmail { get; set; }

        public string BindOther { get; set; }

        public string OtherMessage { get; set; }

        public string Descript { get; set; }

        public string Tag { get; set; }

        public DateTime UpdateTime { get; set; }

    }
}
