using System;
using System.Data;
using System.Data.SqlClient;

namespace Lab1.Repositories
{
    internal class AlbumRepository
    {
        private readonly string _connectionString;
        private readonly DataSet _dataSet;

        private readonly string _selectQuery = 
            "SELECT * " +
            "FROM album " +
            "WHERE artist_id = @artistId";

        private readonly string _insertQuery = 
            "INSERT INTO album " +
            "(title, release_date, artist_id) " +
            "VALUES " +
            "(@title, @releaseDate, @artistId)";

        private readonly string _updateQuery = 
            "UPDATE album SET " +
            "title = @title, " +
            "release_date = @releaseDate, " +
            "artist_id = @artistId " +
            "WHERE album_id = @albumId";

        private readonly string _deleteQuery =
            "DELETE FROM album " +
            "WHERE album_id = @albumId";

        public AlbumRepository(string connectionString, DataSet dataSet)
        {
            _connectionString = connectionString;
            _dataSet = dataSet;
        }

        public void LoadRecords(int artistId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(_selectQuery, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(selectCommand))
                {
                    selectCommand.Parameters.Add("@artistId", SqlDbType.Int).Value = artistId;

                    if (_dataSet.Tables.Contains("album"))
                    {
                        _dataSet.Tables["album"].Clear();
                    }

                    adapter.Fill(_dataSet, "album");
                }
            }
        }

        public DataTable GetRecords()
        {
            return _dataSet.Tables["album"];
        }

        public int InsertRecord(string title, DateTime releaseDate, int artistId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand insertCommand = new SqlCommand(_insertQuery , connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(insertCommand))
                {
                    insertCommand.Parameters.Add("@title", SqlDbType.VarChar, 50).Value = title;
                    insertCommand.Parameters.Add("@releaseDate", SqlDbType.DateTime).Value = releaseDate;
                    insertCommand.Parameters.Add("@artistId", SqlDbType.Int).Value = artistId;

                    int affectedRows = insertCommand.ExecuteNonQuery();
                    return affectedRows;
                }
            }
        }

        public int UpdateRecord(int albumId, string title, DateTime releaseDate, int artistId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand updateCommand = new SqlCommand(_updateQuery, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(updateCommand))
                {
                    updateCommand.Parameters.Add("@title", SqlDbType.VarChar, 50).Value = title;
                    updateCommand.Parameters.Add("@releaseDate", SqlDbType.DateTime).Value = releaseDate;
                    updateCommand.Parameters.Add("@artistId", SqlDbType.Int).Value = artistId;
                    updateCommand.Parameters.Add("@albumId", SqlDbType.Int).Value = albumId;

                    int affectedRows = updateCommand.ExecuteNonQuery();
                    return affectedRows;
                }
            }
        }

        public int DeleteRecord(int albumId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand deleteCommand = new SqlCommand(_deleteQuery, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(deleteCommand))
                {
                    deleteCommand.Parameters.Add("@albumId", SqlDbType.Int).Value = albumId;

                    int affectedRows = deleteCommand.ExecuteNonQuery();
                    return affectedRows;
                }
            }
        }
    }
}
