using System;
using DataAccess;
using Infrastructure.Entities;

namespace Presentation
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var library = new Library();

			var godfather = new Movie("Godfather", new DateTime(1971, 1, 1), "F. F. Coppola", "Drama", 9);
			var daVinciCode = new Book("Da Vinci Code", new DateTime(2004, 1, 1), new[] {"Dan Brown"}, "Doubleday");

			library.AddMovie(godfather);
			library.AddBook(daVinciCode);

			var libraryInfo = library.GetAllItemsInformation();
			foreach (var libraryItemInfo in libraryInfo)
			{
				Console.WriteLine(libraryItemInfo);
			}

		}
	}
}
