﻿using System;
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
        private void FRM_esdeveniment_Load(object sender, EventArgs e)
        {

        }

        private void BTN_calcul_liquidacio_Click(object sender, EventArgs e)
        {
            if (TBX_bestreta.Text != "" && TBX_despesa.Text != ""
            && int.TryParse(TBX_bestreta.Text, out int _) && int.TryParse(TBX_despesa.Text, out int _))
            {
                float num_bestreta = float.Parse(TBX_bestreta.Text);
                float num_despesa = float.Parse(TBX_despesa.Text);
                float liquidacio;


                if (num_bestreta > 120)
                {
                    TBX_bestreta.BackColor = Color.Red;
                    TBX_bestreta.ForeColor = Color.White;
                }
                else
                {
                    TBX_bestreta.BackColor = Color.White;
                    TBX_bestreta.ForeColor = Color.Black;
                }

                liquidacio = num_bestreta - num_despesa;
                TBX_total.Text = liquidacio.ToString();

                if (liquidacio > 200)
                {
                    TBX_total.BackColor = Color.Orange;
                    TBX_total.ForeColor = Color.White;
                }
                else if (liquidacio > 0 && liquidacio < 200)
                {
                    TBX_total.BackColor = Color.Yellow;
                    TBX_total.ForeColor = Color.Black;
                }
                else if (liquidacio < 0)
                {
                    TBX_total.BackColor = Color.Red;
                    TBX_total.ForeColor = Color.White;
                }
            }
            else {
                MessageBox.Show("Omple els valors bestreta i despesa");
            }
        }

        private void TXB_codi_Validating(object sender, CancelEventArgs e)
        {
            if (TXB_codi.Text == "MAGA")
            {
                TXB_codiusuari.Text = "Manel Garcia";
                TBX_departament.Text = "Comercial";
                TXB_codiusuari.Enabled = false;
                TBX_departament.Enabled = false;
                e.Cancel = true;
            }
            else
            {
                TXB_codiusuari.Text = "Usuari desconegut";
                TXB_codiusuari.Enabled = false;
                TBX_departament.Text = string.Empty;
                e.Cancel = false;
            }
        }
    }
}
