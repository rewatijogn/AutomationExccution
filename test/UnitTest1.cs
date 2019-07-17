using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using EAGetMail;

namespace test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //string curpath = Directory.GetCurrentDirectory();
            //string mailbox = String.Format("{0}\\inbox", curpath);

            //// If the folder is not existed, create it.
            //if (!Directory.Exists(mailbox))
            //{
            //    Directory.CreateDirectory(mailbox);
            //}
            //MailServer oServer = new MailServer("outlook.office365.com", "rewati.jog@infinx.com", "Aboli10#", ServerProtocol.Imap4);
            ////outlook.office365.com
            //// MailServer oServer = new MailServer("imap.gmail.com", "rewatijogn@gmail.com", "#Rewat!N07", ServerProtocol.Imap4);
            //MailClient oClient = new MailClient("TryIt");

            //// Set SSL connection
            //oServer.SSLConnection = true;

            //// Set 993 IMAP4 SSL port
            //oServer.Port = 993;
            //oClient.Connect(oServer);
            
            //MailInfo[] infos = oClient.GetMailInfos();
            //int mcnt = oClient.GetMailCount();
            //MailInfo info = infos[mcnt-1];
            //Mail oMail = oClient.GetMail(info);            
            //var msg = oMail.TextBody;
            //string strSub = oMail.Subject;
            //var strFrm = oMail.From;
            //var dt = oMail.ReceivedDate;
            //var strto = oMail.To;


        }

    }
}

