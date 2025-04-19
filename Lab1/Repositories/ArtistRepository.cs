namespace Lab1.Repositories
{
    using System.Data;
    using Lab1.Constants;
    using Microsoft.Data.SqlClient;

    /// <summary>
    /// Provides methods to interact with the "artist" table in the database.
    /// </summary>
    internal class ArtistRepository(DataSet dataSet)
    {
        /// <summary>
        /// Gets the DataTable containing the records from the "artist" table.
        /// </summary>
        public DataTable Records => dataSet.Tables["artist"];

        /// <summary>
        /// Loads artist records for a specific artist into the dataset.
        /// </summary>
        public void LoadRecords()
        {
            using SqlConnection connection = new(AppConstants.ConnectionString);
            connection.Open();

            using SqlCommand selectCommand = new(SqlQueryConstants.SelectAllArtistsQuery, connection);

            if (dataSet.Tables.Contains("artist"))
            {
                dataSet.Tables["artist"].Clear();
            }

            using SqlDataAdapter adapter = new(selectCommand);
            adapter.Fill(dataSet, "artist");
        }
    }
}
