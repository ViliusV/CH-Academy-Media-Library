using System;

namespace Infrastructure.Entities
{
    public class MediaItem
    {
	    public string Title { get; set; }
	    public DateTime? DateCreated { get; set; }

	    protected MediaItem(string title, DateTime? dateCreated)
	    {
		    Title = title;
			DateCreated = dateCreated;
	    }

	    protected MediaItem(string title) 
			: this(title, null)
	    {
		    
	    }


	    public virtual string GetInformation()
	    {
		    var year = DateCreated.HasValue ? DateCreated.Value.Year.ToString("") : "-";
		    return string.Format("Title: {0}, Year: {1}", Title, year);
	    }
    }
}
