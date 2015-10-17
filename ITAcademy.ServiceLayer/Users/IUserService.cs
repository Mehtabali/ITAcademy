using ITAcademy.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAcademy.ServiceLayer
{
  public interface IUserService
    {
      IEnumerable<User> GetAllUsers();
      int CreateUser(User user);
      int UpdateUser(User user);
      User FindById(int id);
      int DeleteUser(User user);
      IEnumerable<Users_Type> GetAllTypes();

    }
}
