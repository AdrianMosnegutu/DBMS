namespace Lab1.Repositories
{
    using System.Data;
    using Lab1.Constants;
    using Lab1.Models;
    using Microsoft.Data.SqlClient;

    /// <summary>
    /// Repository class for managing album records in the database.
    /// </summary>
    internal class AlbumRepository(DataSet dataSet)
    {
        /// <summary>
        /// Gets the DataTable containing the records from the "album" table.
        /// </summary>
        public DataTable Records => dataSet.Tables["album"];

        /// <summary>
        /// Loads album records for a specific artist into the dataset.
        /// </summary>
        /// <param name="authorArtistId">The ID of the artist whose albums to load.</param>
        public void LoadRecords(int authorArtistId)
        {
            using SqlConnection connection = new(AppConstants.ConnectionString);
            connection.Open();

            using SqlCommand selectCommand = new(SqlQueryConstants.SelectAlbumsByArtistIdQuery, connection);
            selectCommand.Parameters.Add("@artistId", SqlDbType.Int).Value = authorArtistId;

            if (dataSet.Tables.Contains("album"))
            {
                dataSet.Tables["album"].Clear();
            }

            using SqlDataAdapter adapter = new(selectCommand);
            adapter.Fill(dataSet, "album");
        }

        /// <summary>
        /// Inserts a new album record into the database.
        /// </summary>
        /// <param name="album">The album object containing details such as title, release date, and artist ID.</param>
        /// <returns>The number of rows affected by the insert operation.</returns>
        public int InsertRecord(Album album)
        {
            using SqlConnection connection = new(AppConstants.ConnectionString);
            connection.Open();

            using SqlCommand insertCommand = new(SqlQueryConstants.InsertAlbumQuery, connection);
            insertCommand.Parameters.AddRange([
               new SqlParameter("@title", SqlDbType.VarChar, 50) { Value = album.Title },
               new SqlParameter("@releaseDate", SqlDbType.DateTime) { Value = album.ReleaseDate },
               new SqlParameter("@artistId", SqlDbType.Int) { Value = album.ArtistId }
            ]);

            int affectedRows = insertCommand.ExecuteNonQuery();
            return affectedRows;
        }

        /// <summary>
        /// Updates an existing album record in the database.
        /// </summary>
        /// <param name="album">The album object containing updated details such as ID, title, release date, and artist ID.</param>
        /// <returns>The number of rows affected by the update operation.</returns>
        public int UpdateRecord(Album album)
        {
            using SqlConnection connection = new(AppConstants.ConnectionString);
            connection.Open();

            using SqlCommand updateCommand = new(SqlQueryConstants.UpdateAlbumQuery, connection);
            updateCommand.Parameters.AddRange([
                new SqlParameter("@albumId", SqlDbType.Int) { Value = album.Id },
                new SqlParameter("@title", SqlDbType.VarChar, 50) { Value = album.Title },
                new SqlParameter("@releaseDate", SqlDbType.DateTime) { Value = album.ReleaseDate },
                new SqlParameter("@artistId", SqlDbType.Int) { Value = album.ArtistId },
            ]);

            int affectedRows = updateCommand.ExecuteNonQuery();
            return affectedRows;
        }

        /// <summary>
        /// Deletes an album record from the database.
        /// </summary>
        /// <param name="albumId">The ID of the album to delete.</param>
        /// <returns>The number of rows affected.</returns>
        public int DeleteRecord(int albumId)
        {
            using SqlConnection connection = new(AppConstants.ConnectionString);
            connection.Open();

            using SqlCommand deleteCommand = new(SqlQueryConstants.DeleteAlbumByIdQuery, connection);
            deleteCommand.Parameters.Add("@albumId", SqlDbType.Int).Value = albumId;

            int affectedRows = deleteCommand.ExecuteNonQuery();
            return affectedRows;
        }
    }
}
