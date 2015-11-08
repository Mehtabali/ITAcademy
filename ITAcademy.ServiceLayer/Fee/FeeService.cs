using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITAcademy.DataModels;
using ITAcademy.ServiceLayer;
using Microsoft.Practices.Unity;
using ITAcademy.Repository;

namespace ITAcademy.ServiceLayer
{
  public  class FeeService: IFeeService
    {
      [Dependency]
      public IFeeRepository _feeRepository { get; set; }
        public IEnumerable<Fee> GetAllFees()
        {
            return _feeRepository.GetAllFees();
        }

        public int CreateFee(Fee fees)
        {
            return _feeRepository.Create(fees);
        }

        public int UpdateFee(Fee fees)
        {
            return _feeRepository.Update(fees);
        }

        public int DeleteFee(int id)
        {
            return _feeRepository.Delete(id);
        }

        public IEnumerable<Course> GetAllCourses()
        {
            //return _feeRepository.GetAllCourses();
            throw new NotImplementedException();
        }

        public Fee GetFeeDetails(int studentId)
        {
            return _feeRepository.GetFeeDetails(studentId);
        
        }


         public IEnumerable<Student> GetAllStudents()
        {
 	     throw new NotImplementedException();
        }

     }

      /*  public string GetName(int studentId)
        {
            throw new NotImplementedException();
        } */
    }
 
