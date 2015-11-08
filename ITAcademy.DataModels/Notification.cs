using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAcademy.DataModels
{
   public class Notification
    {
      //  public int Batches_Id { get; set; }
        public int StudentId{ get; set; }
        public string StudentName { get; set; }
        public string SmtpAddress { get; set; }
        public int PortNumber { get; set; }
        public string  StudentEmail { get; set; }
        public string SenderEmail { get; set; }
        public string Password { get; set; }
    }
}
