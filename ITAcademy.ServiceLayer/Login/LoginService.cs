using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAcademy.ServiceLayer
{
    public class LoginService:ILoginService
    
    {
        [Dependency]
        private   ILoginService  _loginRepository {get;set;}
    
        public DataModels.Login VarifyUser()
        {
            return _loginRepository.VarifyUser();
        }
    }
}
