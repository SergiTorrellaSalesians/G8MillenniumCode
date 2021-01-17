using G8_MillenniumCode.Properties;
using G8M_LibreriaControles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using G8M_AccesoDatos;

namespace G8_MillenniumCode
{
	public partial class frm_PantallaPrincipal : G8M_FormBase.frm_Template
	{
		public int USER_ID;
		G8M_AccesoDatos.AccesoDatos ad_lib;

		public frm_PantallaPrincipal()
		{
			InitializeComponent();
		}

		private void frm_PantallaPrincipal_Load(object sender, EventArgs e)
		{
			ad_lib = new AccesoDatos();

			string userLabel = "USER: " + ad_lib.GetTableData("UserName",
				"SELECT * FROM Users WHERE idUser = " + USER_ID).ToString();
			int idRank = Int32.Parse(ad_lib.GetTableData("idUserRank",
				"SELECT * FROM Users WHERE idUser = " + USER_ID).ToString());
			userLabel += "   " + "RANK: " + ad_lib.GetTableData("DescRank",
				"SELECT * FROM UserRanks WHERE idUserRank = " + idRank).ToString();
			txt_topuser.Text = userLabel;

			DataSet dtsTablaDeTablas = ad_lib.PortarTaula("MenuOptions");
			foreach (DataRow dr in dtsTablaDeTablas.Tables[0].Rows) {
				if(Int32.Parse(dr["nivellAcces"].ToString()) >= idRank) {
					createButton(dr["nomOpcio"].ToString().Trim(), dr["ensamblat"].ToString().Trim(), dr["classe"].ToString().Trim());
				}
			}
            createButton("MAIN", null, "frm_pantallaInicio");
            //createButton("MAIN", "./", "frm_pantallaInicio");
            Form newForm = new frm_pantallaInicio();
			newForm.TopLevel = false;
			newForm.AutoScroll = true;
			this.formShowPanel.Controls.Add(newForm);
			newForm.FormBorderStyle = FormBorderStyle.None;
			newForm.Show();

			MenuPanel.LoadMenu();
		}

		void createButton(string btnName, string lib, string classe){
			Button btn = new Button();
			MenuPanel.LoadTab(btnName, btn);

			void btn_fnc(object sender2, EventArgs e2)
			{
				this.formShowPanel.Controls.Clear();

				Form newForm;
				if (lib != null){
					//Reflection de un formulario (clase) por string
					Assembly ensamblat = Assembly.LoadFrom(lib + ".dll");

					//classe = classe.Substring(classe.IndexOf("."));
					Type tipus = ensamblat.GetType(lib + "." + classe);
					Object dllBD = Activator.CreateInstance(tipus);
					newForm = (Form)dllBD;
				}else{
					newForm = new frm_pantallaInicio();
				}
				//LLamar a modificar el nomTaula del InsideTemplate como parametro al crear el botón
				newForm.TopLevel = false;
				newForm.AutoScroll = true;
				this.formShowPanel.Controls.Add(newForm);
				newForm.FormBorderStyle = FormBorderStyle.None;

				newForm.Show();
			}

			btn.Click += btn_fnc;
		}

		private void txt_topuser_Click(object sender, EventArgs e){userClick();}private void pic_user_Click(object sender, EventArgs e){userClick();}
		void userClick(){
			MessageBox.Show("Mostra usuari");
		}
	}
}