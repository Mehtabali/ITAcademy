using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITAcademy.DataModels;

namespace ITAcademy.Repository
{
   public class BatchRepository:IBatchRepository
    {
        public IEnumerable<Batch> List
        {
            get { throw new NotImplementedException(); }
        }

        public int Create(Batch entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(Batch entity)
        {
            throw new NotImplementedException();
        }

        public Batch FindById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
