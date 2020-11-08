using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G8M_AccesoDatos;

namespace G8M_FormBase
{
	public partial class frm_InsideTemplate : Form
	{
		public frm_InsideTemplate()
		{
			InitializeComponent();
		}

		private void frm_InsideTemplate_Load(object sender, EventArgs e)
		{
			/*
				G8M_AccesoDatos.AccesoDatos ad_lib;
				string nomTaula = "Agencies";

				ad_lib = new AccesoDatos();

				DataSet dtsAgencias = ad_lib.PortarTaula(nomTaula);
				dtg_BBDDdata.DataSource = dtsAgencias.Tables[0];

				foreach (Control ctrl in this.Controls) {
					if (ctrl is TextBox)
					{
						ctrl.DataBindings.Clear();
						ctrl.DataBindings.Add("Text", dtsAgencias.Tables[0], ctrl.Tag.ToString());
					}
				}
			*/
		}
	}
}
