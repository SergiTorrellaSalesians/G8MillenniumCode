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
using System.Data.SqlClient;
using System.Globalization;
using System.Configuration;
using G8M_AccesoDatos;

namespace G8_MillenniumCode
{
	public partial class frm_UserLogin : G8M_FormBase.frm_Template
	{
		int timerCount = 0;
		int Login_USER_ID;

		public frm_UserLogin()
		{
			InitializeComponent();
		}

		private void frm_UserLogin_Load(object sender, EventArgs e)
		{
			lbl_msg.Text = "";
		}

		private void tbn_validaciousuari_Click(object sender, EventArgs e)
		{
			bool validar = ValidacioLogin(tbx_username.Text, tbx_password.Text);

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
		private bool ValidacioLogin(String input_username, String input_password)
		{
			bool valid = false;

			G8M_AccesoDatos.AccesoDatos ad_lib;
			ad_lib = new AccesoDatos();
			ad_lib.Connectar();

			String query = "SELECT * FROM Users WHERE Login = '" + input_username + "' and Password = '" + input_password + "'";
			SqlDataAdapter adapterLocal = new SqlDataAdapter(query, ad_lib.conn);

			DataSet dts = new DataSet();
			ad_lib.conn.Open();
			adapterLocal.Fill(dts);
			ad_lib.conn.Close();

			if (dts.Tables[0].Rows.Count > 0) {
				if(dts.Tables[0].Rows.Count > 1)
					MessageBox.Show("CAUTION: User is duplicated");

				valid = true;
				Login_USER_ID = Int32.Parse(dts.Tables[0].Rows[0]["idUser"].ToString());
			}

			return valid;
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
				new_frm.USER_ID = Login_USER_ID;
				new_frm.Show();
				this.Hide();
				TimerForm.Enabled = false;
				timerCount = 0;
			}
		}
	}
}
