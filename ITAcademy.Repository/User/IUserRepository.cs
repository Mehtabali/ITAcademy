using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITAcademy.DataModels;
namespace ITAcademy.Repository
{
     public interface  IUserRepository:IRepository<User>
    {
         IEnumerable<Users_Type> GetAllTypes();
    }
}
