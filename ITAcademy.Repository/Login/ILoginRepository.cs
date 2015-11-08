using ITAcademy.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAcademy.Repository
{
  public interface ILoginRepository:IRepository<Login>
    {
      Login VarifyUser();
    }
}
