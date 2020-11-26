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
					SWctrl.Validated += new System.EventHandler(this.ValidarTextBox);

				}
				else if (ctrl is ComboBox)
				{
					SWComboFK SWctrl = (SWComboFK)ctrl;
					DataSet dtsForeign = new DataSet();
					dtsForeign = ad_lib.PortarTaula(SWctrl._ForeignTable);

					SWctrl.DataBindings.Clear();
					SWctrl.DataSource = dtsForeign.Tables[0];
					SWctrl.DisplayMember = SWctrl._Display_Member;
					SWctrl.ValueMember = SWctrl._Value_Member;

					SWctrl.DataBindings.Add("SelectedValue", dtsTabla.Tables[0], SWctrl._TableBind);
					SWctrl.Validated += new System.EventHandler(this.ValidarComboBox);

				}
			}
		}
		private void ValidarTextBox(object sender, EventArgs e) {
			((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
		}
		private void ValidarComboBox(object sender, EventArgs e) {
			((ComboBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
		}
	}
}
