using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITAcademy.DataModels;
using ITAcademy.DataAccessLayer;
using Microsoft.Practices.Unity;
using System.Reflection;
namespace ITAcademy.Repository
  
{
   public class UserRepository:IUserRepository
    {
       [Dependency]
       public IDbConnection _database{get;set;}
        public IEnumerable<User> List
        {
            get { return _database.GetAll("sp_GetAllUsers").ToList<User>(); }
        }

        public int Create(User entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(User entity)
        {
            Dictionary<String, string> _parameters = new Dictionary<string, string>();
            _parameters.Add("Id", Convert.ToString(entity.Id));
            _parameters.Add("Name", entity.Name);
            _parameters.Add("FatherName", entity.FatherName);
            _parameters.Add("Salary", Convert.ToString(entity.Salary));
            _parameters.Add("Designation", entity.Designation);
            _parameters.Add("HiringDate", Convert.ToString(entity.HiringDate));
            _parameters.Add("Mobile", entity.Mobile);
         
            _parameters.Add("Designation", entity.Designation);
            return _database.Update("sp_UpdateUser", _parameters);
       
        }

        public User FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Users_Type> GetAllTypes()
        {
            return _database.GetAll("sp_GetAllUsersType").ToList<Users_Type>();

            
        }
        private Dictionary<String, String> Mapper(User entity)
        {
            Dictionary<String, String> _parameters = new Dictionary<string, string>();
            PropertyInfo[] properties = typeof(User).GetProperties();
            foreach (PropertyInfo property in properties)
            {
                _parameters.Add(property.Name, Convert.ToString(property.GetValue(entity)));
            }
            return _parameters;
        }

    }
}
