using System;
using System.IO;
using System.Data;
using System.Configuration;
using System.Net;
using System.Text;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
namespace G8M_ConsoleApp
{
    class Program
    {
        static string serverpath = ConfigurationManager.AppSettings.Get("ServerPath");
        static string localpath = ConfigurationManager.AppSettings.Get("MovePath");

        static string strUser = ConfigurationManager.AppSettings.Get("ftpUser");
        static string strPassword = ConfigurationManager.AppSettings.Get("ftpPassword");
        static string strServer = ConfigurationManager.AppSettings.Get("ftpServer");
        static void Main(string[] args)
        {
            string command;
            bool quitNow = false;
            string finalpath = serverpath + "RARROrderSample.edi";
            string downloadpath = localpath + "RARROrderSample.edi";

            Console.WriteLine("...\n");
            Console.WriteLine("...\n");
            Console.WriteLine("...\n");
            Console.WriteLine("...\n");
            Console.WriteLine("...\n");
            Console.WriteLine("...\n");

            while (!quitNow)
            {
                command = Console.ReadLine();
                switch (command)
                {
                    case "/help":
                        Console.WriteLine("This should be help.\n");
                        break;

                    case "/search":
                        Console.WriteLine("Searching...");
                        // Get the object used to communicate with the server.
                        FtpWebRequest searchrequest = (FtpWebRequest)WebRequest.Create(string.Format("ftp://{0}/{1}", strServer, finalpath));
                        searchrequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

                        // This example assumes the FTP site uses anonymous logon.
                        searchrequest.Credentials = new NetworkCredential(strUser, strPassword);

                        FtpWebResponse response = (FtpWebResponse)searchrequest.GetResponse();

                        Stream responseStream = response.GetResponseStream();
                        StreamReader reader = new StreamReader(responseStream);
                        Console.WriteLine(reader.ReadToEnd());

                        reader.Close();
                        response.Close();
                        break;

                    case "/download":

                        FtpWebRequest downloadrequest = (FtpWebRequest)WebRequest.Create(string.Format("ftp://{0}/{1}", strServer, finalpath));

                        //Set proxy to null. Under current configuration if this option is not set then the proxy that is used will get an html response from the web content gateway (firewall monitoring system)
                        downloadrequest.Proxy = null;

                        downloadrequest.UsePassive = true;
                        downloadrequest.UseBinary = true;

                        downloadrequest.Credentials = new NetworkCredential(strUser, strPassword);

                        int bytesRead = 0;
                        byte[] buffer = new byte[2048];

                        downloadrequest.Method = WebRequestMethods.Ftp.DownloadFile;

                        Stream downloadreader = downloadrequest.GetResponse().GetResponseStream();
                        FileStream fileStream = new FileStream(downloadpath, FileMode.Create);

                        while (true)
                        {
                            bytesRead = downloadreader.Read(buffer, 0, buffer.Length);

                            if (bytesRead == 0)
                                break;

                            fileStream.Write(buffer, 0, bytesRead);
                        }
                        fileStream.Close();
                        Console.WriteLine("File downloaded.");
                        break;

                    case "/quit":
                        quitNow = true;
                        break;

                    default:
                        Console.WriteLine("Unknown Command " + command);
                        break;
                }
            }
        }
    }
}
