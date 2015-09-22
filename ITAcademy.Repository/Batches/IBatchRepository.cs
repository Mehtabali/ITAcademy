using ITAcademy.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAcademy.Repository
{
    public interface IBatchRepository:IRepository<Batch>
    {
        IEnumerable<Course> GetAllCourses(); 

        //Batch specific methods can be declared here
        //It is because the the Interface segregation principle of SOLID oops states so

        IEnumerable<User> GetAllTeachers();

        string GetDesignation(int userId);
    }
}
