using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITAcademy.DataModels;

namespace ITAcademy.Repository
{
  public interface IFeeRepository: IRepository<Fee>
    {
     // IEnumerable<Course> GetAllCourses();
      Fee GetFeeDetails(int id);
      IEnumerable<Student> GetAllStudents();
     // string GetName(int studentId);
      IEnumerable<Fee> GetAllFees();


    }
}
