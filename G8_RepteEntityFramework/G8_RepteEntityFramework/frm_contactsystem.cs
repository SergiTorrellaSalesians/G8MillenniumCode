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
    public partial class frm_contactsystem : Form
    {
        ContactSystemEntities db;
        List<ContactSystem> ncent;
        bool EsNou = false;

        public frm_contactsystem()
        {
            InitializeComponent();
        }

        private void CarregaDades()
        {
            db = new ContactSystemEntities();
            ncent = db.ContactSystems.ToList();
            dtg_contactsystem.DataSource = ncent;
            FerBinding();
        }

        private void FerBinding()
        {
            tbx_idcontact.Clear();
            tbx_idcontact.DataBindings.Add("Text", ncent, tbx_idcontact.Tag.ToString());

            tbx_idsystem.Clear();
            tbx_idsystem.DataBindings.Add("Text", ncent, tbx_idsystem.Tag.ToString());

            tbx_description.Clear();
            tbx_description.DataBindings.Add("Text", ncent, tbx_description.Tag.ToString());

            tbx_systemvalue.Clear();
            tbx_systemvalue.DataBindings.Add("Text", ncent, tbx_systemvalue.Tag.ToString());
        }

        private void TreuBinding()
        {
            tbx_idcontact.Clear();
            tbx_idcontact.Text = "";

            tbx_idsystem.Clear();
            tbx_idsystem.Text = "";

            tbx_description.Clear();
            tbx_description.Text = "";

            tbx_systemvalue.Clear();
            tbx_systemvalue.Text = "";
        }
        private void frm_contactsystem_Load(object sender, EventArgs e)
        {
            CarregaDades();
        }

        private void btn_newproduct_Click(object sender, EventArgs e)
        {
            EsNou = true;
            TreuBinding();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (EsNou)
            {
                ContactSystem ctcsys = new ContactSystem
                {
                    //idContact = int.Parse(tbx_idcontact.Text),
                    IdContact = int.Parse(tbx_idcontact.Text),
                    Description = tbx_description.Text,
                    SystemValue = tbx_systemvalue.Text

                };
                db.ContactSystems.Add(ctcsys);
            }

            db.SaveChanges();
        }
    }
}
