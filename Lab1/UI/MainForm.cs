namespace Lab1.UI
{
    using System;
    using System.Windows.Forms;
    using Lab1.Services;

    /// <summary>
    /// Represents the main form of the application, providing functionality to manage artists and albums.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Service layer instance for handling business logic related to artists and albums.
        /// </summary>
        private readonly AppService service = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// Sets up the form's components and default properties.
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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
        /// Handles the form's Load event. Resets input fields and loads artist data into the grid view.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.ResetInputFields();
            this.service.LoadArtists(this.artistGridView);
        }

        /// <summary>
        /// Handles the selection change event of the artist grid view.
        /// Loads albums for the selected artist into the album grid view.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void ArtistGridView_SelectChange(object sender, EventArgs e)
        {
            if (this.artistGridView.SelectedRows.Count != 1)
            {
                return;
            }

            DataGridViewRow selectedRow = this.artistGridView.SelectedRows[0];
            int artistId = int.Parse(selectedRow.Cells["artist_id"].Value.ToString());

            this.service.LoadAlbums(artistId, this.albumGridView);
        }

        /// <summary>
        /// Handles the click event of the Add button.
        /// Adds a new album for the selected artist and refreshes the album grid view.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (this.artistGridView.SelectedRows.Count != 1)
            {
                return;
            }

            DataGridViewRow selectedArtistRow = this.artistGridView.SelectedRows[0];
            int selectedArtistId = int.Parse(selectedArtistRow.Cells["artist_id"].Value.ToString());

            string title = this.titleTextBox.Text;
            DateTime releaseDate = this.releaseDateTimePicker.Value;
            int artistId = (int)this.artistIdNumericInput.Value;

            this.service.AddAlbum(title, releaseDate, artistId);
            this.service.LoadAlbums(selectedArtistId, this.albumGridView);

            this.ResetInputFields();
        }

        /// <summary>
        /// Handles the click event of the Update button.
        /// Updates the selected album's details and refreshes the album grid view.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (this.artistGridView.SelectedRows.Count != 1 || this.albumGridView.SelectedRows.Count != 1)
            {
                return;
            }

            DataGridViewRow selectedArtistRow = this.artistGridView.SelectedRows[0];
            int selectedArtistId = int.Parse(selectedArtistRow.Cells["artist_id"].Value.ToString());

            DataGridViewRow selectedAlbumRow = this.albumGridView.SelectedRows[0];
            int albumId = int.Parse(selectedAlbumRow.Cells["album_id"].Value.ToString());

            string title = this.titleTextBox.Text;
            DateTime releaseDate = this.releaseDateTimePicker.Value;
            int artistId = (int)this.artistIdNumericInput.Value;

            this.service.UpdateAlbum(albumId, title, releaseDate, artistId);
            this.service.LoadAlbums(selectedArtistId, this.albumGridView);

            this.ResetInputFields();
        }

        /// <summary>
        /// Handles the click event of the Delete button.
        /// Deletes the selected album and refreshes the album grid view.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.artistGridView.SelectedRows.Count != 1 || this.albumGridView.SelectedRows.Count != 1)
            {
                return;
            }

            DataGridViewRow selectedArtistRow = this.artistGridView.SelectedRows[0];
            int artistId = int.Parse(selectedArtistRow.Cells["artist_id"].Value.ToString());

            DataGridViewRow selectedAlbumRow = this.albumGridView.SelectedRows[0];
            int albumId = int.Parse(selectedAlbumRow.Cells["album_id"].Value.ToString());

            this.service.DeleteAlbum(albumId);
            this.service.LoadAlbums(artistId, this.albumGridView);

            this.ResetInputFields();
        }
    }
}
