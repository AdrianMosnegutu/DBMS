using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Lab2.Repositories
{
    internal class ParentRepository
    {
        private readonly string _connectionString;
        private readonly DataSet _dataSet;
        private readonly string _tableName;
        
        private readonly string _selectQuery;

        public ParentRepository(string connectionString, DataSet dataSet, string tableName)
        {
            _connectionString = connectionString;
            _dataSet = dataSet;
            _tableName = tableName;

            _selectQuery = ConfigurationManager.AppSettings["SelectAllParentsQuery"].Replace("{TableName}", tableName);
        }

        public void LoadRecords()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(_selectQuery, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(selectCommand))
                {
                    if (_dataSet.Tables.Contains(_tableName))
                    {
                        _dataSet.Tables[_tableName].Clear();
                    }

                    adapter.Fill(_dataSet, _tableName);
                }
            }
        }

        public DataTable GetRecords()
        {
            return _dataSet.Tables[_tableName];
        }
    }
}
