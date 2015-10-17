using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITAcademy.DataModels;
namespace ITAcademy.ServiceLayer
{
public interface IAttendanceService
    {

    IEnumerable<Batch> GetAllBatches();
    IEnumerable<StudentTransition> GetBatchStudents(int id);
    TestTransition GetBatchDetails(int batchId);





    }
}
