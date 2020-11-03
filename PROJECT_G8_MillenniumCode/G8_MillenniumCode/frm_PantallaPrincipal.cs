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
			frm_AccesoBBDD frm1 = new frm_AccesoBBDD();
			createButton("CLEAR", null);
			createButton("ACCESO", frm1);
			createButton("EXAMPLE 1", frm1);
			createButton("EXAMPLE 2", frm1);
			createButton("EXAMPLE 3", frm1);
			createButton("EXAMPLE 4", frm1);
			createButton("EXAMPLE 5", frm1);
			createButton("EXAMPLE 6", frm1);
			createButton("EXAMPLE 7", frm1);
			createButton("EXAMPLE 8", frm1);

			//frm_UserLogin frm2 = new frm_UserLogin();
			//createButton("USER", frm2);

			//frm_splash frm3 = new frm_splash();
			//createButton("SPLASH", frm3);

			MenuPanel.LoadMenu();
		}

		void createButton(string btnName, Form frm){
			Button btn = new Button();
			MenuPanel.LoadTab(btnName, btn);

			void btn_fnc(object sender2, EventArgs e2)
			{
				//Button btn = (Button)sender;
				//MessageBox.Show(btn.Name.ToString());
				this.formShowPanel.Controls.Clear();
				if(frm == null)
					return;

				frm.TopLevel = false;
				frm.AutoScroll = true;
				this.formShowPanel.Controls.Add(frm);
				frm.FormBorderStyle = FormBorderStyle.None;
				frm.Show();
			}
			btn.Click += btn_fnc;
		}
	}
}