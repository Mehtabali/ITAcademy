using ITAcademy.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAcademy.ServiceLayer
{
 public interface ICourseService
    {

     IEnumerable<Course> GetAllCourses();
     int Create(Course course);
     int Delete(int id);
     int Update(Course course);
     Course FindById(int id);

    }
}
