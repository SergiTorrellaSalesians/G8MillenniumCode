using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using CrystalDecisions.CrystalReports.Engine;
using System.Diagnostics;

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

                MessageBox.Show("File " + fileName + " uploaded successfully.");
            }
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(@"C:\Users\saman\Documents\GitHub\G8MillenniumCode\PROJECT_G8_MillenniumCode\DLL\G8M_ConsoleApp.exe");

            startInfo.Arguments = "header.h";

            Process.Start(startInfo);

            //The following code downloads the EDI file from FTP Server using windows form
            //Process.Start(startInfo);
            //Process.Start(@"C:\Users\saman\Documents\GitHub\G8MillenniumCode\PROJECT_G8_MillenniumCode\DLL\G8M_ConsoleApp\G8M_ConsoleApp.exe");
            //if (fileName == "")
            //{
            //    MessageBox.Show("No file selected");
            //} else
            //{
            //    string finalpath = downloadserverpath + fileName;
            //    string finaldownloadpath = downloadpath + fileName;
            //    //MessageBox.Show(finalpath);

            //    string inputfilepath = @"C:\Tractats\" + fileName;
            //    string ftphost = serverip;
            //    string ftpfilepath = downloadserverpath + fileName;

            //    string ftpfullpath = "ftp://" + ftphost + ftpfilepath;

            //    try
            //    {
            //        using (WebClient request = new WebClient())
            //        {
            //            request.Credentials = new NetworkCredential(user, password);
            //            byte[] fileData = request.DownloadData(ftpfullpath);

            //            using (FileStream file = File.Create(inputfilepath))
            //            {
            //                file.Write(fileData, 0, fileData.Length);
            //                file.Close();
            //            }
            //            MessageBox.Show("Download Complete");
            //        }
            //    }
            //    catch (WebException ex)
            //    {
            //        //FtpWebResponse response = (FtpWebResponse)ex.Response;
            //        //if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
            //        //{

            //        //}
            //    }
            //}
        }

        private void frm_edis_Load(object sender, EventArgs e)
        {
            //crviewer_planets escondido??
        }

        string lines = "";

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
                        StreamReader EDIreader = new StreamReader(file);
                        int cont = 0;
                        while (lines != null)
                        {
                            lines = EDIreader.ReadLine();
                            cont++;
                        }

                        EDIreader.Close();

                        String currentLine = "";

                        StreamReader saveString = new StreamReader(file);
                        int index = 0;
                        cont--;
                        String[][] edifileMatrix = new string[cont][];

                        while (currentLine != null)
                        {
                            currentLine = saveString.ReadLine();
                            if (currentLine != null)
                            {
                                String[] edi = currentLine.Split('|');
                                String[] ediBits = edi.Skip(0).Take(edi.Length - 1).ToArray();
                                edifileMatrix[index] = ediBits;
                                index++;
                            }
                        }
                        saveString.Close();

                        EDIModelEntities db = new EDIModelEntities();
                        String lastCodeOrder = "";
                        Order lastOrder = new Order();
                        int lastOrdersDetailId = 0;
                        OrdersDetail lastOrdersDetail = new OrdersDetail();
                        String codePriority = "";
                        OrderInfo lastOrderInfo = new OrderInfo();

                        foreach (var array in edifileMatrix)
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
                                    String date = array[1];
                                    DateTime dateTime = DateTime.ParseExact(date, "yyyyMMdd", null);
                                    lastOrder.dateOrder = dateTime;
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
                                case "QTYLIN":
                                    int quantities = Convert.ToInt16(array[2]);
                                    if (array[1] == "61")
                                    {
                                        quantities *= -1;
                                    }
                                    lastOrdersDetail.Quantity = (short)quantities;
                                    break;
                                case "DTMLIN":
                                    String fechaDelivery = array[1];
                                    DateTime dateTimeDelivery = DateTime.ParseExact(fechaDelivery, "yyyyMMdd", null);
                                    lastOrdersDetail.DeliveryDate = dateTimeDelivery;
                                    db.OrdersDetails.Add(lastOrdersDetail);
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
