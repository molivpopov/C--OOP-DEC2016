namespace SchoolClasses.Contracts
{
    using System.Collections.Generic;
    public interface ICommantable
    {
        IList<string> Comments { get; set; }
    }
}
