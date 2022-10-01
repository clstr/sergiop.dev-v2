namespace WebApp.Models
{
    public class PersonalInformation
    {
        
        public string Name { get; set; }
        public List<string> SelfDescriptions { get; set; }
        public List<Link> Links { get; set; }
    
    }
    
    public class Link
    {
        public Uri Url { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
    }
}
