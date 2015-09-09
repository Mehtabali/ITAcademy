using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAcademy.DataModels
{
    /// <summary>
    /// This model is responsible for student related activities.
    /// an other change..
    /// </summary>
    public class Student
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "First name is required")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "First name must be between 5 and 20 characters")]
        public String Name { get; set; }
        public String Mobile { get; set; }
        public String Email { get; set; }
        public String FatherName { get; set; }
        public String Gender { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String PIN { get; set; }
        public DateTime DOB { get; set; }
        public String ImagePath { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}
