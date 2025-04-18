namespace Lab1.Repositories
{
    using System.Data;

    /// <summary>
    /// Represents the main repository that provides access to the ArtistRepository and AlbumRepository.
    /// </summary>
    internal class AppRepository
    {
        /// <summary>
        /// The in-memory dataset used to store and manage data for the repositories.
        /// </summary>
        private readonly DataSet dataSet = new ();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppRepository"/> class.
        /// </summary>
        /// <param name="connectionString">The connection string used to connect to the database.</param>
        public AppRepository(string connectionString)
        {
            this.ArtistRepository = new ArtistRepository(connectionString, this.dataSet);
            this.AlbumRepository = new AlbumRepository(connectionString, this.dataSet);
        }

        /// <summary>
        /// Gets the repository for managing artist records.
        /// </summary>
        public ArtistRepository ArtistRepository { get; }

        /// <summary>
        /// Gets the repository for managing album records.
        /// </summary>
        public AlbumRepository AlbumRepository { get; }
    }
}
