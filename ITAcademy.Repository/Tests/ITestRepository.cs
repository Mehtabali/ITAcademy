using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITAcademy.Repository;
using ITAcademy.DataModels;
using System.Windows.Forms;

namespace ITAcademy.Repository
{
   public interface ITestRepository:IRepository<Test>
    {
       IEnumerable<Batch> GetAllBatches();
       IEnumerable<TestTransition> GetAllTests();
        //Test specific methods can be declared here
        //It is because the the Interface segregation principle of SOLID oops states so



       TestTransition GetBatchDetails(int id);
    }
}
