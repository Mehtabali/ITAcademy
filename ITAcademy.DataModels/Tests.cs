using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAcademy.DataModels
{
  public class Tests
    {

        public int Id { get; set; }
        public int Courses_Id { get; set; }
        public int Batches_Id { get; set; }
        public string Description { get; set; }
        public int PassingMarks { get; set; }
        public int TotalMarks { get; set; }
        public int TestDate { get; set; }
        public int TotalMarks { get; set; }
        public int TestDate { get; set; }
      
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public int CreatedDate { get; set; }
        public int UpdatedDate { get; set; }
    }
}
