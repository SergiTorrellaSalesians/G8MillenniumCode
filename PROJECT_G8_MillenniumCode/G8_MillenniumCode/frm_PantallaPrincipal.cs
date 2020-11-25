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

namespace G8_MillenniumCode
{
	public partial class frm_PantallaPrincipal : G8M_FormBase.frm_Template
	{
		string proyectoLibForms = "G8M_LibreriaFormsTablas";

		public frm_PantallaPrincipal()
		{
			InitializeComponent();
		}

		private void frm_PantallaPrincipal_Load(object sender, EventArgs e)
		{
			createButton("CLEAR", null);
			createButton("AGENCIES", "frm_TablaAgencies");
			createButton("USERS", "frm_TablaUsers");

			MenuPanel.LoadMenu();
		}

		void createButton(string btnName, string classe){
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
				Assembly ensamblat = Assembly.LoadFrom(proyectoLibForms + ".dll");
				Type tipus = ensamblat.GetType(proyectoLibForms + "." + classe);
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