using ITAcademy.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAcademy.ServiceLayer
{
    public interface IBatchService
    {


        IEnumerable<Batch> GetAllBatches();
        int CreateBatch(Batch batch);
        int UpdateBatch(Batch batch);
        int DeleteBatch(int id);
        Batch GetOne(int Id);
      //  IEnumerable<Course> GetCourses();
         IEnumerable<Course> GetAllCourses();

         IEnumerable<User> GetAllTeacher();

         string GetDesignation(int userId);
    }
}
