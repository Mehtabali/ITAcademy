﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITAcademy.DataModels;
using ITAcademy.DataAccessLayer;
using System.Reflection;
using Microsoft.Practices.Unity;

namespace ITAcademy.Repository
{
   public class BatchRepository:IBatchRepository
    {
       [Dependency]
       public IDbConnection _database { get; set; }
        public IEnumerable<Batch> List
        {
            get { throw new NotImplementedException(); }
        }

        public int Create(Batch entity)
        {
            //data binding 

            Dictionary<String, string> _parameters = new Dictionary<string, string>();
            _parameters.Add("Name",entity.Name);
            _parameters.Add("Courses_Id", entity.Courses_Id.ToString());
            _parameters.Add("Users_Id", entity.Users_Id.ToString());
            _parameters.Add("Timings", entity.Timings);
            return _database.Create("sp_CreateBatch", _parameters);
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

        private Dictionary<String, String> Mapper(Student entity)
        {
            Dictionary<String, String> _parameters = new Dictionary<string, string>();
            PropertyInfo[] properties = typeof(Batch).GetProperties();
            foreach (PropertyInfo property in properties)
            {
                _parameters.Add(property.Name, Convert.ToString(property.GetValue(entity)));
            }
            return _parameters;
        }
    }
}
