using System.Reflection.Metadata;

namespace DevEncurtaUrl.API.Entities;

public class ShortenedCustomLink
{

    public ShortenedCustomLink(string title, string shortenedLink, string destinationLink)
    {
        Title = title;
        ShortenedLink = shortenedLink;
        DestinationLink = destinationLink;
    }

    public int Id { get; set; }

    public string Title { get; set; }
    
    public string  ShortenedLink { get; set; }

    public string DestinationLink { get; set; }
    
    public string CreatedAt { get; set; }
    
    public void Update(string title, string destinationLink)
    {
        Title = title;
        DestinationLink = destinationLink;
    }
}