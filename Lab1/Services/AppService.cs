using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Lab1.Repositories;

namespace Lab1.Services
{
    internal class AppService
    {
        private const string _connectionString = 
            "Data Source=PAJANGHINA;" +
            "Initial Catalog=music_app;" +
            "Integrated Security=True";

        private readonly AppRepository _repository = new AppRepository(_connectionString);

        public void LoadArtists(DataGridView artistDataGridView)
        {
            try
            {
                _repository.ArtistRepository.LoadRecords();
                artistDataGridView.DataSource = _repository.ArtistRepository.GetRecords();

                if (artistDataGridView.Rows.Count > 0)
                {
                    artistDataGridView.Rows[0].Selected = true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error loading artists: {ex.Message}", "Load Artists Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Load Artists Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadAlbums(int artistId, DataGridView albumDataGridView)
        {
            try
            {
                _repository.AlbumRepository.LoadRecords(artistId);
                albumDataGridView.DataSource = _repository.AlbumRepository.GetRecords();

                if (albumDataGridView.Rows.Count > 0)
                {
                    albumDataGridView.Rows[0].Selected = true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error loading albums: {ex.Message}", "Load Albums Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Load Albums Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddAlbum(string title, DateTime releaseDate, int artistId)
        {
            try
            {
                _repository.AlbumRepository.InsertRecord(title, releaseDate, artistId);
                MessageBox.Show("Successfully added album!", "Added Album", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error adding album: {ex.Message}", "Add Album Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Add Album Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateAlbum(int albumId, string title, DateTime releaseDate, int artistId)
        {
            try
            {
                _repository.AlbumRepository.UpdateRecord(albumId, title, releaseDate, artistId);
                MessageBox.Show($"Successfully updated album #{albumId}!", "Updated Album", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error updating album: {ex.Message}", "Update Album Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Update Album Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteAlbum(int albumId)
        {
            try
            {
                _repository.AlbumRepository.DeleteRecord(albumId);
                MessageBox.Show($"Successfully deleted album #{albumId}!", "Deleted Album", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error deleting album: {ex.Message}", "Delete Album Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Delete Album Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
