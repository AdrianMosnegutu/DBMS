using System.Data;

namespace Lab1.Repositories
{
    internal class AppRepository
    {
        private readonly DataSet _dataSet = new DataSet();

        public ArtistRepository ArtistRepository { get; }
        public AlbumRepository AlbumRepository { get; }

        public AppRepository()
        {
            this.ArtistRepository = new ArtistRepository(_dataSet);
            this.AlbumRepository = new AlbumRepository(_dataSet);
        }
    }
}
