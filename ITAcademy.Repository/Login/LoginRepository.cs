using ITAcademy.DataModels;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITAcademy.DataAccessLayer;

namespace ITAcademy.Repository
{
   public class LoginRepository:ILoginRepository
   {
      [Dependency]
      IDbConnection _database{get;set;}
      
       
        public Login VarifyUser()
        {
            return _database.GetAll("sp_getLoginDetails").ToEntity<Login>();
        }

        public IEnumerable<Login> List
        {
            get { throw new NotImplementedException(); }
        }

        public int Create(Login entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(Login entity)
        {
            throw new NotImplementedException();
        }

        public Login FindById(int Id)
        {
            throw new NotImplementedException();
        }
   }
}
