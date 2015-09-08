using ITAcademy.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ITAcademy.ServiceLayer
{
   public interface IStudentService
    {
        IEnumerable<Student> GetAllStudents();
        int CreateStudent(Student student);
        Student GetStudent(int id);
        int UpdateStudent(Student student);
        int DeleteStudent(int id);
    }
}
