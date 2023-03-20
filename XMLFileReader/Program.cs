using System.IO;
using System;

namespace XMLFileReader
{
    class Program
    {
        static void Main(string[] args)
        {
            //XmlDocument XmlDoc = new XmlDocument();
            //XmlTextReader Xmlread = new XmlTextReader("C:\\Users\\sathishkumar.devados\\OneDrive - MSC\\Attachments\\samp fold\\Bolero API(ReceiveFile)\\India Files\\BoleroFile.xml");
            //while(Xmlread.Read())
            //{
            //    if(Xmlread.NodeType == XmlNodeType.Element && Xmlread.Name == "Party")
            //    {
            //       // XmlNodeList xnList = XmlDoc.SelectNodes( "/MessageHeader/PartyType");
            //        //foreach (XmlNode Name in xnList)
            //        //{
            //            //PartyType = Name["PartyType"].InnerText;
            //             string s1 = Xmlread.ReadElementString();
            //        Console.WriteLine("Party =" + s1);
            //  }
            //}

            string Sourcefolder = @"C:\Users\sathishkumar.devados\OneDrive - MSC\Attachments\samp fold\Bolero API (ReceiveFile)\India Files";
            string destinationfolder1 = @"C:\Users\sathishkumar.devados\OneDrive - MSC\Attachments\samp fold\Bolero API (ReceiveFile)\India Files\Zipfolder";
            string destinationfolder2 = @"C:\Users\sathishkumar.devados\OneDrive - MSC\Attachments\samp fold\Bolero API (ReceiveFile)\India Files\Xmlfolder";
            var getAllfiles = Directory.GetFiles(Sourcefolder, ".zip");
            foreach (var txtfile in getAllfiles)
            {
                var doc = Path.GetFileNameWithoutExtension(txtfile);
                var destfile = Path.GetExtension(txtfile);
                var destinatefilename = destinationfolder1 + doc + destfile;
                File.Move(txtfile,destinatefilename);
            }
            string[] getallfiles = Directory.GetFiles(Sourcefolder, ".xml");
            foreach(var xmlfile in getallfiles)
            {
                var destinatefile2 = destinationfolder2 + Path.GetFileNameWithoutExtension(xmlfile) + Path.GetExtension(xmlfile);
                File.Move(xmlfile, destinatefile2);  // --> to movethe file from one folder to another
                File.Delete(xmlfile); // --> to delete the file from selected folder
                File.Copy(xmlfile, destinatefile2); //--> to copy the file from one folder to another folder
            }

        }
    }
}
