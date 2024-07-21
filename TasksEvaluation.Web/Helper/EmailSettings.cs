using System.Net;
using System.Net.Mail;
using TasksEvaluation.Infrastructure.Models;

namespace TasksEvaluation.Web.Helper
{
    public static class EmailSettings
    {
        public static void SendEmail(Email email)
        {
            /// 555 port mail server
            ///naser@linkdv.com
            /// 
            var client = new SmtpClient("stemp.gmail.com", 587); // TCL :587

            //we can use pakage => mailkit : best

           client.EnableSsl = true;
 
           client.Credentials = new NetworkCredential("nassermessileo10@gmail.com", "password");

           client.Send("nassermessileo10@gmail.com", email.To,email.subject,email.body);
        
        }
    }
}
