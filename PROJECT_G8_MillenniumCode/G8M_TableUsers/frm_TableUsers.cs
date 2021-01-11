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
        UsersEntities db;
        List<User> userlist;
        bool EsNou = false;

        public frm_tableUsers()
        {
            InitializeComponent();
        }

        private void CarregaDades()
        {
            db = new UsersEntities();
            userlist = db.Users.ToList();
            dtg_BBDDdata.DataSource = userlist;
            FerBinding();
        }

        private void FerBinding()
        {
            tbx_code.Clear();
            tbx_code.DataBindings.Add("Text", userlist, tbx_code.Tag.ToString());

            tbx_login.Clear();
            tbx_login.DataBindings.Add("Text", userlist, tbx_login.Tag.ToString());

            tbx_password.Clear();
            tbx_password.DataBindings.Add("Text", userlist, tbx_password.Tag.ToString());

            tbx_username.Clear();
            tbx_username.DataBindings.Add("Text", userlist, tbx_username.Tag.ToString());

            //hacer el binding de photo igual que el resto de controles
            //IMPORTANTE: en la propiedad Tag del control (dentro del formulario) poner el nombre
            //de la columna a la que quieres hacer el binding!!
        }

        private void frm_tableUsers_Load(object sender, EventArgs e)
        {
            CarregaDades();
        }

        private void TreuBinding()
        {
            tbx_code.Clear();
            tbx_code.Text = "";

            tbx_login.Clear();
            tbx_login.Text = "";

            tbx_password.Clear();
            tbx_password.Text = "";

            tbx_password.Clear();
            tbx_password.Text = "";

            //hacer el clear de photo igual que el resto de controles
        }

        private void btn_actualitzar_Click(object sender, EventArgs e)
        {
            EsNou = true;
            TreuBinding();
        }

        private void btn_value_Click(object sender, EventArgs e)
        {
            if (EsNou)
            {
                User ctcsys = new User
                {
                    //idContact = int.Parse(tbx_idcontact.Text),
                    CodeUser = tbx_code.Text,
                    UserName = tbx_username.Text,
                    Login = tbx_login.Text,
                    Password = tbx_password.Text,
                    //aquí poner la columna Photo = control.funcionquesea

                };
                db.Users.Add(ctcsys);
            }

            db.SaveChanges();
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
        // //       }
        //  }
        //}
    }
}
