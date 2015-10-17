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
  public  class AttendanceRepository:IAttendanceRepository
    {
      [Dependency]
      public IDbConnection _database { get; set; } 

        public IEnumerable<Batch> GetAllBatches()
        {
            return _database.GetAll("sp_SelectAllBatches").ToList<Batch>();
        }

        public TestTransition GetBatchDetails(int id)
        {
            return _database.GetOne("sp_GetCourseNameFromBatches", id).ToEntity<TestTransition>();
        }

        public IEnumerable<Attendance> List
        {
            get { throw new NotImplementedException(); }
        }

        public int Create(Attendance entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(Attendance entity)
        {
            throw new NotImplementedException();
        }

        public Attendance FindById(int Id)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<StudentTransition> GetBatchStudents(int id)
        {
            return _database.GetOne("sp_SelectBatchStudents", id).ToList<StudentTransition>();
        }
    }
}
