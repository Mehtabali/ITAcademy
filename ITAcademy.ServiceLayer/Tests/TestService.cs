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

        public IEnumerable<TestTransition> GetAllTest()
        {
            return _testRespository.GetTestList;
        }

        public int CreateTest(Test test)
        {
            return _testRespository.Create(test);
        }

        public Test GetTest(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(Test test)
        {
            return _testRespository.Update(test);
        }

        public int Delete(int id)
        {
            return _testRespository.Delete(id);
        }


        public IEnumerable<Batch> GetAllBatches()
        {
            return _testRespository.GetAllBatches();
        }


        public TestTransition GetBatchDetails(int batchId)
        {
            return _testRespository.GetBatchDetails(batchId);
            
        }




        public IEnumerable<Course> GetAllCourses()
        {
            return _testRespository.GetAllCourses();
        }


        public IEnumerable<User> GetAllTeachers()
        {
            return _testRespository.GetAllTeachers();
        }





        public IEnumerable<Notification> GetStudentInfoForMail()
        {
            return _testRespository.GetMailInfo();
        }


        public void Send(Mail _mail)
        {
            _testRespository.Send(_mail);
        }
    }
}
