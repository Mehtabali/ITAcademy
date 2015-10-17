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
            return _studentRepository.List;
        }

        public int CreateStudent(Student student)
        {
            return _studentRepository.Create(student);
        }

        public Student GetStudent(int id)
        {
            return _studentRepository.FindById(id);
        }

        public int UpdateStudent(Student student)
        {
           // return _studentRepository.Update(student);
             return _studentRepository.Update(student);
        }

        public int DeleteStudent(int id)
        {
            return _studentRepository.Delete(id);
        }
    }
}