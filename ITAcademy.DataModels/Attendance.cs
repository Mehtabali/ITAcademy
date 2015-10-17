using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAcademy.DataModels
{
   public  class Attendance
    {
        public int Id{ get; set; }
        public int Students_Id{ get; set; }
        public int Batches_Id{ get; set; }
        public string isAttend{ get; set; }
        public DateTime todayDate{ get; set;}
    }
}
