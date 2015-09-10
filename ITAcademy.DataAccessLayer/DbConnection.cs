using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ITAcademy.DataAccessLayer
{
    public class DbConnection : IDbConnection
    {
        private enum MethodType
        {
            Create,
            Update
        }
        private readonly String _connectionString;
        private readonly SqlConnection _connection;
        private readonly SqlCommand _command;
        private readonly SqlDataAdapter _adapter;
        private readonly DataTable _datatable;
        private int _status;
        public DbConnection()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["ITAcademy"].ConnectionString;
            _connection = new SqlConnection(_connectionString);
            _command = new SqlCommand();
            _command.CommandType = CommandType.StoredProcedure;
            _command.Connection = _connection;
            _adapter = new SqlDataAdapter(_command);
        }

        public int Create(String storedProcedure, Dictionary<String, String> parameters)
        {           
                AddParameters(parameters, MethodType.Create);
                return Execute(storedProcedure, parameters);           
        }

        public int Update(String storedProcedure, Dictionary<String, String> parameters)
        {           
                AddParameters(parameters, MethodType.Update);
                return Execute(storedProcedure, parameters);           
        }

        /// <summary>
        /// Responsible for Insert and Update operations
        /// </summary>
        /// <returns>returns no. of records inserted or updated</returns>
        /// 
        private int Execute(String storedProcedure, Dictionary<String, String> parameters)
        {
            try
            {
                _command.CommandText = storedProcedure;
                OpenConnection();
                _status = _command.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                CloseConnection();
            }
            return _status;
        }

        public int Delete(String storedProcedure, int id)
        {
            try
            {
                _command.CommandText = storedProcedure;
                _command.Parameters.AddWithValue("@id", id);
                OpenConnection();
                return _command.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally 
            {
                CloseConnection();
            }

        }
        public DataTable GetAll(String storedProcedure)
        {
            try
            {
                _command.CommandText = storedProcedure;
                _adapter.Fill(_datatable);
                return _datatable;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                CloseConnection();
            }
        }
        public DataTable GetOne(String storedProcedure, int id)
        {
            try
            {
                _command.CommandText = storedProcedure;
                _command.Parameters.AddWithValue("@id", id);
                _adapter.Fill(_datatable);
                return _datatable;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                CloseConnection();
            }
        }
        private void AddParameters(Dictionary<String, String> parameters, MethodType methodType)
        {
            if (_command.Parameters.Count > 0)
                _command.Parameters.Clear();
            if (MethodType.Create == methodType)
            {
                parameters.Remove("UpdatedBy");
            }
            else if (MethodType.Update == methodType)
            {
                parameters.Remove("CreatedBy");
            }
            foreach (KeyValuePair<string, string> parameter in parameters)
            {
                _command.Parameters.AddWithValue("@" + parameter.Key, parameter.Value);
            }

        }

        private void AddParameters(Dictionary<String, String> parameters)
        {
            if (_command.Parameters.Count > 0)
                _command.Parameters.Clear();
            foreach (KeyValuePair<string, string> parameter in parameters)
            {
                _command.Parameters.AddWithValue("@" + parameter.Key, parameter.Value);
            }
        }
        private void OpenConnection()
        {
            if (_connection.State != System.Data.ConnectionState.Open)
            {
                _connection.Open();
            }
        }
        private void CloseConnection()
        {
            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
        }
    }
}