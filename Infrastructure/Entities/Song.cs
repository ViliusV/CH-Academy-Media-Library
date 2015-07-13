using System;
using System.Collections.Generic;

namespace Infrastructure.Entities
{
	public class Song : MediaItem
	{
		public virtual IList<string> Authors  { get; set; }
		public virtual IList<string> Composers  { get; set; }
		public virtual IList<string> Performers  { get; set; }
		public virtual int Duration { get; set; }

		protected Song(string title, DateTime? dateCreated) : base(title, dateCreated)
		{
		}

		protected Song(string title) : base(title)
		{
		}

		public override string GetInformation()
		{
			var info = string.Format("{0}, Duration: {1}", base.GetInformation(), Duration);
			return info;
		}
	}
}
