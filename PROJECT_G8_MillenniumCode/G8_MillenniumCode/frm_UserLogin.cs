using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G8M_LibreriaUsuario;

namespace G8_MillenniumCode
{
	public partial class frm_UserLogin : G8M_FormBase.frm_Template
	{
		public frm_UserLogin()
		{
			InitializeComponent();
			lbl_msg.Text = "";
		}

		private void tbn_validaciousuari_Click(object sender, EventArgs e)
		{
			G8M_LibreriaUsuario.Metodos val = new Metodos();
			bool validar = val.ValidacioLogin(tbx_username.Text, tbx_password.Text);

			if (!validar)
			{
				lbl_msg.ForeColor = Color.Red;
				lbl_msg.Text = "Login details are incorrect.\nGet out immediately, sith.";
			} else
			{
				lbl_msg.ForeColor = Color.Green;
				lbl_msg.Text = "Login details are correct.\nInitializing program...";
				//Add Countdown (class)
			}
		}

		private void frm_UserLogin_Load(object sender, EventArgs e)
		{

		}

		private void tbx_username_TextChanged(object sender, EventArgs e)
		{
			lbl_msg.Text = "";
		}

		private void tbx_password_TextChanged(object sender, EventArgs e)
		{
			lbl_msg.Text = "";
		}
	}
}
