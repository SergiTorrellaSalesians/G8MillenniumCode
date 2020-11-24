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
    public partial class SWComboFK : ComboBox
    {
        private string TableBind;
        public string _TableBind {
            get { return TableBind; }
            set { TableBind = value; }
        }

        public SWComboFK()
        {
            InitializeComponent();
        }

		private void cbx_combofk_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
