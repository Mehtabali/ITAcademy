using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAcademy.DataModels
{
 public   class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Qualification { get; set; }
        public float Salary { get; set; }
        public string ImagePath { get; set; }
        public string Password { get; set; }
        public int Users_Type_Id { get; set; }
        public DateTime LastLoginDate { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    
    }
}
