using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PwdMgr.Lib
{
    public static class Tool
    {
        public static string GetFormName(string mes)
        {
            return $"{Const.AppName}-{mes}";
        }

        public static bool HasMore(DataTable dt)
        {
            return dt != null && dt.Rows.Count > 0;
        }
        public static bool HasMore(DataSet ds)
        {
            return ds != null && ds.Tables.Count > 0;
        }

        public static bool HasMore<T>(IList<T> data)
        {
            return data != null && data.Count > 0;
        }

        public static bool HasMore<T>(List<T> data)
        {
            return data != null && data.Count > 0;
        }

        public static bool HasMore<T>(IEnumerable<T> data)
        {
            return data != null && data.Count() > 0;
        }


        public static DataTable ConvertFistRowToCols(DataTable dt)
        {
            if (Tool.HasMore(dt))
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    dt.Columns[i].ColumnName = dt.Rows[0][i].ToString();
                }
                dt.Rows.RemoveAt(0);
            }
            return dt;
        }

        public static DataSet ConvertFistRowToCols(DataSet ds)
        {
            if (Tool.HasMore(ds))
            {
                foreach (DataTable dt in ds.Tables)
                {
                    ConvertFistRowToCols(dt);
                }
            }
            return ds;
        }



    }
}
