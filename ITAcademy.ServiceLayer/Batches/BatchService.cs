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

        public IEnumerable<Batch> GetAllBatch()
        {
            throw new NotImplementedException();
        }

        public int CreateBatch(Batch batch)
        {
            return _batchRepository.Create(batch);
        }

        public Batch UpdateBatch(Batch batch)
        {
            throw new NotImplementedException();
        }

        public int DeleteBatch(Batch batch)
        {
            throw new NotImplementedException();
        }

        public Batch GetOne(int Id)
        {
            throw new NotImplementedException();
        }

  }
}
