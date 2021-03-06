﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ITAcademy.DataAccessLayer
{
    public interface IDbConnection
    {
        int Create(String storedProcedure, Dictionary<String, String> parameters);
        int Update(String storedProcedure, Dictionary<String, String> parameters);
        int Delete(String storedProcedure, int id);
        DataTable GetAll(String storedProcedure);
        ListView GetList(String storedProcedure); 
        DataTable GetOne(String storedProcedure, int id);
        string Getsinglecolumn(string p, int userId);
        bool SendMail(bool result);
        
     //   DataTable GetAllOnId(String storedProcedure, int id);
       // DataTable Select(string storedProcedure, params string[] parameters);
    }
}
