using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAcademy.DataModels
{
  public  class TestTransition
    {
        public int BatchId { get; set; }
        public string BatchName { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string TeacherName { get; set; }
        public int TeacherId { get; set; } 

    }
}
