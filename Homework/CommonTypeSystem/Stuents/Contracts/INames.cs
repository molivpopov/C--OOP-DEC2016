using System.Collections.Generic;

namespace Student
{
    public interface INames
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        List<int> Marks { get; set; }
    }
}
