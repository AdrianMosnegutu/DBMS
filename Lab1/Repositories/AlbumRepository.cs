namespace Lab1.Repositories
{
    using System;
    using System.Data;
    using Lab1.Constants;
    using Microsoft.Data.SqlClient;

    /// <summary>
    /// Repository class for managing album records in the database.
    /// </summary>
    internal class AlbumRepository(string connectionString, DataSet dataSet)
    {
        /// <summary>
        /// Gets the DataTable containing the records from the "album" table.
        /// </summary>
        public DataTable Records => dataSet.Tables["album"];

        /// <summary>
        /// Loads album records for a specific artist into the dataset.
        /// </summary>
        /// <param name="artistId">The ID of the artist whose albums to load.</param>
        public void LoadRecords(int artistId)
        {
            using SqlConnection connection = new(connectionString);
            connection.Open();

            using SqlCommand selectCommand = new(SqlQueryConstants.SelectAlbumsByArtistIdQuery, connection);
            selectCommand.Parameters.Add("@artistId", SqlDbType.Int).Value = artistId;

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
        /// <param name="title">The title of the album.</param>
        /// <param name="releaseDate">The release date of the album.</param>
        /// <param name="artistId">The ID of the artist associated with the album.</param>
        /// <returns>The number of rows affected.</returns>
        public int InsertRecord(string title, DateTime releaseDate, int artistId)
        {
            using SqlConnection connection = new(connectionString);
            connection.Open();

            using SqlCommand insertCommand = new(SqlQueryConstants.InsertAlbumQuery, connection);
            insertCommand.Parameters.AddRange([
               new SqlParameter("@title", SqlDbType.VarChar, 50) { Value = title },
               new SqlParameter("@releaseDate", SqlDbType.DateTime) { Value = releaseDate },
               new SqlParameter("@artistId", SqlDbType.Int) { Value = artistId }
            ]);

            int affectedRows = insertCommand.ExecuteNonQuery();
            return affectedRows;
        }

        /// <summary>
        /// Updates an existing album record in the database.
        /// </summary>
        /// <param name="albumId">The ID of the album to update.</param>
        /// <param name="title">The new title of the album.</param>
        /// <param name="releaseDate">The new release date of the album.</param>
        /// <param name="artistId">The new artist ID associated with the album.</param>
        /// <returns>The number of rows affected.</returns>
        public int UpdateRecord(int albumId, string title, DateTime releaseDate, int artistId)
        {
            using SqlConnection connection = new(connectionString);
            connection.Open();

            using SqlCommand updateCommand = new(SqlQueryConstants.UpdateAlbumQuery, connection);
            updateCommand.Parameters.AddRange([
                new SqlParameter("@albumId", SqlDbType.Int) { Value = albumId },
                new SqlParameter("@title", SqlDbType.VarChar, 50) { Value = title },
                new SqlParameter("@releaseDate", SqlDbType.DateTime) { Value = releaseDate },
                new SqlParameter("@artistId", SqlDbType.Int) { Value = artistId },
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
            using SqlConnection connection = new(connectionString);
            connection.Open();

            using SqlCommand deleteCommand = new(SqlQueryConstants.DeleteAlbumByIdQuery, connection);
            deleteCommand.Parameters.Add("@albumId", SqlDbType.Int).Value = albumId;

            int affectedRows = deleteCommand.ExecuteNonQuery();
            return affectedRows;
        }
    }
}
