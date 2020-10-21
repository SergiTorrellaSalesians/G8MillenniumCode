using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace G8_MillenniumCode
{
	public partial class frm_PantallaPrincipal : G8M_FormBase.frm_MenuTemplate
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
		}
	}
}
