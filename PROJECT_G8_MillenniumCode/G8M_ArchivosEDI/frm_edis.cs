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
using System.Configuration;
using System.Net;

namespace G8M_ArchivosEDI
{
    public partial class frm_edis : Form
    {
        public string fileContent = "";
        public string filePath = "";
        public string fileName = "";
        public string serverip = "192.168.10.1";
        public string user = "g7";
        public string password = "12345aA";
        public string uploadserverpath = @"/home/g7/";
        public string downloadserverpath = @"/home/g7/";
        public string downloadpath = @"C:/Tractats/";
        

        public frm_edis()
        {
            InitializeComponent();
        }

        private void btn_selectfile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
                openFileDialog.Filter = "Edi files (*.edi)|*.edi" + "|" + "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    fileName = openFileDialog.SafeFileName;
                    Stream fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                    //MessageBox.Show(fileContent, "FILE: " + filePath, MessageBoxButtons.OK);
                    MessageBox.Show(fileName);
                }
            }
        }

        private void btn_uploadfile_Click(object sender, EventArgs e)
        {
            string finalpath = uploadserverpath+fileName;
            MessageBox.Show(finalpath);
            //hacer request y postear
            FtpWebRequest ftpRequest;

            // Crea el objeto de conexión del servidor FTP
            ftpRequest = (FtpWebRequest)WebRequest.Create(string.Format("ftp://{0}/{1}", serverip, finalpath));
            // Asigna las credenciales
            ftpRequest.Credentials = new NetworkCredential(user, password);
            // Asigna las propiedades
            ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;
            ftpRequest.UsePassive = true;
            ftpRequest.UseBinary = true;
            ftpRequest.KeepAlive = false;

            StreamReader sourceStream = new StreamReader(filePath);
            byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
            sourceStream.Close();
            ftpRequest.ContentLength = fileContents.Length;

            Stream requestStream = ftpRequest.GetRequestStream();
            requestStream.Write(fileContents, 0, fileContents.Length);
            requestStream.Close();

            //FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse();
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            string finalpath = downloadserverpath + "RARROrderSample.edi";
            string finaldownloadpath = downloadpath+ "RARROrderSample.edi";
            //MessageBox.Show(finalpath);

            string inputfilepath = @"C:\Tractats\"+ "RARROrderSample.edi";
            string ftphost = serverip;
            string ftpfilepath = downloadserverpath + "RARROrderSample.edi";

            string ftpfullpath = "ftp://" + ftphost + ftpfilepath;

            using (WebClient request = new WebClient())
            {
                request.Credentials = new NetworkCredential(user, password);
                byte[] fileData = request.DownloadData(ftpfullpath);

                using (FileStream file = File.Create(inputfilepath))
                {
                    file.Write(fileData, 0, fileData.Length);
                    file.Close();
                }
                MessageBox.Show("Download Complete");
            }
        }

        private void frm_edis_Load(object sender, EventArgs e)
        {

        }
    }
}
