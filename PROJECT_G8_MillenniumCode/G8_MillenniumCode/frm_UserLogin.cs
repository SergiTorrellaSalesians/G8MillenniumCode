using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using G8M_LibreriaUsuario;

namespace G8_MillenniumCode
{
	public partial class frm_UserLogin : G8M_FormBase.frm_Template
	{
		int timerCount = 0;
		G8M_LibreriaUsuario.Metodos met;

		public frm_UserLogin()
		{
			InitializeComponent();
		}

		private void frm_UserLogin_Load(object sender, EventArgs e)
		{
			lbl_msg.Text = "";

			G8M_LibreriaUsuario.Metodos met = new Metodos();
			met.ConnectData();
		}

		private void tbn_validaciousuari_Click(object sender, EventArgs e)
		{
			bool validar = met.ValidacioLogin(tbx_username.Text, tbx_password.Text);

			if (!validar)
			{
				lbl_msg.ForeColor = Color.Red;
				lbl_msg.Text = "Login details are incorrect.\nGet out immediately, sith.";
			} else
			{
				tbn_validaciousuari.Enabled = false;
				lbl_msg.ForeColor = Color.Green;
				lbl_msg.Text = "Login details are correct.\nInitializing program...";

				TimerForm.Enabled = true;
			}
		}

		private void tbx_username_TextChanged(object sender, EventArgs e)
		{
			lbl_msg.Text = "";
		}

		private void tbx_password_TextChanged(object sender, EventArgs e)
		{
			lbl_msg.Text = "";
		}

		private void TimerForm_Tick(object sender, EventArgs e)
		{
			timerCount += 1;

			if(timerCount >= 3)
			{
				frm_PantallaPrincipal new_frm = new frm_PantallaPrincipal();
				new_frm.Show();
				this.Hide();
				TimerForm.Enabled = false;
			}
		}
	}
}
