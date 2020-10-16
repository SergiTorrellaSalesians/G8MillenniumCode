using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G8M_FormBase
{
    public partial class frm_Template : Form
    {
		private bool mouseDown;
		private Point lastLocation;

		public string TopBar_Title {
			get { return txt_topbarTitle.Text; }
			set { txt_topbarTitle.Text = value; }
		}


		public frm_Template()
        {
            InitializeComponent();
        }

		private void btn_topbarMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void btn_topbarExit_Click(object sender, EventArgs e)
		{
			//Application.Exit();
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
