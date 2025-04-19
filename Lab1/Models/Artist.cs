namespace Lab1.Models
{
    /// <summary>
    /// Represents an artist with details such as ID, name, biography, country, and debut year.
    /// </summary>
    internal class Artist
    {
        /// <summary>
        /// Gets or sets the unique identifier for the artist.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the artist.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the biography of the artist.
        /// </summary>
        public string Bio { get; set; }

        /// <summary>
        /// Gets or sets the country of origin of the artist.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the year the artist debuted.
        /// </summary>
        public int DebutYear { get; set; }
    }
}
