using QL_ThucThiVBHanhChinh.Email;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_ThucThiVBHanhChinh
{
    class EmailController
    {
        private MailMessage mail;
        private SmtpClient smtpClient;
        private static EmailController mailInstance;

        public static EmailController MailInstance
        {
            get
            {
                if (mailInstance == null)
                    mailInstance = new EmailController();
                return mailInstance;
            }
            private set => mailInstance = value;
        }

        private EmailController()
        {
            mail = new MailMessage();
            smtpClient = new SmtpClient();
        }

        public void SendEmail(string emailFrom, string passwordEmail, List<string> emailTo, TemplateEmail template)
        {
            try
            {
                List<string> s1 = emailFrom.Split('@').ToList<string>();
                List<string> s2 = s1[1].Split('.').ToList<string>();
                smtpClient = new SmtpClient("smtp." + s2[0] + ".com");
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential(emailFrom, passwordEmail);
                smtpClient.EnableSsl = true;
                mail.From = new MailAddress(emailFrom);
                for (int i = 0; i < emailTo.Count; i++)
                {
                    mail.To.Add(emailTo[i]);
                }
                mail.Subject = template.subject;
                mail.Body = template.body;
                smtpClient.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không gửi được email!\n" + ex.Message, "Thông báo");
            }
        }
    }
}
