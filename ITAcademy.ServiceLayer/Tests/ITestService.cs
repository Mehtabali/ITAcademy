using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITAcademy.DataModels;
namespace ITAcademy.ServiceLayer
{
    public interface ITestService
    {
      //  IEnumerable<Test> GetAllTest();
        int CreateTest(Test test);
        Test GetTest(int id);
        int Update(Test test);
        int Delete(int id);
        IEnumerable<Batch> GetAllBatches();
        IEnumerable<TestTransition> GetAllTest();
        TestTransition GetBatchDetails(int batchId);
         IEnumerable<Course> GetAllCourses();
         IEnumerable<User> GetAllTeachers();
       



    }
}
