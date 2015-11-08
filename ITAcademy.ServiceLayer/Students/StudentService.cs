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
        [Dependency]    //DI
        public IStudentRepository _studentRepository { get; set; }

        public IEnumerable<Student> GetAllStudents()
        {
            return _studentRepository.List;
        }

        public int CreateStudent(Student student)
        {

            // we can apply any specific business rule here a/c to requirmnts
            //we can apply some modification too in student object too..
            //cus this layer is responsilble for business rules 
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