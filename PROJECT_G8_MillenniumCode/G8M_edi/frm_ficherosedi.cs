using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentFTP;
using System.IO;


namespace G8M_PantallaBuscador
{
	public partial class frm_buscador : Form
	{
		/*
 * ESTAS VARIABLES SE CREAN EN EL APP.CONFIG DE ESTA SOLUCIÓN, YA VEREMOS COMO
 *        static string copypath = ConfigurationManager.AppSettings.Get("CopyPath");
	static string localpastepath = ConfigurationManager.AppSettings.Get("LocalPastePath");
	static string serverpastepath = ConfigurationManager.AppSettings.Get("ServerPastePath");
	static string movingpath = ConfigurationManager.AppSettings.Get("MovePath"); 

		static string strUser = ConfigurationManager.AppSettings.Get("ftpUser");
	static string strPassword = ConfigurationManager.AppSettings.Get("ftpPassword");
	static string strServer = ConfigurationManager.AppSettings.Get("ftpServer");
 */

		public frm_buscador()
		{
			InitializeComponent();
		}

        FtpClient ftp = new FtpClient("localhost", new System.Net.NetworkCredential { UserName = "", Password = "" });

        FtpListItem[] listing;

        private async void ProcessEDIFiles()
        {

            foreach (FtpListItem ftpItem in listing)
            {
                if (ftpItem.Name.ToLower() != txbSelectedFile.Text.ToLower())
                {
                    continue;
                }
                else
                {
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        await ftp.DownloadAsync(memoryStream, ftpItem.Name);
                        memoryStream.Position = 0;

                        using (StreamReader streamReader = new StreamReader(memoryStream))
                        {
                            string fileContents = await streamReader.ReadToEndAsync();
                        }
                        await ftp.MoveFileAsync(ftpItem.Name, Path.Combine("Tractats", ftpItem.Name));

                    }
                }


            }
            dtgFiles.Refresh();
        }

        private async void refresh()
        {
            listing = await ftp.GetListingAsync();
            dtgFiles.DataSource = listing;

            txbSelectedFile.DataBindings.Clear();
            txbSelectedFile.DataBindings.Add("Text", listing, "Name");
        }

        private async void InterfazDescarga_Load(object sender, EventArgs e)
        {
            listing = await ftp.GetListingAsync();
            dtgFiles.DataSource = listing;

            txbSelectedFile.DataBindings.Clear();
            txbSelectedFile.DataBindings.Add("Text", listing, "Name");
        }

        private void btn_generaredi_Click(object sender, EventArgs e)
        {
            ProcessEDIFiles();
            MessageBox.Show("File Downloaded");
            /*
        *  //hacer request y postear
               FtpWebRequest ftpRequest;

               // Crea el objeto de conexión del servidor FTP
               ftpRequest = (FtpWebRequest)WebRequest.Create(string.Format("ftp://{0}/{1}", strServer, finalserverpastepath));
               // Asigna las credenciales
               ftpRequest.Credentials = new NetworkCredential(strUser, strPassword);
               // Asigna las propiedades
               ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;
               ftpRequest.UsePassive = true;
               ftpRequest.UseBinary = true;
               ftpRequest.KeepAlive = false;

               StreamReader sourceStream = new StreamReader(finallocalpastepath);
               byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
               sourceStream.Close();
               ftpRequest.ContentLength = fileContents.Length;

               Stream requestStream = ftpRequest.GetRequestStream();
               requestStream.Write(fileContents, 0, fileContents.Length);
               requestStream.Close();

               FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse();
        */
        }
    }
}
