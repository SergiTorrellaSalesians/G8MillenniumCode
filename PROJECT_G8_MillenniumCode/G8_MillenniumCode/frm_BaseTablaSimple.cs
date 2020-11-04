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
	public partial class frm_BaseTablaSimple : Form
	{
		public frm_BaseTablaSimple()
		{
			InitializeComponent();
		}

        private void frm_BaseTablaSimple_Load(object sender, EventArgs e)
        {
			G8M_AccesoDatos.AccesoDatos accesoDatos = new G8M_AccesoDatos.AccesoDatos();

			
        }
    }
}
