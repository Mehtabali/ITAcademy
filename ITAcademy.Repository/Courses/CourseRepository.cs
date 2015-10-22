using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITAcademy.DataModels;
using Microsoft.Practices.Unity;
using ITAcademy.DataAccessLayer;
using System.Reflection;

namespace ITAcademy.Repository
{
  public  class CourseRepository:ICourseRepository
    {
       [Dependency]
         public IDbConnection _database { get; set; }
        public IEnumerable<Course> List
        {
            get {
                return _database.GetAll("sp_GetCourses").ToList<Course>(); 
            }
        }

        public int Create(Course entity)
        {

             Dictionary<String, string> _parameters = new Dictionary<string, string>();
             _parameters.Add("Id",  Convert.ToString(entity.Id));
             _parameters.Add("Name", entity.Name);
             _parameters.Add("Duration", entity.Duration);
             _parameters.Add("Fee", Convert.ToString(entity.Fee));
             _parameters.Add("Description", entity.Description);


             return _database.Create("sp_CreateCourse", _parameters);
        }

        public int Delete(int id)
        {
            return _database.Delete("sp_DeleteCourse",id);
        }

        public int Update(Course entity)
        {
            Dictionary<String, string> _parameters = new Dictionary<string, string>();
            _parameters.Add("Id", Convert.ToString(entity.Id));
            _parameters.Add("Name", entity.Name);
            _parameters.Add("Duration", entity.Duration);
            _parameters.Add("Fee", Convert.ToString(entity.Fee));
            _parameters.Add("Description", entity.Description);
            return _database.Update("sp_UpdateCourse", _parameters);

        }

        public Course FindById(int Id)
        {
            throw new NotImplementedException();
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
