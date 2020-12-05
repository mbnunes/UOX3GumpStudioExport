using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace UOX3Export
{
    public partial class UOX3ExportForm : Form
    {
        private UOX3Export uphpExport;

        public UOX3ExportForm(UOX3Export UOX3Export)
        {
            this.InitializeComponent();
            this.uphpExport = UOX3Export;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            this.uphpExport.OnExportUltimaPHP(sender, e, (int)numX.Value, (int)numY.Value, chkNoDispose.Checked, chkNoClose.Checked, chkNoMove.Checked, txt_GumpName.Text);
        }
    }
}
