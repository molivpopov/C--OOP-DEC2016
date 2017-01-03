namespace Commons
{
    using System;
    public class VersionAttribute : Attribute

    {
        string name;
        public double version;
        public VersionAttribute(string name)
        {
            this.name = name;
            version = 1.0;  // Default value
        }

        public string GetName()
        {
            return name;
        }

    }
}