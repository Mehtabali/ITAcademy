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

        public IEnumerable<Test> List
        {
            //will get all tests from db
            //yes th masla kya hai kya smjh nhi aa rha tha
            // like apny student wala jo bhi banaya us mai ik relationship nazer araha hai ..

            // winfrom m ik function h jo servive class m hai ,, service class m ik function h jo repository m haia nd reposity m database ka function hai .. ik link h sb mai
            // mere pass winform sai direct database m functio h bs :(
            get { throw new NotImplementedException(); }
        }

        public int Create(Test entity)
        {
            Dictionary<String, string> _parameters = new Dictionary<string, string>();

            _parameters.Add("Courses_Id",  entity.Courses_Id.ToString());
            _parameters.Add("Batches_Id", entity.Batches_Id.ToString());
            _parameters.Add("Teacher_Id", entity.Teachers_Id.ToString());
            _parameters.Add("Description", entity.Description);
            _parameters.Add("PassingMarks", entity.PassingMarks.ToString());
            _parameters.Add("TotalMarks", entity.TotalMarks.ToString());
            
       //     _parameters.Add("TestDate", entity.TestDate.ToString());
            
            return _database.Create("sp_ScheduleTest", _parameters);

        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(Test entity)
        {
            throw new NotImplementedException();
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
    }
}
