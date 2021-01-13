using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace G8_MillenniumCode
{
	public partial class frm_pantallaInicio : Form
	{
		public frm_pantallaInicio()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
            string fileContent = "";
            string filePath = "";

            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.InitialDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
                openFileDialog.Filter = "Edi files (*.edi)|*.edi" +"|"+ "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    filePath = openFileDialog.FileName;
                    Stream fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream)) {
                        fileContent = reader.ReadToEnd();
                    }
                    MessageBox.Show(fileContent, "FILE: " + filePath, MessageBoxButtons.OK);
                }
            }
        }
	}
}
