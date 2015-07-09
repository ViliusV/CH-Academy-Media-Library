using System;

namespace Infrastructure.Entities
{
	public class Movie : MediaItem
	{
		public string Director { get; set; }

		public string Genre { get; set; }

		public decimal? ImdbRating { get; set; }

		public Movie(string title, DateTime dateCreated, string director, string genre, decimal imdbRating) : base(title, dateCreated)
		{
			Director = director;
			Genre = genre;
			ImdbRating = imdbRating;
		}

		public override string GetInformation()
		{
			var info = base.GetInformation();
			info = string.Format("Movie: {0}, Director: {1}, Genre: {2}", info, Director, Genre);

			return info;
		}
	}
}
