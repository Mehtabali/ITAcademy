using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAcademy.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> List { get; }
        int Create(T entity);
        int Delete(int id);
        int Update(T entity);
        T FindById(int Id);
    }
}
