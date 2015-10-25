using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITAcademy.DataModels;
using ITAcademy.DataAccessLayer;
using Microsoft.Practices.Unity;
namespace ITAcademy.Repository
{
    public class TestRepository : ITestRepository
    {
        [Dependency]
        public IDbConnection _database { get; set; }

        public IEnumerable<TestTransition> GetTestList
        {
            get
            {
                return _database.GetAll("sp_ShowTestDetails").ToList<TestTransition>();
            }
        
        }

        public int Create(Test entity)
        {
            Dictionary<String, string> _parameters = new Dictionary<string, string>();
            _parameters.Add("Name", entity.Name);
            _parameters.Add("Courses_Id", entity.Courses_Id.ToString());
            _parameters.Add("Batches_Id", entity.Batches_Id.ToString());
            _parameters.Add("TestDate", entity.TestDate.ToString());
            _parameters.Add("Teacher_Id", entity.Teachers_Id.ToString());
            _parameters.Add("Description", entity.Description);
            _parameters.Add("PassingMarks", entity.PassingMarks.ToString());
            _parameters.Add("TotalMarks", entity.TotalMarks.ToString());
            
       //     _parameters.Add("TestDate", entity.TestDate.ToString());
            
            return _database.Create("sp_ScheduleTest", _parameters);

        }

        public int Delete(int id)
        {
            return _database.Delete("sp_DeleteTest", id);
        }

        public int Update(Test entity)
        {

            Dictionary<String, string> _parameters = new Dictionary<string, string>();
            _parameters.Add("Id", entity.Id.ToString());
            _parameters.Add("Name", entity.Name);
            _parameters.Add("Courses_Id", entity.Courses_Id.ToString());
            _parameters.Add("Batches_Id", entity.Batches_Id.ToString());
          //  _parameters.Add("TestDate", entity.TestDate.ToString());
            _parameters.Add("Teacher_Id", entity.Teachers_Id.ToString());
            _parameters.Add("PassingMarks", entity.PassingMarks.ToString());
            _parameters.Add("TotalMarks", entity.TotalMarks.ToString());
           
            return _database.Update("sp_UpdateTest", _parameters);
        }

        public Test FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Batch> GetAllBatches()
        {
            return _database.GetAll("sp_SelectAllBatches").ToList<Batch>();
        }


        public TestTransition GetBatchDetails(int id)
        {
            return _database.GetOne("sp_GetCourseNameFromBatches", id).ToEntity<TestTransition>();
        }


    //    public IEnumerable<TestTransition> GetAllTests()
    //    {
    //        return _database.GetAll("sp_ShowTestDetails").ToList<TestTransition>();
    //    }


      
        IEnumerable<Test> IRepository<Test>.List
        {
            get { throw new NotImplementedException(); }
        }


        public IEnumerable<Course> GetAllCourses()
        {
            return _database.GetAll("sp_GetAllCourses").ToList<Course>();
            
        }


        public IEnumerable<User> GetAllTeachers()
        {
            return _database.GetAll("sp_GetAllTeachers").ToList<User>();
        }
    }
}
