using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G8M_LibreriaControles
{
    public partial class UserControl1 : UserControl
    {
        bool Requerit;
        string FormCS;
        string ClasseCS;
        string Nomid, NomCodi, NomDesc, nomTaula;
        string controlID;

        public class ValidaCodi
        {
            txt_codi.focus;
        }

        public UserControl1()
        {
            InitializeComponent();
            if (Requerit == true & string.IsNullOrWhiteSpace(txt_codi.Text))
            {
                txt_codi.Enabled = false;
            }

            if (txt_codi.Focus && e.Modifiers == Keys.Control)
            {
                FormCS;
                ClasseCS;
            }
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
