using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G8M_LibreriaControles
{
	public partial class MenuCustom : UserControl
	{
		public MenuCustom()
		{
			InitializeComponent();
		}

		public void LoadTab(string tabName, Button btn)
		{
			//Button settings
			btn.Name = "BTNmenu_" + tabName;
			btn.Text = tabName.ToUpper();
			btn.TabStop = false;
			btn.Dock = DockStyle.Top;
			btn.FlatStyle = FlatStyle.Flat;
			btn.ForeColor = Color.White;
			btn.Font = new Font("SimSun-ExtB", 14.25f, FontStyle.Bold);
			btn.BackColor = Color.FromArgb(255, 25, 25, 25);
			btn.FlatAppearance.BorderSize = 1;
			btn.FlatAppearance.BorderColor = Color.Yellow;
			btn.Size = new System.Drawing.Size(1, 50);
			MenuPanel.Controls.Add(btn);
		}

		public void LoadMenu()
		{
			newLogo.SizeMode = PictureBoxSizeMode.Zoom;
			newLogo.BackColor = Color.FromArgb(255, 25, 25, 25);
			newLogo.Dock = DockStyle.Top;
			newLogo.Size = new System.Drawing.Size(1, 100);
			MenuPanel.Controls.Add(newLogo);
		}
	}
}
