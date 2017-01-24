namespace Academy.Models
{
    using Academy.Models.Utils;

    public class DemoResource : LecureResource
    {
        public DemoResource(string name, string url) : base(name, url)
        {
            base.Type = "Demo";
        }
    }
}
