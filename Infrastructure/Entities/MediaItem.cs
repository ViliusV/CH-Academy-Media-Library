using System;

namespace Infrastructure.Entities
{
    public class MediaItem
    {
	    public string Title { get; set; }
	    public DateTime? DateCreated { get; set; }
	    public bool IsCopyrighted { get; set; }


	    protected MediaItem(string title, DateTime? dateCreated)
	    {
		    Title = title;
			DateCreated = dateCreated;
		    IsCopyrighted = true;
	    }

		protected MediaItem(string title, DateTime? dateCreated, bool isCopyrighted)
		{
			Title = title;
			DateCreated = dateCreated;
			IsCopyrighted = isCopyrighted;
		}

	    protected MediaItem(string title) 
			: this(title, null, true)
	    {
		    
	    }


	    public virtual string GetInformation()
	    {
		    var year = DateCreated.HasValue ? DateCreated.Value.Year.ToString("") : "-";
		    return string.Format("Title: {0}, Year: {1}", Title, year);
	    }
    }
}
