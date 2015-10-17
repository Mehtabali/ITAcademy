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
  public class AttendanceService:IAttendanceService
    {
      [Dependency]
      public IAttendanceRepository _attendanceRepository { get; set; }
        public IEnumerable<Batch> GetAllBatches()
        {
            return _attendanceRepository.GetAllBatches();
        }


        public TestTransition GetBatchDetails(int batchId)
        {
            return _attendanceRepository.GetBatchDetails(batchId);
        }


        public IEnumerable<StudentTransition> GetBatchStudents(int id)
        {
            return _attendanceRepository.GetBatchStudents(id);
        }
    }
}
