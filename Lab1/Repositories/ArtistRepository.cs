using System.Data;
using System.Data.SqlClient;
using Lab1.Services;

namespace Lab1.Repositories
{
    internal class ArtistRepository
    {
        private readonly string _connectionString;
        private readonly DataSet _dataSet;

        public ArtistRepository(DataSet dataSet)
        {
            _connectionString = AppService.ConnectionString;
            _dataSet = dataSet;
        }

        public void LoadRecords()
        {
            const string query = "SELECT * FROM artist";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(query, connection))
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
