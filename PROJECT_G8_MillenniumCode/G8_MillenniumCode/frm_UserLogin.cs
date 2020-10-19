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
		}

		private void tbn_validaciousuari_Click(object sender, EventArgs e)
		{
			G8M_LibreriaUsuario.Metodos val = new Metodos();
			bool validar = val.ValidacioLogin(tbx_username.Text, tbx_password.Text);

			if (!validar)
			{
				MessageBox.Show("Login details are incorrect");
			} else
			{
				MessageBox.Show("Login correct");
			}
		}

		private void frm_UserLogin_Load(object sender, EventArgs e)
		{

		}
	}
}
