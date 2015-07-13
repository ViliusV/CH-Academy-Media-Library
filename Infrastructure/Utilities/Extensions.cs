using System;
using System.Collections.Generic;
using System.Linq;
using Infrastructure.Entities;

namespace Infrastructure.Utilities
{
	public static class Extensions
	{
		public static bool Has(this IList<Movie> collection, Movie movie)
		{
			var isInCollection = false;

			if (collection != null && movie != null)
			{
				isInCollection = collection.Any(m =>
					m.Title.Equals(movie.Title, StringComparison.InvariantCultureIgnoreCase)
					&& m.DateCreated == movie.DateCreated
					&& m.Genre == movie.Genre);
			}

			return isInCollection;
		}

		public static bool Has(this IList<Book> collection, Book book)
		{
			var isInCollection = false;

			if (collection != null && book != null)
			{
				var matchingItems =
					from b in collection
					where b.Title.Equals(book.Title, StringComparison.InvariantCultureIgnoreCase)
					      && b.DateCreated == book.DateCreated
					      && b.Authors.SequenceEqual(book.Authors)
					select b;

				isInCollection = matchingItems.Any();
			}

			return isInCollection;
		}

		public static string ToShortString(this string text)
		{
			return text.Substring(0, 140);
		}
	}
}
