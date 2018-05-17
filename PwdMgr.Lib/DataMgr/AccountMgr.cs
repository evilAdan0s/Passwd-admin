using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PwdMgr.Lib.DataMgr
{
    public class AccountMgr
    {

        private static AccountMgr _AccountMgr = null;

        public static AccountMgr GetInstall()
        {
            return _AccountMgr ?? new AccountMgr();
        }


        private static DataSet uSelfData = null;
        /// <summary>
        /// 当前用户数据
        /// </summary>
        public static DataSet USelfData
        {
            get
            {

                if (IsRefresh)
                {
                    uSelfData = LoadSelfData();
                    IsRefresh = false;
                }
                else
                {
                    uSelfData = uSelfData ?? LoadSelfData();
                }
                return uSelfData;
            }
        }

        private static bool IsRefresh = false;




        #region 帐号

        public DataTable GetAccount(AccountQueryEntity qInfo)
        {
            var dtAccount = GetData(ConstExcel.USheetName.帐号);

            StringBuilder filter = new StringBuilder("");
            if (qInfo != null)
            {
                if (!string.IsNullOrWhiteSpace(qInfo.Tag))
                {
                    filter.AppendFormat("& 标签 like '%{0}%'  ", qInfo.Tag.Trim());
                }
                if (!string.IsNullOrWhiteSpace(qInfo.Remark))
                {
                    filter.AppendFormat("& 简述 like '%{0}%'  ", qInfo.Remark.Trim());
                }
                if (!string.IsNullOrWhiteSpace(qInfo.AccountName))
                {
                    filter.AppendFormat("& 帐号 like '%{0}%' ", qInfo.AccountName.Trim());
                }
            }

            if (filter.Length > 0)
            {
                var newDt = dtAccount.Clone();
                newDt.Clear();
                var newRows = dtAccount.Select(filter.ToString().Trim('&').Replace("&", " and "));
                foreach (DataRow row in newRows)  // 将查询的结果添加到dt中； 
                {
                    newDt.Rows.Add(row.ItemArray);
                }
                return newDt;
            }
            return dtAccount;
        }

        public void Add(AccountEntity info)
        {
            var account = GetAccount(null);
            info.UpdateTime = DateTime.Now;
            DataRow dr = account.NewRow();
            dr["编号"] = "";
            dr["帐号"] = info.AccountName;
            dr["密文密码"] = info.PwdEncrypt;
            dr["明文密码"] = info.Pwd;
            dr["绑定手机"] = info.BindPhone;
            dr["绑定邮箱"] = info.BindEmail;
            dr["其他绑定信息"] = info.BindOther;
            dr["帐号附属信息"] = info.OtherMessage;
            dr["网站地址"] = info.Domain;
            dr["简述"] = info.Descript;
            dr["标签"] = info.Tag;
            dr["修改时间"] = info.UpdateTime.ToString("yyyy-MM-dd HH:mm:ss");
            AccountInfoSetExcel(dr);
            IsRefresh = true;
        }

        #endregion

        #region Tags
        public List<string> GetTags()
        {
            var dt = GetData(ConstExcel.USheetName.标签);
            List<string> result = new List<string>();
            if (Tool.HasMore(dt))
            {
                foreach (DataRow dr in dt.Rows)
                {
                    result.Add(dr[0].ToString());
                }
            }
            return result;
        }


        #endregion


        public DataTable GetData(ConstExcel.USheetName sheetName)
        {
            return USelfData.Tables[sheetName.ToString()];
        }

        /// <summary>
        /// 加载个人数据
        /// </summary>
        /// <returns></returns>
        private static DataSet LoadSelfData()
        {
            DataSet ds = new DataSet();
            DataTable tb = new DataTable();

            Workbook workbook = new Workbook(Const.TempDataExcel, new LoadOptions() { });

            var sheet = workbook.Worksheets[ConstExcel.USheetName.帐号.ToString()];
            tb = sheet.Cells.ExportDataTableAsString(0, 0, sheet.Cells.MaxDataRow + 1, sheet.Cells.MaxDataColumn + 1);
            tb.TableName = ConstExcel.USheetName.帐号.ToString();
            ds.Tables.Add(tb);

            sheet = workbook.Worksheets[ConstExcel.USheetName.标签.ToString()];
            tb = sheet.Cells.ExportDataTableAsString(0, 0, sheet.Cells.MaxDataRow + 1, sheet.Cells.MaxDataColumn + 1);
            tb.TableName = ConstExcel.USheetName.标签.ToString();
            ds.Tables.Add(tb);

            sheet = workbook.Worksheets[ConstExcel.USheetName.长文备注.ToString()];
            tb = sheet.Cells.ExportDataTableAsString(0, 0, sheet.Cells.MaxDataRow + 1, sheet.Cells.MaxDataColumn + 1);
            tb.TableName = ConstExcel.USheetName.长文备注.ToString();
            ds.Tables.Add(tb);

            sheet = workbook.Worksheets[ConstExcel.USheetName.个人设置.ToString()];
            tb = sheet.Cells.ExportDataTableAsString(0, 0, sheet.Cells.MaxDataRow + 1, sheet.Cells.MaxDataColumn + 1);
            tb.TableName = ConstExcel.USheetName.个人设置.ToString();
            ds.Tables.Add(tb);
            Tool.ConvertFistRowToCols(ds);
            return ds;
        }

        private void AccountInfoSetExcel(DataRow dr)
        {
            Workbook workbook = new Workbook(Const.TempDataExcel, new LoadOptions() { });
            Worksheet sheet = workbook.Worksheets[ConstExcel.USheetName.帐号.ToString()];
            int newTotalRow = sheet.Cells.MaxDataRow + 1;
            sheet.Cells.InsertRow(newTotalRow);
           Cells cells = sheet.Cells;
            Cell cell;
            dr[0] = newTotalRow.ToString(); ;
            for (int i = 0; i <= dr.ItemArray.Count(); i++)
            {
             
                cell = cells.GetCell(newTotalRow, i);
                if (cell != null)
                {
                    cell.Value = dr.ItemArray[i].ToString() ;
                }
            }
            workbook.Save(Const.TempDataExcel);
        }




    }
}
