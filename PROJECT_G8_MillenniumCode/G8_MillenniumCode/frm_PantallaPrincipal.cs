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

			txt_codeUser.Text = "CODE: " + ad_lib.GetTableData("CodeUser",
				"SELECT * FROM Users WHERE idUser = " + USER_ID).ToString();
			txt_userName.Text = "USER: " + ad_lib.GetTableData("UserName",
				"SELECT * FROM Users WHERE idUser = " + USER_ID).ToString();
			int idRank = Int32.Parse(ad_lib.GetTableData("idUserRank",
				"SELECT * FROM Users WHERE idUser = " + USER_ID).ToString());
			txt_idUserRank.Text = "RANK: " + ad_lib.GetTableData("DescRank",
				"SELECT * FROM UserRanks WHERE idUserRank = " + idRank).ToString();

			createButton("CLEAR", null, null); //

			DataSet dtsTablaDeTablas = ad_lib.PortarTaula("MenuOptions");
			foreach (DataRow dr in dtsTablaDeTablas.Tables[0].Rows) {
				if(Int32.Parse(dr["nivellAcces"].ToString()) >= idRank) {
					createButton(dr["nomOpcio"].ToString().Trim(), dr["ensamblat"].ToString().Trim(), dr["classe"].ToString().Trim());
				}
			}
					
			//createButton("BUSCADOR", "G8M_PantallaBuscador", "frm_buscador");
			//createButton("AGENCIES", "G8M_TableAgencies", "frm_tableAgencies");
			//createButton("USERS", "G8M_TableUsers", "frm_tableUsers");
			//createButton("SPECIES", "G8M_TableSpecies", "frm_tableSpecies");
			//createButton("PLANETS", "G8M_TablePlanets", "frm_tablePlanets");
			//createButton("USER CATEGORIES", "G8M_TableUserCategories", "frm_TableUserCategories");

			MenuPanel.LoadMenu();
		}

		void createButton(string btnName, string lib, string classe){
			Button btn = new Button();
			MenuPanel.LoadTab(btnName, btn);

			void btn_fnc(object sender2, EventArgs e2)
			{
				//Button btn = (Button)sender;
				//MessageBox.Show(btn.Name.ToString());
				this.formShowPanel.Controls.Clear();

				if(classe == null)
					return;

				//Reflection de un formulario (clase) por string
				Assembly ensamblat = Assembly.LoadFrom(lib + ".dll");

				//classe = classe.Substring(classe.IndexOf("."));
				Type tipus = ensamblat.GetType(lib + "." + classe);
				Object dllBD = Activator.CreateInstance(tipus);
				Form reflectedForm = (Form)dllBD;

				//LLamar a modificar el nomTaula del InsideTemplate como parametro al crear el botón
				reflectedForm.TopLevel = false;
				reflectedForm.AutoScroll = true;
				this.formShowPanel.Controls.Add(reflectedForm);
				reflectedForm.FormBorderStyle = FormBorderStyle.None;

				reflectedForm.Show();
			}

			btn.Click += btn_fnc;
		}
	}
}