using System;

namespace BridgeDesignPattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            MailSendBridge mb = new MailSendBridge();

            Google_Mail googleMail = new Google_Mail();
            Hotmail_Mail hotmailMail = new Hotmail_Mail();

            mb.SendFrom(googleMail);  
            mb.SendFrom(hotmailMail);


            Console.ReadLine();
        }
    }
}
