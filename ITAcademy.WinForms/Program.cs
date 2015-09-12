using ITAcademy.DataAccessLayer;
using ITAcademy.Repository;
using ITAcademy.ServiceLayer;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITAcademy.WinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //UnityContainer container = new UnityContainer();
            //container.RegisterType<IDbConnection, DbConnection>();
            //container.Resolve<IDbConnection>();
            //container.RegisterType<IStudentRepository, StudentRepository>();
            //container.Resolve<IStudentRepository>();
            //container.RegisterType<IStudentService, StudentService>();
            //container.Resolve<IStudentService>();

            var container = Bootstrapper.BuildUnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<ShowAllStudents>());
        }
    }
}
