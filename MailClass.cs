using System;
using System.Net.Mail;

namespace SEGP
{
    class MailClass 
    {

        public MailClass(String to, String sms)
        {
            MailMessage mail = new MailMessage("rahman.khan803@hotmail.com", to, "Request to change the PAT", sms);
            SmtpClient clinet = new SmtpClient("smtp.live.com");
            clinet.Port = 25;
            clinet.Credentials = new System.Net.NetworkCredential("rahman.khan803@hotmail.com", "khan2013");
            clinet.EnableSsl = true;
            clinet.Send(mail);
        }

    }
}
