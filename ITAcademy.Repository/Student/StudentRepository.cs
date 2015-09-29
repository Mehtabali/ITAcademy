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
            Dictionary<String, string> _parameters = new Dictionary<string, string>();

            _parameters.Add("Mobile", entity.Mobile);
            _parameters.Add("Name", entity.Name);
            _parameters.Add("City", entity.City);
            _parameters.Add("Email", entity.Email);
            _parameters.Add("FatherName", entity.FatherName);
            _parameters.Add("PIN", entity.PIN);
            _parameters.Add("Gender", entity.Gender);
            _parameters.Add("DOB", entity.DOB.ToString());
            _parameters.Add("Address", entity.Address);
            return _database.Create("sp_CreateStudent", _parameters);

        }

        public int Delete(int id)
        {
            return _database.Delete("sp_DeleteStudent", id);
        }

        public int Update(Student entity)
        {
            Dictionary<String, string> _parameters = new Dictionary<string, string>();
            _parameters.Add("Id", Convert.ToString(entity.Id));
            _parameters.Add("Mobile", entity.Mobile);
            _parameters.Add("Name", entity.Name);
            _parameters.Add("City", entity.City);
            _parameters.Add("Email", entity.Email);
            _parameters.Add("FatherName", entity.FatherName);
            _parameters.Add("PIN", entity.PIN);
            _parameters.Add("Gender", entity.Gender);
            _parameters.Add("DOB", entity.DOB.ToString());
            _parameters.Add("Address", entity.Address);
            return _database.Update("sp_UpdateStudent", _parameters);
        }

        public Student FindById(int id)
        {
            // string query = "Select * from Students where Id='"+id+"'";

            return _database.GetOne("sp_GetStudentById", id).ToEntity<Student>();
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