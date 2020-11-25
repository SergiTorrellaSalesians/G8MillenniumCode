﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G8M_AccesoDatos;
using G8M_LibreriaControles;

namespace G8M_FormBase
{
	public partial class frm_InsideTemplate : Form
	{
		public string nomTaula;
		public string _nomTaula {
			get { return nomTaula; }
			set { nomTaula = value; }
		}

		public frm_InsideTemplate()
		{
			InitializeComponent();
		}

		private void frm_InsideTemplate_Load(object sender, EventArgs e)
		{
			if(DesignMode)
				return;

			G8M_AccesoDatos.AccesoDatos ad_lib;

			ad_lib = new AccesoDatos();

			//Pasar nom de la taula com parametre al form a l'hora d'afegir els textbox
			DataSet dtsTabla = ad_lib.PortarTaula(nomTaula);
			dtg_BBDDdata.DataSource = dtsTabla.Tables[0];

			foreach (Control ctrl in this.Controls) {
				if (ctrl is TextBox)
				{
					SWTextbox SWctrl = (SWTextbox)ctrl;
					SWctrl.DataBindings.Clear();
					SWctrl.DataBindings.Add("Text", dtsTabla.Tables[0], SWctrl._TableBind);
				}
				else if (ctrl is ComboBox)
				{
					SWComboFK SWctrl = (SWComboFK)ctrl;
					DataSet dtsForeign = ad_lib.PortarTaula(SWctrl._ForeignTable);

					SWctrl.DataBindings.Clear();
					//ADD FOREIGN TABLE OPTIONS
					foreach (DataRow row in dtsForeign.Tables[1].Rows)
					{
						SWctrl.Items.Add(row["idUserRank"].ToString());
						//DataSource?
					}
					//SHOW SELECTED ITEM
					SWctrl.DataBindings.Add("SelectedItem", dtsTabla.Tables[0], SWctrl._TableBind);
				}
			}
		}
	}
}
