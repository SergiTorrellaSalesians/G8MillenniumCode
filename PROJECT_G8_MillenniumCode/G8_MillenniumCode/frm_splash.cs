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
        private int timeLeft;
        public frm_splash()
        {
            InitializeComponent();
        }

        private void frm_splash_Load(object sender, EventArgs e)
        {
            tmr_timer_splash.Start();
            timeLeft = 20;
        }

        private void tmr_timer_splash_Tick(object sender, EventArgs e)
        {

            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                progressBar1.Value = progressBar1.Value + 5;
            }
            else
            {
                tmr_timer_splash.Stop();
                //new frm_validaciousuari().Show();
                this.Hide();
            }
        }
    }
}
