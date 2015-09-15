using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAcademy.DataModels
{
    class Fees
    {
        public int Id { get; set; }
        public int Students_Id { get; set; }
        public int Courses_Id { get; set; }
        public float Amount { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    
    }
}
