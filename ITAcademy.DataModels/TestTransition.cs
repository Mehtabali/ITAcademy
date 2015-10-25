using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAcademy.DataModels
{
  public  class TestTransition
  {
        public int Id { get; set; }//test id
        public int BatchId { get; set; }
        public string BatchName { get; set; }
        public string Name { get; set; } //testName
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string TeacherName { get; set; }
        public int TeacherId { get; set; }
        public DateTime TestDate { get; set; }
        public int PassingMarks { get; set; }
        public int TotalMarks { get; set; }
        public string Description { get; set; }
      //extraaaaa flds kiu dalunnnnnnnnnnnnnnnnn is m jb sbb hen test m to ..
     

    }
}
