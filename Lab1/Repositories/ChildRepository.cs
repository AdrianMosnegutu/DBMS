using System.Data;
using System.Linq;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab1.Repositories
{
    internal class ChildRepository
    {
        private readonly string _connectionString;
        private readonly string _tableName;
        private readonly DataSet _dataSet;

        private readonly List<string> _columnParams;

        private readonly string _selectQuery;
        private readonly string _selectSpecificQuery;
        private readonly string _insertQuery;
        private readonly string _updateQuery;
        private readonly string _deleteQuery;

        public ChildRepository(
            string connectionString,
            DataSet dataSet,
            string tableName,
            string primaryKeyName,
            string foreignKeyName,
            List<string> columnNames
        )
        {
            _connectionString = connectionString;
            _dataSet = dataSet;
            _tableName = tableName;
            
            _columnParams = columnNames.Select(columnName => $"@{columnName}").ToList();
            string columnAssignments = string.Join(", ", columnNames.Zip(_columnParams, (a, b) => $"{a} = {b}"));

            _selectQuery = ConfigurationManager.AppSettings["SelectChildrenQuery"]
                .Replace("{TableName}", _tableName)
                .Replace("{ForeignKeyName}", foreignKeyName);

            _selectSpecificQuery = ConfigurationManager.AppSettings["SelectChildQuery"]
                .Replace("{TableName}", _tableName)
                .Replace("{PrimaryKeyName}", primaryKeyName);

            _insertQuery = ConfigurationManager.AppSettings["InsertChildQuery"]
                .Replace("{TableName}", tableName)
                .Replace("{ColumnNames}", string.Join(", ", columnNames))
                .Replace("{ColumnParams}", string.Join(", ", _columnParams));

            _updateQuery = ConfigurationManager.AppSettings["UpdateChildQuery"]
                .Replace("{TableName}", tableName)
                .Replace("{ColumnAssignments}", columnAssignments)
                .Replace("{PrimaryKeyName}", primaryKeyName);

            _deleteQuery = ConfigurationManager.AppSettings["DeleteChildQuery"]
                .Replace("{TableName}", tableName)
                .Replace("{PrimaryKeyName}", primaryKeyName);
        }

        public void LoadRecords(int parentId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(_selectQuery, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(selectCommand))
                {
                    selectCommand.Parameters.Add("@foreignKey", SqlDbType.Int).Value = parentId;

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

        public DataRow GetRecord(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(_selectSpecificQuery, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(selectCommand))
                {
                    selectCommand.Parameters.Add("@primaryKey", SqlDbType.Int).Value = id;

                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        return table.Rows[0];
                    }

                    return null;
                }
            }
        }

        public int InsertRecord(List<string> values)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand insertCommand = new SqlCommand(_insertQuery , connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(insertCommand))
                {
                    foreach (var (param, value) in _columnParams.Zip(values, (a, b) => (a, b)))
                    {
                        insertCommand.Parameters.AddWithValue(param, value);
                    }

                    int affectedRows = insertCommand.ExecuteNonQuery();
                    return affectedRows;
                }
            }
        }

        public int UpdateRecord(int id, List<string> values)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand updateCommand = new SqlCommand(_updateQuery, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(updateCommand))
                {
                    foreach (var (param, value) in _columnParams.Zip(values, (a, b) => (a, b)))
                    {
                        updateCommand.Parameters.AddWithValue(param, value);
                    }
                    updateCommand.Parameters.Add("primaryKey", SqlDbType.Int).Value = id;

                    int affectedRows = updateCommand.ExecuteNonQuery();
                    return affectedRows;
                }
            }
        }

        public int DeleteRecord(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand deleteCommand = new SqlCommand(_deleteQuery, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(deleteCommand))
                {
                    deleteCommand.Parameters.Add("primaryKey", SqlDbType.Int).Value = id;

                    int affectedRows = deleteCommand.ExecuteNonQuery();
                    return affectedRows;
                }
            }
        }
    }
}
