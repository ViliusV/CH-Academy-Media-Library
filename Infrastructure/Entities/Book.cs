using System;

namespace Infrastructure.Entities
{
	public class Book : MediaItem
	{
		public string[] Authors { get; set; }

		public string Publisher { get; set; }

		public Book(string title, DateTime dateCreated, string[] authors, string publisher) : base(title, dateCreated)
		{
			Authors = authors;
			Publisher = publisher;
		}

		public override string GetInformation()
		{
			var info = base.GetInformation();
			info = string.Format("Book: {0}, Authors: {1}, Publisher: {2}", info, string.Join(",", Authors), Publisher);

			return info;
		}

	}
}
