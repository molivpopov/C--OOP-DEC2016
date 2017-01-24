namespace Academy.Commands.Listing
{
    using System.Collections.Generic;
    using System.Linq;
    using Academy.Commands.Contracts;
    using Academy.Core.Contracts;
    using Models; 

    public class ListUsersCommand : ICommand
    {
        private readonly IAcademyFactory factory;
        private readonly IEngine engine;

        public ListUsersCommand(IAcademyFactory factory, IEngine engine)
        {
            this.factory = factory;
            this.engine = engine;
        }

        public string Execute(IList<string> parameters)
        {
   
            var toPrint = this.engine.Trainers.Select(x => (IUser)x).ToList();
            toPrint.AddRange(this.engine.Students);

            return string.Join("\n", toPrint);
        }
    }
}
