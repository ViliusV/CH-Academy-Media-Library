using System.Collections.Generic;
using System.Linq;
using Infrastructure.Entities;
using Infrastructure.Utilities;

namespace DataAccess
{
    public class Library : IStatistics
    {
	    private IList<Movie> _movies;
	    private IList<Book> _books;
	    private IList<Song> _songs;
	    private IList<Album> _albums;

	    public Library()
	    {
		    _movies = new List<Movie>();
			_books = new List<Book>();
			_songs = new List<Song>();
			_albums = new List<Album>();
	    }

	    public void AddMovie(Movie movie)
	    {
		    if (movie != null && !_movies.Has(movie))
		    {
				_movies.Add(movie);
		    }
	    }

	    public void AddBook(Book book)
	    {
		    if (book != null && !_books.Has(book))
		    {
			    _books.Add(book);
		    }
	    }

	    public bool IsInLibrary(MediaItem item)
	    {
		    if (item.GetType() == typeof(Movie))
		    {
				return _movies.Has((Movie)item);
		    }

			if (item.GetType() == typeof(Book))
			{
				return _books.Has((Book)item);
			}

		    return false;
	    }

	    public IList<string> GetAllItemsInformation()
	    {
		    var information = new List<string>(); 
		    var items = new List<MediaItem>();
			items.AddRange(_movies);
			items.AddRange(_books);

		    foreach (var item in items)
		    {
			    information.Add(item.GetInformation());
		    }

		    return information;
	    }

	    public string GetItemsCountMessage()
	    {
		    var info = string.Format("Albums: {0} Songs: {1} Movies: {2} Books: {3}", _albums.Count, _songs.Count, _movies.Count, _books.Count);
		    return info;
	    }

	    public string GetBasicInfo(IList<MediaItem> collection)
	    {
		    var info = string.Empty;

		    foreach (var mediaItem in collection)
		    {
			    info += mediaItem.GetInformation();
		    }

		    return info;
	    }

	    public void AddToLibrary(MediaItem item)
	    {
		    if ((item.GetType() == typeof (Book)) && !_books.Has(item as Book))
		    {
			    _books.Add(item as Book);
		    }

			// ...
	    }


	    public IList<Album> GetBigAlbums(int minSongs)
	    {
		    return _albums.Where(a => a.Songs.Count >= minSongs).ToList();
	    } 

    }
}
