using System;
using System.IO;
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
		NewContactEntities db1;
		List<NewContact> nwc;

		ContactSystemEntities db2;
		List<ContactSystem> ncent;

		bool EsNou = false;

		public frm_repte()
		{
			InitializeComponent();
		}

		private void CarregaDades()
        {
			db1 = new NewContactEntities();
			nwc = db1.NewContacts.ToList();

			db2 = new ContactSystemEntities();
			ncent = db2.ContactSystems.ToList();

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

		private void TreuBinding()
        {
			tbx_idcontact.Clear();
			tbx_idcontact.Text = "";

			tbx_name.Clear();
			tbx_name.Text = "";

			tbx_birthdate.Clear();
			tbx_birthdate.Text = "";
		}
        private void frm_repte_Load(object sender, EventArgs e)
        {
			


			CarregaDades();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
			string projDir = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
			string edi = System.IO.File.ReadAllText(projDir + "\\DadesClients.edi");

			string[] subsEdi = edi.Split('|');
			int actualContact = 0;
			for (int i = 0; i < subsEdi.Length;)
			{
				if (subsEdi[i].Trim() == "CON") // IDcontact, name, birth
				{
					//MessageBox.Show("CON :" + subsEdi[i + 1] + " # " + subsEdi[i + 2] + " # " + subsEdi[i + 3]); //

					if (EsNou)
					{
						NewContact newcont = new NewContact
						{
							idContact = actualContact,
							Name = subsEdi[i + 1],
							BirthDate = subsEdi[i + 2]
						};
						db1.NewContacts.Add(newcont);
					}
					db1.SaveChanges();

					i += 4;
					actualContact++;
				}
				else if (subsEdi[i].Trim() == "SYS") // IDcontact, description, value
				{
					//MessageBox.Show("SYS :" + subsEdi[i + 1] + " # " + subsEdi[i + 2]); //
					
					if (EsNou)
					{
						ContactSystem ctcsys = new ContactSystem
						{
							IdContact = actualContact,
							Description = subsEdi[i + 1],
							SystemValue = subsEdi[i + 2]
						};
						db2.ContactSystems.Add(ctcsys);
					}
					db2.SaveChanges();

					i += 3;
				}
			}


			
        }
		//
        private void btn_newproduct_Click(object sender, EventArgs e)
        {
			EsNou = true;
			TreuBinding();
        }
    }
}
