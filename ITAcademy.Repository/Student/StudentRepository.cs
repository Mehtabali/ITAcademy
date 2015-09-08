using ITAcademy.DataAccessLayer;
using ITAcademy.DataModels;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ITAcademy.Repository
{
   public class StudentRepository : IStudentRepository
    {     
        [Dependency]
        public IDbConnection _database { get; set; }
        
        public IEnumerable<Student> List
        {
            get
            {
                return _database.GetAll("sp_GetStudents").ToList<Student>();
            }
        }

        public int Create(Student entity)
        {
            return _database.Create("sp_CreateStudent", Mapper(entity));
        }

        public int Delete(int id)
        {
            return _database.Delete("sp_DeleteStudent", id);
        }

        public int Update(Student entity)
        {
            return _database.Update("sp_UpdateStudent", Mapper(entity));
        }

        public Student FindById(int Id)
        {
            return _database.GetAll("sp_GetStudent").ToEntity<Student>();
        }
        private Dictionary<String, String> Mapper(Student entity)
        {
            Dictionary<String, String> _parameters = new Dictionary<string, string>();
            PropertyInfo[] properties = typeof(Student).GetProperties();
            foreach (PropertyInfo property in properties)
            {
                _parameters.Add(property.Name, Convert.ToString(property.GetValue(entity)));
            }
            return _parameters;
        }
    }
}