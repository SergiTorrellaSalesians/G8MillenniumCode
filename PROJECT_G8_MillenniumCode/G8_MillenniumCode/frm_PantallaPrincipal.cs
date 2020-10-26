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
			LoadMenuTab();
		}

		private void LoadMenuTab(){
			void btn_msg(object sender, EventArgs e)
			{
				Button btn = (Button)sender;
				MessageBox.Show(btn.Name.ToString());
			}
			for (int i = 1; i <= 5; i++)
			{
				Button newButton = new Button();
				{
					newButton.Name = string.Format("Button{0}", i);
					newButton.Text = string.Format("Button {0}", i);
					newButton.Dock = DockStyle.Top;
					newButton.FlatStyle = FlatStyle.Flat;
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
				newLogo.BackColor = Color.Black;
				newLogo.Dock = DockStyle.Top;
				newLogo.Size = new System.Drawing.Size(1, 80);
				MenuPanel.Controls.Add(newLogo);
			}
		}
	}
}