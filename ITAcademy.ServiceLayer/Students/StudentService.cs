using ITAcademy.DataModels;
using ITAcademy.Repository;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAcademy.ServiceLayer
{
    public class StudentService : IStudentService
    {
        [Dependency]
        public IStudentRepository _studentRepository { get; set; }

        public IEnumerable<Student> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public int CreateStudent(Student student)
        {
            return _studentRepository.Create(student);            
        }

        public Student GetStudent(int id)
        {
            throw new NotImplementedException();
        }

        public int UpdateStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public int DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }
    }
}