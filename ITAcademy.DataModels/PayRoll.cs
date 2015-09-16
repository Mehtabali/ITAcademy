using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAcademy.DataModels
{
  public  class PayRoll
    {
        public int Id { get; set; }
        public int Users_Id { get; set; }
        public DateTime PayDate { get; set; }
        public string PaidBy { get; set; }
    
    }
}
