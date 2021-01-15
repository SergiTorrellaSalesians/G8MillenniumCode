using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Drawing.Printing;

namespace G8M_TableUsers
{
    public partial class frm_usercard : Form
    {
        public frm_usercard()
        {
            InitializeComponent();
        }

        private bool mouseDown;
        private Point lastLocation;
        public string usernameCrystalReports;

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            //var cryRpt = new ReportDocument();
            //string route = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
            //cryRpt.Load(route + @"\G8_MillenniumCode\cr_useridentification.rpt");
            //crystalReportViewer1.ReportSource = cryRpt;
            //crystalReportViewer1.Refresh();

            ReportDocument cryRpt = new ReportDocument();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();

            //cryRpt.Load("../Formularios/report.rpt");
            string route = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
            cryRpt.Load(route + @"\G8_MillenniumCode\cr_useridentification.rpt");
            crConnectionInfo.ServerName = "LAPTOP-45H9O8I4\\SQLEXPRESS";
            crConnectionInfo.IntegratedSecurity = true;
            crConnectionInfo.DatabaseName = "SecureCore";
            Tables CrTables = cryRpt.Database.Tables;

            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }

            cryRpt.RecordSelectionFormula = "{Comando.UserName} = " + usernameCrystalReports;
            ////cryRpt.RecordSelectionFormula = "{Command.codeOrder} = 'Ord01'";


            int printerId = 0;
            do printerId++;
            while (PrinterSettings.InstalledPrinters[printerId] != "Microsoft Print to PDF");

            //cryRpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"C:rd.pdf");
        }

        private void btn_topbarMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_topbarExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void topbar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void topbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void topbar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
