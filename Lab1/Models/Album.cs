namespace Lab1.Models
{
    using System;

    /// <summary>
    /// Represents a music album with details such as its ID, title, release date, and associated artist ID.
    /// </summary>
    internal class Album
    {
        /// <summary>
        /// Gets or sets the unique identifier for the album.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the title of the album.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the release date of the album.
        /// </summary>
        public DateTime ReleaseDate { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the artist associated with the album.
        /// </summary>
        public int ArtistId { get; set; }
    }
}
