using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G8M_TableUsers
{
    public partial class frm_tableUsers : G8M_FormBase.frm_InsideTemplate
    {
        public frm_tableUsers()
        {
            InitializeComponent();
        }
        //public byte[] imageToByteArray(Image i)
        //{
        //    using (var ms = new MemoryStream())
        //    {
        //        i.Save(ms, i.RawFormat);
        //        return ms.ToArray();
        //    }
        //}

        //public Image byteArrayToImage(byte[] array)
        //{

        //    using (var ms = new MemoryStream(array))
        //    {
        //        return Image.FromStream(ms);
        //    }
        //}

        //private void label5_Click(object sender, EventArgs e)
        //{

        //}
        //private void OpenImage(bool nuevo)
        //{
        //    OpenFileDialog ofd = new OpenFileDialog();

        //    if (ofd.ShowDialog() == DialogResult.OK)
        //    {
        //        Image img = new Bitmap(ofd.FileName);
        //        byte[] imgBytes = imageToByteArray(img);

        //        if (nuevo) row["photo"] = imgBytes;
        //        else infotabla.Rows[dtgUsers.CurrentCell.RowIndex]["photo"] = imgBytes;

        //        foreach (Control ctr in Controls)
        //        {
        //            if (ctr.GetType() == typeof(PictureBox))
        //            {
        //                ctr.BackgroundImage = img;
        //            }
        //        }
        //  }
        //}
    }
}
