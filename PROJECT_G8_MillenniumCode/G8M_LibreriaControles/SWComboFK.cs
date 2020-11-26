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
        private string ForeignTable;
        public string _ForeignTable {   
            get { return ForeignTable; }
            set { ForeignTable = value; }
        }

        private string Display_Member;
        public string _Display_Member
        {
            get { return Display_Member; }
            set { Display_Member = value; }
        }

        private string Value_Member;
        public string _Value_Member
        {
            get { return Value_Member; }
            set { Value_Member = value; }
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
