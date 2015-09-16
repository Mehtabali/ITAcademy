using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITAcademy.DataModels;
using ITAcademy.Repository;
using Microsoft.Practices.Unity;


namespace ITAcademy.ServiceLayer
{
    public class TestService : ITestService
    {

        [Dependency]
        public ITestRepository _testRespository { get; set; }

        public IEnumerable<Test> GetAllTest()
        {
            throw new NotImplementedException();
        }

        public int CreateTest(Test test)
        {
            throw new NotImplementedException();
        }

        public Test GetTest(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(Test test)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<Batch> GetAllBatches()
        {
            return _testRespository.GetAllBatches("sp_SelectAllBatches");
        }
    }
}
