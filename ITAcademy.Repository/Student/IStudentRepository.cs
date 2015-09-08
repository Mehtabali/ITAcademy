using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITAcademy.DataModels;
namespace ITAcademy.Repository
{
    public interface IStudentRepository : IRepository<Student>
    {
        //Student specific methods can be declared here
        //It is because the the Interface segregation principle of SOLID oops states so
     
    }
}
