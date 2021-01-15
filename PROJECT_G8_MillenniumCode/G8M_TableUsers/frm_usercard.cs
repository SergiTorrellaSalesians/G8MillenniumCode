using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

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

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            var cryRpt = new ReportDocument();
            string route = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
            cryRpt.Load(route + @"\G8_MillenniumCode\cr_useridentification.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
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
