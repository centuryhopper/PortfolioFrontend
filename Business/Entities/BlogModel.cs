namespace Business.Entities;

public class BlogModel
{
    public string Title { get; set; }
    public DateTime Date { get; set; }
    public string PreviewDesc { get; set; }
    public string RouteName { get; set; }
    public List<VideoUrlModel>? VideoUrls { get; set; }
    public string FullDesc { get; set; }

    public override string ToString()
    {
        return $"{nameof(Title)}: {Title}, {nameof(Date)}: {Date}, {nameof(PreviewDesc)}: {PreviewDesc}, {nameof(RouteName)}: {RouteName},";
    }
}
