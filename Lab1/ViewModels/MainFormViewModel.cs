namespace Lab1.ViewModels
{
    using System;
    using System.Windows.Forms;
    using Lab1.Forms.Helpers;
    using Lab1.Models;
    using Lab1.Repositories;
    using Microsoft.Data.SqlClient;

    /// <summary>
    /// ViewModel for the main form, providing data binding and interaction logic
    /// for artists and albums.
    /// </summary>
    internal class MainFormViewModel(AppRepository repository)
    {
        private Artist selectedArtist;

        /// <summary>
        /// Event triggered when the selected artist changes.
        /// </summary>
        public event EventHandler<Artist> OnArtistSelected;

        /// <summary>
        /// Gets or sets the currently selected artist.
        /// When set, triggers the <see cref="OnArtistSelected"/> event.
        /// </summary>
        public Artist SelectedArtist
        {
            get => this.selectedArtist;
            set
            {
                if (value != this.selectedArtist)
                {
                    this.selectedArtist = value;
                    this.OnArtistSelected?.Invoke(this, this.selectedArtist);
                }
            }
        }

        /// <summary>
        /// Gets or sets the currently selected album.
        /// </summary>
        public Album SelectedAlbum { get; set; }

        /// <summary>
        /// Loads the list of artists into the provided DataGridView.
        /// </summary>
        /// <param name="dataGridView">The DataGridView to populate with artist data.</param>
        public void LoadArtists(DataGridView dataGridView)
        {
            try
            {
                repository.ArtistRepository.LoadRecords();
                dataGridView.DataSource = repository.ArtistRepository.Records;
            }
            catch (SqlException ex)
            {
                MessageBoxHelper.ShowErrorBox("Error", $"Failed to load artists from the database: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowErrorBox("Error", $"An unexpected error occurred: {ex.Message}");
            }
        }

        /// <summary>
        /// Loads the list of albums for a specific artist into the provided DataGridView.
        /// </summary>
        /// <param name="authorArtistId">The ID of the artist whose albums to load.</param>
        /// <param name="dataGridView">The DataGridView to populate with album data.</param>
        public void LoadAlbums(int authorArtistId, DataGridView dataGridView)
        {
            try
            {
                repository.AlbumRepository.LoadRecords(authorArtistId);
                dataGridView.DataSource = repository.AlbumRepository.Records;
            }
            catch (SqlException ex)
            {
                MessageBoxHelper.ShowErrorBox("Error", $"Failed to load albums from the database: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowErrorBox("Error", $"An unexpected error occurred: {ex.Message}");
            }
        }

        /// <summary>
        /// Adds a new album to the repository and reloads the album list for the selected artist.
        /// </summary>
        /// <param name="album">The album to add.</param>
        public void AddAlbum(Album album)
        {
            try
            {
                repository.AlbumRepository.InsertRecord(album);
                repository.AlbumRepository.LoadRecords(this.SelectedArtist.Id);

                MessageBoxHelper.ShowInfoBox("Success", "Successfully added album to the database.");
            }
            catch (SqlException ex)
            {
                MessageBoxHelper.ShowErrorBox("Error", $"Failed to add album to the database: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowErrorBox("Error", $"An unexpected error occurred: {ex.Message}");
            }
        }

        /// <summary>
        /// Updates the currently selected album in the repository and reloads the album list
        /// for the selected artist.
        /// </summary>
        /// <param name="album">The updated album details.</param>
        public void UpdateAlbum(Album album)
        {
            try
            {
                album.Id = this.SelectedAlbum.Id;
                repository.AlbumRepository.UpdateRecord(album);
                repository.AlbumRepository.LoadRecords(this.SelectedArtist.Id);

                MessageBoxHelper.ShowInfoBox("Success", $"Successfully updated album {album.Title}.");
            }
            catch (SqlException ex)
            {
                MessageBoxHelper.ShowErrorBox("Error", $"Failed to update album: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowErrorBox("Error", $"An unexpected error occurred: {ex.Message}");
            }
        }

        /// <summary>
        /// Deletes the currently selected album from the repository and reloads the album list
        /// for the selected artist.
        /// </summary>
        public void DeleteAlbum()
        {
            try
            {
                repository.AlbumRepository.DeleteRecord(this.SelectedAlbum.Id);
                repository.AlbumRepository.LoadRecords(this.SelectedArtist.Id);

                MessageBoxHelper.ShowInfoBox("Success", $"Successfully deleted album {this.SelectedAlbum.Title}.");
            }
            catch (SqlException ex)
            {
                MessageBoxHelper.ShowErrorBox("Error", $"Failed to delete album: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowErrorBox("Error", $"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}
