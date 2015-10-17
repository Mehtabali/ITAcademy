using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITAcademy.DataModels;
using Microsoft.Practices.Unity;
using ITAcademy.Repository;
using ITAcademy.DataModels;
namespace ITAcademy.ServiceLayer
{
 public   class UserService:IUserService
    {

     [Dependency]
     public IUserRepository _userRepository { get; set; }
        public IEnumerable<User> GetAllUsers()
        {
            return _userRepository.List;
        }

        public int CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public int UpdateUser(User user)
        {
            return _userRepository.Update(user);
        }

        public User FindById(int id)
        {
            throw new NotImplementedException();
        }

        public int DeleteUser(User user)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<Users_Type> GetAllTypes()
        {
            return _userRepository.GetAllTypes().ToList<Users_Type>();
        }
    }
}
