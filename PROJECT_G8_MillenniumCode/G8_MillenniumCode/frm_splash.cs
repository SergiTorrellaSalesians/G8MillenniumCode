using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace G8_MillenniumCode
{
    public partial class frm_splash : Form
    {
        int val = 0;

        public frm_splash()
        {
            InitializeComponent();
        }

        private void frm_splash_Load(object sender, EventArgs e)
        {
            tmr_timer_splash.Start();
        }

        private void tmr_timer_splash_Tick(object sender, EventArgs e)
        {
            val += 3;

            if (val >= 100) {
                val = 100;

                tmr_timer_splash.Stop();
                frm_UserLogin new_frm = new frm_UserLogin();
                new_frm.Show();
                this.Hide();
            }
            progressBar1.Value = val;
        }
    }
}
