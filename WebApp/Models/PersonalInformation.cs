namespace WebApp.Models
{
    //public record PersonalInformation(string Name, string ShortDescription, List<Link> Links);
    //public record Link(string LinkUrl, string Title, string Icon);
    public class PersonalInformation
    {
        
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public List<Link> Links { get; set; }
    
    }
    
    public class Link
    {
        public Uri Url { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
    }
}
