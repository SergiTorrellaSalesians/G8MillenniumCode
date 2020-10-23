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
	public partial class CustomMenuPanel : UserControl
	{
		public CustomMenuPanel()
		{
			InitializeComponent();

			ScrollBar vScrollBar1 = new VScrollBar();
			vScrollBar1.Dock = DockStyle.Right;
			vScrollBar1.Scroll += (sender, e) => { MenuPanel.VerticalScroll.Value = vScrollBar1.Value; };
			MenuPanel.Controls.Add(vScrollBar1);
		}
	}
}
