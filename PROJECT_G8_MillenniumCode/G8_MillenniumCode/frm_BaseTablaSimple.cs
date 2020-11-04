using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G8M_AccesoDatos;

namespace G8_MillenniumCode
{
	public partial class frm_BaseTablaSimple : Form
	{
		G8M_AccesoDatos.AccesoDatos ad_lib;

		public frm_BaseTablaSimple()
		{
			InitializeComponent();

		}

		private void frm_BaseTablaSimple_Load(object sender, EventArgs e)
		{
			ad_lib = new AccesoDatos();

			DataSet dtsAgencias = ad_lib.PortarTaula("Agencies");
			dtg_BBDDdata.DataSource = dtsAgencias.Tables[0];

			txt_agencia.DataBindings.Clear();
			txt_agencia.DataBindings.Add("Text", dtsAgencias.Tables[0], txt_agencia.Tag.ToString());
		}

		private void btn_value_Click(object sender, EventArgs e)
		{
			
		}

        private void frm_BaseTablaSimple_Load(object sender, EventArgs e)
        {
			G8M_AccesoDatos.AccesoDatos accesoDatos = new G8M_AccesoDatos.AccesoDatos();

			
        }
    }
}
