namespace Lab1.Constants
{
    /// <summary>
    /// Contains SQL query constants used throughout the application.
    /// </summary>
    internal static class SqlQueryConstants
    {
        /// <summary>
        /// SQL query to select all artists from the artist table.
        /// </summary>
        public const string SelectAllArtistsQuery = @"  
               SELECT *  
               FROM artist";

        /// <summary>
        /// SQL query to select albums by a specific artist ID from the album table.
        /// </summary>
        public const string SelectAlbumsByArtistIdQuery = @"  
               SELECT *  
               FROM album  
               WHERE artist_id = @artistId";

        /// <summary>
        /// SQL query to insert a new album into the album table.
        /// </summary>
        public const string InsertAlbumQuery = @"  
               INSERT INTO album (title, release_date, artist_id)  
               VALUES (@title, @releaseDate, @artistId)";

        /// <summary>
        /// SQL query to update an existing album in the album table.
        /// </summary>
        public const string UpdateAlbumQuery = @"  
               UPDATE album  
               SET title = @title,  
                   release_date = @releaseDate,  
                   artist_id = @artistId  
               WHERE album_id = @albumId";

        /// <summary>
        /// SQL query to delete an album by its ID from the album table.
        /// </summary>
        public const string DeleteAlbumByIdQuery = @"  
               DELETE FROM album  
               WHERE album_id = @albumId";
    }
}
