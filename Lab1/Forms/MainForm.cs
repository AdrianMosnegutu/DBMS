namespace Lab1.Forms
{
    using System;
    using System.Windows.Forms;
    using Lab1.Models;
    using Lab1.Repositories;
    using Lab1.ViewModels;

    /// <summary>
    /// Represents the main form of the application, providing UI for managing artists and albums.
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly MainFormViewModel viewModel = new(new AppRepository());

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.viewModel.OnArtistSelected += (_, artist) => this.viewModel.LoadAlbums(artist.Id, this.albumGridView);
        }

        /// <summary>
        /// Extracts an <see cref="Artist"/> object from the given DataGridView row.
        /// </summary>
        /// <param name="row">The DataGridView row containing artist data.</param>
        /// <returns>An <see cref="Artist"/> object populated with data from the row.</returns>
        private static Artist GetArtistFromRow(DataGridViewRow row)
        {
            return new Artist
            {
                Id = int.Parse(row.Cells["artist_id"].Value.ToString()),
                Name = row.Cells["name"].Value.ToString(),
                Bio = row.Cells["bio"].Value.ToString(),
                Country = row.Cells["country"].Value.ToString(),
                DebutYear = int.Parse(row.Cells["debut_year"].Value.ToString()),
            };
        }

        /// <summary>
        /// Extracts an <see cref="Album"/> object from the given DataGridView row.
        /// </summary>
        /// <param name="row">The DataGridView row containing album data.</param>
        /// <returns>An <see cref="Album"/> object populated with data from the row.</returns>
        private static Album GetAlbumFromRow(DataGridViewRow row)
        {
            return new Album
            {
                Id = int.Parse(row.Cells["album_id"].Value.ToString()),
                Title = row.Cells["title"].Value.ToString(),
                ReleaseDate = DateTime.Parse(row.Cells["release_date"].Value.ToString()),
                ArtistId = int.Parse(row.Cells["artist_id"].Value.ToString()),
            };
        }

        /// <summary>
        /// Creates an <see cref="Album"/> object from the user input fields.
        /// </summary>
        /// <returns>An <see cref="Album"/> object populated with user input data.</returns>
        private Album GetAlbumFromInput()
        {
            return new Album
            {
                Title = this.titleTextBox.Text,
                ReleaseDate = DateTime.Parse(this.releaseDateTimePicker.Value.ToString()),
                ArtistId = int.Parse(this.artistIdNumericInput.Value.ToString()),
            };
        }

        /// <summary>
        /// Resets the input fields to their default values.
        /// </summary>
        private void ResetInputFields()
        {
            this.titleTextBox.Text = "New Album";
            this.releaseDateTimePicker.Value = DateTime.Now;
            this.artistIdNumericInput.Value = 1;
        }

        /// <summary>
        /// Handles the form load event, initializing the UI and loading artist data.
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.ResetInputFields();
            this.viewModel.LoadArtists(this.artistGridView);
        }

        /// <summary>
        /// Handles the selection change event for the artist grid view.
        /// </summary>
        private void ArtistGridView_SelectChange(object sender, EventArgs e)
        {
            if (this.artistGridView.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = this.artistGridView.SelectedRows[0];
                this.viewModel.SelectedArtist = GetArtistFromRow(selectedRow);
            }
        }

        /// <summary>
        /// Handles the selection change event for the album grid view.
        /// </summary>
        private void AlbumGridView_SelectChange(object sender, EventArgs e)
        {
            if (this.albumGridView.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = this.albumGridView.SelectedRows[0];
                this.viewModel.SelectedAlbum = GetAlbumFromRow(selectedRow);
            }
        }

        /// <summary>
        /// Handles the click event for the Add button, adding a new album.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            this.viewModel.AddAlbum(this.GetAlbumFromInput());
            this.ResetInputFields();
        }

        /// <summary>
        /// Handles the click event for the Update button, updating the selected album.
        /// </summary>
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            this.viewModel.UpdateAlbum(this.GetAlbumFromInput());
            this.ResetInputFields();
        }

        /// <summary>
        /// Handles the click event for the Delete button, deleting the selected album.
        /// </summary>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            this.viewModel.DeleteAlbum();
            this.ResetInputFields();
        }
    }
}
