using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAcademy.DataModels
{
   public  class Batch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Timings { get; set; }
        public int Courses_Id { get; set; }
        public int Users_Id { get; set; }// teacher id 
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public string CourseName { get; set; }
        public string UserName { get; set; }
    }
}
