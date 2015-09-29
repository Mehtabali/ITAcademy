using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITAcademy.DataModels;
using Microsoft.Practices.Unity;
using ITAcademy.Repository;
namespace ITAcademy.ServiceLayer
{
    public class BatchService:IBatchService
    {
        [Dependency]
        public IBatchRepository _batchRepository { get; set; }

        public IEnumerable<Batch> GetAllBatches()
        {
            return _batchRepository.GetAllBatches();
        }

        public int CreateBatch(Batch batch)
        {
            return _batchRepository.Create(batch);
        }

        public int UpdateBatch(Batch batch)
        {
            return _batchRepository.Update(batch);
        }

        public int DeleteBatch(int id)
        {
            return _batchRepository.Delete(id);
        }

        public Batch GetOne(int Id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Course> GetAllCourses()
        {
            return _batchRepository.GetAllCourses();
        }





        public IEnumerable<User> GetAllTeacher()
        {
            return _batchRepository.GetAllTeachers();
        }


        public string GetDesignation(int userId)

        {
            string var = _batchRepository.GetDesignation(userId);
            return var;
        }
    }
}
