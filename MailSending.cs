using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManageSystem
{
    internal class MailSending
    {
        public void PasswordSendingToMail(string userEmail, string pws)
        {
            try
            {
                MailMessage passWordMail = new MailMessage();
                passWordMail.From = new MailAddress("xxx@domain.com.tw", "HMS-System", Encoding.UTF8);
                passWordMail.To.Add(userEmail);
                passWordMail.Subject = "密碼修改認證";
                passWordMail.SubjectEncoding = Encoding.UTF8;
                passWordMail.Body = $"<h1>Hello, Your new psaaword is: {pws}</h1>";
                passWordMail.BodyEncoding = Encoding.UTF8;
                passWordMail.IsBodyHtml = true;
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Credentials = new NetworkCredential("XXX@gmail.com", "****");
                smtpClient.Host = "smtp.gmail.com"; //設定smtp Server
                smtpClient.Port = 25; //設定Port
                smtpClient.EnableSsl = true; //gmail預設開啟驗證
                smtpClient.Send(passWordMail);
                passWordMail.Dispose();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
    }
}