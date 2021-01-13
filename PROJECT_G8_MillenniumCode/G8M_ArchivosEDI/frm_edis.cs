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
using CrystalDecisions.CrystalReports.Engine;

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
                    MessageBox.Show("File "+fileName+" on hold.");
                }
            }
        }

        private void btn_uploadfile_Click(object sender, EventArgs e)
        {
            if (fileName == "")
            {
                MessageBox.Show("No file selected");
            } else
            {
                string finalpath = uploadserverpath + fileName;
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
                MessageBox.Show("File " + fileName + " uploaded successfully.");
            }
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            if (fileName == "")
            {
                MessageBox.Show("No file selected");
            } else
            {
                string finalpath = downloadserverpath + fileName;
                string finaldownloadpath = downloadpath + fileName;
                //MessageBox.Show(finalpath);

                string inputfilepath = @"C:\Tractats\" + fileName;
                string ftphost = serverip;
                string ftpfilepath = downloadserverpath + fileName;

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
                    MessageBox.Show("Download Completed");
                }
            }
        }

        private void frm_edis_Load(object sender, EventArgs e)
        {
            //crviewer_planets escondido??
        }

        //OpenFileDialog openFile = new OpenFileDialog();
        string line = "";

        private void btn_crystalreports_Click(object sender, EventArgs e)
        {
            //crviewer_planets show

            if (fileName == "")
            {
                MessageBox.Show("No file selected");
            } else
            {
                string EDIFilepath = downloadpath + fileName;
                    //"RARROrderSample.edi";

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

                        String file = openFileDialog.FileName;
                        StreamReader srContar = new StreamReader(file);
                        int contador = 0;
                        while (line != null)
                        {
                            line = srContar.ReadLine();
                            contador++;
                        }

                        srContar.Close();

                        //Segunda lectura para inicializar el array
                        String line2 = "";

                        StreamReader srGuardar = new StreamReader(file);
                        int indexMatrix = 0;
                        contador--;
                        String[][] matrix = new string[contador][];

                        while (line2 != null)
                        {
                            line2 = srGuardar.ReadLine();
                            if (line2 != null)
                            {
                                String[] arrayCompleto = line2.Split('|');
                                //Eliminar el ultimo elemento, que es un string vacio
                                String[] segmentValue = arrayCompleto.Skip(0).Take(arrayCompleto.Length - 1).ToArray();
                                matrix[indexMatrix] = segmentValue;
                                indexMatrix++;
                            }
                        }
                        srGuardar.Close();

                        EDIModelEntities db = new EDIModelEntities();
                        String lastCodeOrder = "";
                        Order lastOrder = new Order();
                        int lastOrdersDetailId = 0;
                        OrdersDetail lastOrdersDetail = new OrdersDetail();
                        String codePriority = "";
                        OrderInfo lastOrderInfo = new OrderInfo();

                        foreach (var array in matrix)
                        {
                            switch (array[0])
                            {
                                case "ORD":
                                    codePriority = array[2];
                                    Priority priority = db.Priorities.FirstOrDefault(p => p.CodePriority == codePriority);
                                    Order order = new Order
                                    {
                                        codeOrder = array[1],
                                        Priority = priority
                                    };
                                    lastCodeOrder = array[1];
                                    lastOrder = order;

                                    break;
                                case "DTM":
                                    String fecha = array[1];
                                    DateTime dateTime = DateTime.ParseExact(fecha, "yyyyMMdd", null);
                                    lastOrder.dateOrder = dateTime;
                                    break;
                                case "NADMS":
                                    String codeAgency = array[2];
                                    Agency agency = db.Agencies.FirstOrDefault(a => a.CodeAgency == codeAgency);
                                    String codeOperationalArea = array[1];
                                    OperationalArea operationalArea = db.OperationalAreas.FirstOrDefault(o => o.CodeOperationalArea == codeOperationalArea);
                                    OrderInfo orderInfo = new OrderInfo
                                    {
                                        Agency = agency,
                                        OperationalArea = operationalArea
                                    };
                                    lastOrderInfo = orderInfo;
                                    break;
                                case "NADMR":
                                    String codeFactory = array[1];
                                    Factory factory = db.Factories.FirstOrDefault(f => f.codeFactory == codeFactory);
                                    lastOrder.Factory = factory;

                                    db.Orders.Add(lastOrder);

                                    lastOrderInfo.idOrder = lastOrder.idOrder;

                                    db.OrderInfoes.Add(lastOrderInfo);

                                    db.SaveChanges();
                                    break;
                                case "LIN":
                                    lastOrder = db.Orders.FirstOrDefault(o => o.codeOrder == lastCodeOrder);
                                    String codePlanet = array[1];
                                    Planet planet = db.Planets.FirstOrDefault(p => p.CodePlanet == codePlanet);
                                    String codeReference = array[2];
                                    Reference reference = db.References.FirstOrDefault(r => r.codeReference == codeReference);
                                    OrdersDetail ordersDetail = new OrdersDetail
                                    {
                                        Order = lastOrder,
                                        Planet = planet,
                                        Reference = reference
                                    };

                                    lastOrdersDetail = ordersDetail;
                                    lastOrdersDetailId = ordersDetail.idOrderDetail;

                                    break;
                                case "QTYLIN":
                                    int cantidad = Convert.ToInt16(array[2]);
                                    if (array[1] == "61")
                                    {
                                        cantidad *= -1;
                                    }
                                    lastOrdersDetail.Quantity = (short)cantidad;
                                    break;
                                case "DTMLIN":
                                    String fechaDelivery = array[1];
                                    DateTime dateTimeDelivery = DateTime.ParseExact(fechaDelivery, "yyyyMMdd", null);
                                    lastOrdersDetail.DeliveryDate = dateTimeDelivery;
                                    db.OrdersDetails.Add(lastOrdersDetail);
                                    db.SaveChanges();
                                    break;
                                default:
                                    Console.WriteLine("Default case");
                                    break;
                            }
                        }

                        MessageBox.Show("EDI File Processed Sucessfully");
                    }
                }
            }
        }

        private void btn_showcrystalreports_Click(object sender, EventArgs e)
        {
            if (fileName == "")
            {
                MessageBox.Show("No file selected");
            } else {
                var cryRpt = new ReportDocument();
                cryRpt.Load(@"C:\Users\saman\Documents\GitHub\G8MillenniumCode\PROJECT_G8_MillenniumCode\G8M_ArchivosEDI\EDI_to_crystalreports.rpt");
                crviewer_planets.ReportSource = cryRpt;
                crviewer_planets.Refresh();
            }
        }
    }
}
