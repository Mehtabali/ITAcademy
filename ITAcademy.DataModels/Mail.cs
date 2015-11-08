using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAcademy.DataModels
{
   public class Mail
    {

        public int Id { get; set; }
        public int PortNumber { get; set; }
        public string SmtpAddress { get; set; }
        public string EmailFrom { get; set; }
        public string EmailTo { get; set; }
        public string Password { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
