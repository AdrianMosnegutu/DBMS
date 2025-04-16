using System.Data;
using System.Data.SqlClient;

namespace Lab1.Repositories
{
    internal class ArtistRepository
    {
        private readonly string _connectionString;
        private readonly DataSet _dataSet;

        private readonly string _selectQuery = 
            "SELECT * " +
            "FROM artist";

        public ArtistRepository(string connectionString, DataSet dataSet)
        {
            _connectionString = connectionString;
            _dataSet = dataSet;
        }

        public void LoadRecords()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(_selectQuery, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(selectCommand))
                {
                    if (_dataSet.Tables.Contains("artist"))
                    {
                        _dataSet.Tables["artist"].Clear();
                    }

                    adapter.Fill(_dataSet, "artist");
                }
            }
        }

        public DataTable GetRecords()
        {
            return _dataSet.Tables["artist"];
        }
    }
}
