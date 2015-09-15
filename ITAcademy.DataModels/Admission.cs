using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAcademy.DataModels
{
    class Admission
    {

        public int Id { get; set; }
        public int Students_Id { get; set; }
        public int Courses_Id { get; set; }
        public float Fee { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}
