using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PwdMgr.Lib
{
    /// <summary>
    /// 常量
    /// </summary>
    public static class Const
    {
        #region 系统
        public static string AppName = "强密码生成及管理器";
        public static string TempDataExcel = AppDomain.CurrentDomain.BaseDirectory + @"\Files\" + "pwdmgr-[user]-time.xlsx";
        #endregion

    }

    public class ConstExcel
    {
        /// <summary>
        /// 个人数据Excel Sheet固定名称
        /// </summary>
        public enum USheetName
        {
            帐号=0,
            标签=1,
            长文备注=2,
            个人设置=3
        }

    }

}
