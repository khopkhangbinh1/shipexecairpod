using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRReport.CRfrom
{
    public partial class ConsolCIAMRLayoutChileForm
    {
        public string diskCompletePath = ""; //全局变量返回pdf路径
        public ConsolCIAMRLayoutChileForm(string acDn, bool print)
        {
            Initialize(acDn, print);
        }

        private void Initialize(string shipID, bool print)
        {
            //初始化 DataSet
            DataSet ds = new DataSet();

            //AmrDsShippingLabel
            string headerSql = @"SELECT * FROM WMUSER.AC_AMR_DS_CCI_CHI_HEADER@dgedi T0 WHERE T0.SHIPMENT_ID = '" + shipID + "'";

            string lineSql = @"SELECT * FROM WMUSER.AC_AMR_DS_CCI_CHI_LINE@dgedi T0 WHERE T0.SHIPMENT_ID = '" + shipID + "'";
            ds.Tables.Add(Util.getDataTaleC(headerSql, "Header"));
            ds.Tables.Add(Util.getDataTaleC(lineSql, "Line"));
            string filePath = "";
            filePath = Application.StartupPath + "\\PDF\\" + shipID + "CCIChile.pdf";
            diskCompletePath = filePath; //全局变量返回pdf路径
            if (print)
            {
                Util.CreateDataTable(Constant.ConsolAMRMexico_URL, ds);
            }
            else
            {
                Util.exportCRPDFAndSendEmail(Constant.CCILayoutChile_URL, ds, filePath);
            }


        }
    }


}
