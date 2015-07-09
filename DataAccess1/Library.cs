using System.Collections.Generic;
using Infrastructure.Entities;
using Infrastructure.Utilities;

namespace DataAccess
{
    public class Library
    {
	    private IList<Movie> _movies;
	    private IList<Book> _books;

	    public Library()
	    {
		    _movies = new List<Movie>();
			_books = new List<Book>();
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
    }
}
