using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAcademy.DataModels
{
    public class Course
    { 
        
        public int Id { get; set; }// ID
        public string Name { get; set; }
        public string Description{ get; set; }
        public string Duration { get; set; }
        public Double Fees { get; set; }//FEE
       // public int CreatedBy { get; set; }
       // public int UpdatedBy { get; set;}
    }
}
