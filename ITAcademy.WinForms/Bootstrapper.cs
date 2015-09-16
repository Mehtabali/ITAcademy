using ITAcademy.DataAccessLayer;
using ITAcademy.Repository;
using ITAcademy.ServiceLayer;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAcademy.WinForms
{
    public static class Bootstrapper
    {
        public static IUnityContainer Initialise()
        {
            var container = BuildUnityContainer();
          
            return container;
        }

        public static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            
            // register all your components with the container here
            // e.g. container.RegisterType<ITestService, TestService>();    
            RegisterTypes(container);
            return container;
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IDbConnection, DbConnection>();
            container.RegisterType<IStudentRepository, StudentRepository>();
            container.RegisterType<IStudentService, StudentService>();
            container.RegisterType<ITestRepository, TestRepository>();
            container.RegisterType<ITestService, TestService>();
            container.RegisterType<IBatchRepository, BatchRepository>();
            //container.RegisterType<I>

            
        }
    }
}