using ClientUtilsDll.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PickList
{
    public partial class fUPSShipExecCheck : PPSForm
    {
        public fUPSShipExecCheck()
        {
            InitializeComponent();
        }
        private void fUPSShipExecCheck_Shown(object sender, EventArgs e)
        {
            txtBox.Focus();
        }
        private void btnResend_Click(object sender, EventArgs e)
        {
            fUPSResend f = new fUPSResend();
            f.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sn = txtBox.Text.Trim();
            Search(sn);
        }
        private void txtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                string sn = txtBox.Text.Trim();
                Search(sn);
            }
        }
        private void dtResult_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex != 3)
                return;
            if (e.Value.Equals("1"))
            {
                e.Value = "OK";
                e.CellStyle.BackColor = Color.Green;
            }
            else
            {
                e.Value = "NG";
                e.CellStyle.BackColor = Color.Red;
            }
        }
        private void Search(string sn)
        {
            PickListBll pb1 = new PickListBll();
            sn = pb1.DelPrefixCartonSN(sn);
            var res = pb1.GetWarningSNShipExec(sn);
            if (res.Status)
            {
                var dt = res.Anything as DataTable;
                if (dt.Rows.Count <= 0)
                {
                    ShowMSG("SN/栈板不存在或货代不是UPS", 0);
                }
                else
                {
                    dtResult.DataSource = dt;
                    ShowMSG("OK", -1);
                }
            }
            else
            {
                ShowMSG(res.Message, 0);
            }
        }
    }
}
