using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITAcademy.DataModels;
using ITAcademy.DataAccessLayer;
using System.Reflection;
using Microsoft.Practices.Unity;

namespace ITAcademy.Repository
{
   public class FeeRepository: IFeeRepository
    {
       [Dependency]
       public IDbConnection _database { get; set; }

        public IEnumerable<Course> GetAllCourses()
        {
            return _database.GetAll("sp_GetAllCourses").ToList<Course>();
        }

        public Fee GetFeeDetails(int id)
        {

            return _database.GetOne("sp_getFeeDetail", id).ToEntity<Fee>();
        }

       /* public string GetName(int studentId)
        {
            throw new NotImplementedException();
        } */

        public IEnumerable<Fee> GetAllFees()
        {
            return _database.GetAll("sp_GetAllFee").ToList<Fee>();
        }

        public IEnumerable<Fee> List
        {
            get { throw new NotImplementedException(); }
        }

        public int Create(Fee entity)
        {
            Dictionary<String, string> _parameter = new Dictionary<string, string>();
            _parameter.Add("Students_Id", entity.Students_Id.ToString());
            _parameter.Add("Courses_Id", entity.Courses_Id.ToString());
            _parameter.Add("Month", entity.Month);
            _parameter.Add("Year", entity.Year);
            _parameter.Add("Amount", entity.Amount.ToString());
            return _database.Create("sp_CreateFee", _parameter);        
        }

        public int Delete(int id)
        {
            return _database.Delete("sp_DeleteFee", id);
        }

        public int Update(Fee entity)
        {
            Dictionary<String, string> _parameter = new Dictionary<string, string>();
            _parameter.Add("Id",Convert.ToString(entity.Id));
            _parameter.Add("Courses_Id", entity.Courses_Id.ToString());
            _parameter.Add("Students_Id", entity.Students_Id.ToString());
            _parameter.Add("Amount",entity.Amount.ToString());
            _parameter.Add("Month", entity.Month);
            _parameter.Add("Year", entity.Year);
            return _database.Update("sp_UpdateFee", _parameter);

        }

        public Fee FindById(int Id)
        {
            throw new NotImplementedException();
        }

        private Dictionary<String, String> Mapper(Fee entity)  
        {
            Dictionary<String, String> _parameters = new Dictionary<string, string>();
            PropertyInfo[] properties = typeof(Fee).GetProperties();
            foreach (PropertyInfo property in properties)
            {
                _parameters.Add(property.Name, Convert.ToString(property.GetValue(entity)));
            }
            return _parameters;
        }





        public IEnumerable<Student> GetAllStudents()
        {
            return _database.GetAll("sp_GetStudents").ToList<Student>();
        }
    }
}
