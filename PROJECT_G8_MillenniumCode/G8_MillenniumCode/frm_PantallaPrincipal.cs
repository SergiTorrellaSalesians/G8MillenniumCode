using G8_MillenniumCode.Properties;
using G8M_LibreriaControles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace G8_MillenniumCode
{
	public partial class frm_PantallaPrincipal : G8M_FormBase.frm_Template
	{
		public frm_PantallaPrincipal()
		{
			InitializeComponent();
		}

		private void frm_PantallaPrincipal_Load(object sender, EventArgs e)
		{
			/* //Codigo para mostrar form dentro del panel
			frm_UserLogin insideForm = new frm_UserLogin();
			insideForm.TopLevel = false;
			insideForm.AutoScroll = true;
			this.formShowPanel.Controls.Add(insideForm);
			insideForm.FormBorderStyle = FormBorderStyle.None;
			insideForm.Show();
			*/
			string[] menuTabs = {"users", "roles", "dogs", "cats", "pandas", "sloths"};
			LoadMenuTab(menuTabs);
		}

		private void LoadMenuTab(string[] mTabs)
		{
			for (int i = 0; i < mTabs.Length; i++)
			{
				void btn_msg(object sender, EventArgs e)
				{
					Button btn = (Button)sender;
					MessageBox.Show(btn.Name.ToString());
				}

				Button newButton = new Button();
				{
					newButton.Name = "BTNmenu_" + mTabs[i];
					newButton.Text = mTabs[i].ToUpper();
					newButton.TabStop = false;
					newButton.Dock = DockStyle.Bottom;
					newButton.FlatStyle = FlatStyle.Flat;
					newButton.ForeColor = Color.White;
					newButton.Font = new Font("SimSun-ExtB", 14.25f, FontStyle.Bold);
					newButton.BackColor = Color.FromArgb(255, 25, 25, 25);
					newButton.FlatAppearance.BorderSize = 1;
					newButton.FlatAppearance.BorderColor = Color.Yellow;
					newButton.Size = new System.Drawing.Size(1, 50);
					newButton.Click += btn_msg;
					MenuPanel.Controls.Add(newButton);
				}
			}

			PictureBox newLogo = new PictureBox();
			{
				newLogo.Image = Resources.Reverse_LOGO;
				newLogo.SizeMode = PictureBoxSizeMode.Zoom;
				newLogo.BackColor = Color.FromArgb(255, 25, 25, 25);
				newLogo.Dock = DockStyle.Top;
				newLogo.Size = new System.Drawing.Size(1, 100);
				MenuPanel.Controls.Add(newLogo);
			}
		}
	}
}