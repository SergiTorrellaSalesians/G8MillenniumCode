using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G8M_FormValidacio
{
    public partial class UserControl1: G8M_FormBase.frm_Template
    {
        private int tempsLeft;
        private Boolean validado = false;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Validated(object sender, EventArgs e)
        {
            if(validado = true) 
            {
                if (Validat=true)
                {
                    label1.Text = "Oleeee";
                    pictureBox1.Image =;
                }
                else
                {
                    label1.Text = "Fuera de aquí o te parto";
                    pictureBox1.Image = ;
                }
            }
        }
        
        private void UserControl1_Load(object sender, EventArgs e)
        {
            tmr_timerControl.Start();
            tempsLeft = 10;

        }

        private void tmr_timerControl_Tick(object sender, EventArgs e)
        {
            if (tempsLeft > 0)
            {
                label1.Text = "Cargando";
                tempsLeft = tempsLeft - 1;
                progressBar1.Value = progressBar1.Value + 5;
            }
            else
            {
                validado = true;
            }
        }

       
    }
}
