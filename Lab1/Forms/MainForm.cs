using System;
using System.Windows.Forms;
using Lab1.Services;

namespace Lab1
{
    public partial class MainForm : Form
    {
        private readonly AppService _service = new AppService();

        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ResetInputFields()
        {
            titleTextBox.Text = "New Album";
            releaseDateTimePicker.Value = DateTime.Now;
            artistIdNumericInput.Value = 1;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ResetInputFields();
            _service.LoadArtists(artistGridView);
        }

        private void ArtistGridView_SelectChange(object sender, EventArgs e)
        {
            if (artistGridView.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = artistGridView.SelectedRows[0];
                int artistId = int.Parse(selectedRow.Cells["artist_id"].Value.ToString());

                _service.LoadAlbums(artistId, albumGridView);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (artistGridView.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedArtistRow = artistGridView.SelectedRows[0];
                int selectedArtistId = int.Parse(selectedArtistRow.Cells["artist_id"].Value.ToString());

                string title = titleTextBox.Text;
                DateTime releaseDate = releaseDateTimePicker.Value;
                int artistId = (int)artistIdNumericInput.Value;

                _service.AddAlbum(title, releaseDate, artistId);
                _service.LoadAlbums(selectedArtistId, albumGridView);

                ResetInputFields();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (artistGridView.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedArtistRow = artistGridView.SelectedRows[0];
                int selectedArtistId = int.Parse(selectedArtistRow.Cells["artist_id"].Value.ToString());

                if (albumGridView.SelectedRows.Count == 1)
                {
                    DataGridViewRow selectedAlbumRow = albumGridView.SelectedRows[0];

                    int albumId = int.Parse(selectedAlbumRow.Cells["album_id"].Value.ToString());
                    string title = titleTextBox.Text;
                    DateTime releaseDate = releaseDateTimePicker.Value;
                    int artistId = (int)artistIdNumericInput.Value;

                    _service.UpdateAlbum(albumId, title, releaseDate, artistId);
                    _service.LoadAlbums(selectedArtistId, albumGridView);

                    ResetInputFields();
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (artistGridView.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedArtistRow = artistGridView.SelectedRows[0];
                int artistId = int.Parse(selectedArtistRow.Cells["artist_id"].Value.ToString());

                if (albumGridView.SelectedRows.Count == 1)
                {
                    DataGridViewRow selectedAlbumRow = albumGridView.SelectedRows[0];
                    int albumId = int.Parse(selectedAlbumRow.Cells["album_id"].Value.ToString());

                    _service.DeleteAlbum(albumId);
                    _service.LoadAlbums(artistId, albumGridView);

                    ResetInputFields();
                }
            }
        }
    }
}
