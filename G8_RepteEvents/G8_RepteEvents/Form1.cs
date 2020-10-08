using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G8_RepteEvents
{
    public partial class FRM_esdeveniment : Form
    {
        public FRM_esdeveniment()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TXB_codi_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXB_codi_Leave_1(object sender, EventArgs e)
        {
            if (TXB_codi.Text == "MAGA")
            {
                TXB_codiusuari.Text = "Manel Garcia";
                TBX_departament.Text = "Comercial";
                TXB_codiusuari.Enabled = false;
                TBX_departament.Enabled = false;

            }
            else
            {
                TXB_codiusuari.Text = "Usuari desconegut";
                TXB_codiusuari.Enabled = false;
                TBX_departament.Text = string.Empty;
            }
        }
    }
}
