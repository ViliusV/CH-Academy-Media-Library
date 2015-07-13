using System;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Entities
{
	public class Album : Song
	{
		private IList<string> _authors;
		private IList<string> _composers;
		public IList<Song> Songs { get; set; }

		public override IList<string> Authors
		{
			get { return Songs.SelectMany(s => s.Authors).ToList(); }
		}

		public override IList<string> Composers
		{
			get { return Songs.SelectMany(s => s.Composers).ToList(); }
		}

		public new IList<string> Performers { get; set; }

		public override int Duration
		{
			get { return Songs.Sum(x => x.Duration); }
		}

		protected Album(string title, DateTime? dateCreated) : base(title, dateCreated)
		{
		}

		protected Album(string title) : base(title)
		{
		}

		public override string GetInformation()
		{
			var info = string.Format("{0}, Performers: {1}", base.GetInformation(), string.Join("", Performers));
			return info;
		}
	}
}
