using System.Collections.Generic;

namespace Infrastructure.Entities
{
	public interface IStatistics
	{
		string GetItemsCountMessage();
		string GetBasicInfo(IList<MediaItem> collection);
	}
}
