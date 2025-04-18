namespace Lab1.Services
{
    using System;
    using System.Windows.Forms;
    using Lab1.Constants;
    using Lab1.Repositories;
    using Lab1.UI.Helpers;
    using Microsoft.Data.SqlClient;

    /// <summary>
    /// Provides services for managing artists and albums in the application.
    /// </summary>
    internal class AppService
    {
        private readonly AppRepository repository = new(AppConstants.ConnectionString);

        /// <summary>
        /// Loads the list of artists into the specified DataGridView.
        /// </summary>
        /// <param name="artistDataGridView">The DataGridView to populate with artist data.</param>
        public void LoadArtists(DataGridView artistDataGridView)
        {
            try
            {
                this.repository.ArtistRepository.LoadRecords();
                artistDataGridView.DataSource = this.repository.ArtistRepository.Records;

                if (artistDataGridView.Rows.Count > 0)
                {
                    artistDataGridView.Rows[0].Selected = true;
                }
            }
            catch (SqlException ex)
            {
                MessageBoxHelper.ShowErrorBox("Load Artists Error", $"Error loading artists: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowErrorBox("Load Artists Error", $"An unexpected error occurred: {ex.Message}");
            }
        }

        /// <summary>
        /// Loads the list of albums for a specific artist into the specified DataGridView.
        /// </summary>
        /// <param name="artistId">The ID of the artist whose albums are to be loaded.</param>
        /// <param name="albumDataGridView">The DataGridView to populate with album data.</param>
        public void LoadAlbums(int artistId, DataGridView albumDataGridView)
        {
            try
            {
                this.repository.AlbumRepository.LoadRecords(artistId);
                albumDataGridView.DataSource = this.repository.AlbumRepository.Records;

                if (albumDataGridView.Rows.Count > 0)
                {
                    albumDataGridView.Rows[0].Selected = true;
                }
            }
            catch (SqlException ex)
            {
                MessageBoxHelper.ShowErrorBox("Load Albums Error", $"Error loading albums: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowErrorBox("Load Albums Error", $"An unexpected error occurred: {ex.Message}");
            }
        }

        /// <summary>
        /// Adds a new album to the database.
        /// </summary>
        /// <param name="title">The title of the album.</param>
        /// <param name="releaseDate">The release date of the album.</param>
        /// <param name="artistId">The ID of the artist associated with the album.</param>
        public void AddAlbum(string title, DateTime releaseDate, int artistId)
        {
            try
            {
                this.repository.AlbumRepository.InsertRecord(title, releaseDate, artistId);
                MessageBoxHelper.ShowInfoBox("Added Album", "Successfully added album!");
            }
            catch (SqlException ex)
            {
                MessageBoxHelper.ShowErrorBox("Add Album Error", $"Error adding album: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowErrorBox("Add Album Error", $"An unexpected error occurred: {ex.Message}");
            }
        }

        /// <summary>
        /// Updates an existing album in the database.
        /// </summary>
        /// <param name="albumId">The ID of the album to update.</param>
        /// <param name="title">The new title of the album.</param>
        /// <param name="releaseDate">The new release date of the album.</param>
        /// <param name="artistId">The ID of the artist associated with the album.</param>
        public void UpdateAlbum(int albumId, string title, DateTime releaseDate, int artistId)
        {
            try
            {
                this.repository.AlbumRepository.UpdateRecord(albumId, title, releaseDate, artistId);
                MessageBoxHelper.ShowInfoBox("Updated Album", $"Successfully updated album #{albumId}!");
            }
            catch (SqlException ex)
            {
                MessageBoxHelper.ShowErrorBox("Update Album Error", $"Error updating album: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowErrorBox("Update Album Error", $"An unexpected error occurred: {ex.Message}");
            }
        }

        /// <summary>
        /// Deletes an album from the database.
        /// </summary>
        /// <param name="albumId">The ID of the album to delete.</param>
        public void DeleteAlbum(int albumId)
        {
            try
            {
                this.repository.AlbumRepository.DeleteRecord(albumId);
                MessageBoxHelper.ShowInfoBox("Deleted Album", $"Successfully deleted album #{albumId}!");
            }
            catch (SqlException ex)
            {
                MessageBoxHelper.ShowErrorBox("Delete Album Error", $"Error deleting album: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowErrorBox("Delete Album Error", $"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}
