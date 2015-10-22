using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITAcademy.Repository;
using ITAcademy.DataModels;

namespace ITAcademy.ServiceLayer
{
  public class CourseService:ICourseService
    {

     [Dependency]
      public ICourseRepository _courseRepository{get;set;}

        public IEnumerable<Course> GetAllCourses()
        {
            return _courseRepository.List;
        }

        public int Create(Course course)
        {
            return _courseRepository.Create(course);
        }

        public int Delete(int id)
        {
            return _courseRepository.Delete(id);
        }

        public int Update(Course course)
        {
            return _courseRepository.Update(course);
        }

        public Course FindById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
