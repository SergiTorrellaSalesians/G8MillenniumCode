using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G8_RepteEntityFramework
{
	public partial class frm_repte : Form
	{
		NewContactEntities db;
		List<NewContact> nwc;

		public frm_repte()
		{
			InitializeComponent();
		}

		private void CarregaDades()
        {
			db = new NewContactEntities();
			nwc = db.NewContacts.ToList();
			dtg_newcontacts.DataSource = nwc;
			FerBinding();
        }

		private void FerBinding()
        {
				tbx_idcontact.Clear();
				tbx_idcontact.DataBindings.Add("Text", nwc, tbx_idcontact.Tag.ToString());

				tbx_name.Clear();
				tbx_name.DataBindings.Add("Text", nwc, tbx_name.Tag.ToString());

				tbx_birthdate.Clear();
				tbx_birthdate.DataBindings.Add("Text", nwc, tbx_birthdate.Tag.ToString());
		}
        private void frm_repte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'secureCoreDataSet.NewContact' Puede moverla o quitarla según sea necesario.
            this.newContactTableAdapter.Fill(this.secureCoreDataSet.NewContact);
			CarregaDades();

        }
    }
}
