using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace ITAcademy.DataAccessLayer
{

    //this layer ll only insert and take data from Database
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
        private  DataTable _datatable;
        private ListView _listview;
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
            try
            {
                AddParameters(parameters); //to add para
                return Execute(storedProcedure, parameters);
            }
            catch (Exception exception)
            {
                throw exception;
            }

        }

        public int Update(String storedProcedure, Dictionary<String, String> parameters)
        {
            try
            {
               AddParameters(parameters);
                return Execute(storedProcedure, parameters);
            }
            catch (Exception exception)
            {
                throw exception;
            }

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
                _connection.Close();
                return _status;//num of records inserted // ths no of rcds can be multiple .(trigger *)
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public int Delete(String storedProcedure, int id)
        {
            try
            {
                _command.CommandText = storedProcedure;
                if (_command.Parameters.Count > 0)
                    _command.Parameters.Clear();
                _command.Parameters.AddWithValue("@id",id);
                OpenConnection();
                return _command.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                throw exception;
            }

        }
       
        public DataTable GetAll(String storedProcedure)
        {
            try
            {
                _command.CommandText = storedProcedure;
                _datatable = new DataTable();
                _adapter.Fill(_datatable);
                return _datatable;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
        //public ListView GetAll(String storedProcedure)
        //{
        //    try
        //    {
        //        _command.CommandText = storedProcedure;
        //        _listview= new ListView();
        //        //_adapter.Fill(_listview);
        //        return _listview;
        //    }
        //    catch (Exception exception)
        //    {
        //        throw exception;
        //    }
        //}

        //ar

        public string Getsinglecolumn(String storedProcedure,int id) {
            try
            {

                _command.CommandText = storedProcedure;
                _command.Parameters.Clear();
                _command.Parameters.AddWithValue("@id", id);
                _connection.Open();
                string var = _command.ExecuteScalar().ToString();
                return var;

            }


            catch (Exception exception) {

                throw exception;
            
            }
        }
        public DataTable GetOne(String storedProcedure, int id)
        {
            try
            {
                _command.CommandText = storedProcedure;
                _command.Parameters.Clear();
                _datatable = new DataTable();
                _command.Parameters.AddWithValue("@Id",id);
                _adapter.Fill(_datatable);
                return _datatable;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
        // i did this for the combox present in winfrom
        // but i want to use service layer and repository us k liye kia karun ??
        //yes i thouht this too but iqra inst m dekh ker smjha ye ..

        //public void BindCombo(ComboBox cmb, string storedProcedure, string columnToBind)
        //{
        //    _command.Parameters.Clear();
        //    _command.CommandText = storedProcedure;
        //    _datatable = new DataTable();
        //    _adapter.Fill(_datatable);
        //    cmb.DisplayMember = columnToBind;
        //    cmb.ValueMember = "id";
        //    cmb.DataSource = _datatable;
        //}
        private void AddParameters(Dictionary<String, string> parameters, MethodType methodType)
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

        private void AddParameters(Dictionary<String, string> parameters)
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





        ListView GetList(string storedProcedure)
        {
            try
            {
                _command.CommandText = storedProcedure;
                _listview = new ListView();
               // _adapter.Fill(_datatable);
                return _listview;
            }
            catch (Exception exception)
            {
                throw exception;
            }  
        }


        ListView IDbConnection.GetList(string storedProcedure)
        {
            throw new NotImplementedException();
        }


        public bool SendMail(bool result)
        {
            return true;
        }
    }
}