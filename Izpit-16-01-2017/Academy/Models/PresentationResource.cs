namespace Academy.Models
{
    using Academy.Models.Utils;

    public class PresentationResource : LecureResource
    {
        public PresentationResource(string name, string url) : base(name, url)
        {
            base.Type = "Presentation";
        }

    }
}
