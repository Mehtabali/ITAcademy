using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAcademy.DataModels
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description  { get; set; }
        public float Fee { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set;}
    }
}
