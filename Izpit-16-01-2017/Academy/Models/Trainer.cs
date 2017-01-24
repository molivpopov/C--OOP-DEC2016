namespace Academy.Models
{
    using System;
    using System.Collections.Generic;
    using Contracts;
    using Utils;
    using System.Linq;
    public class Trainer : ITrainer
    {
        private const string PatternToPrint = "* Trainer:\n - Username: {0}\n - Technologies: {1}";

        public Trainer(string username, string technologies)
        {
            Validator.CorrectName(username, 3, 16, Constants.TrainerCorrectName);
            this.Username = username;
            this.Technologies = technologies.Split(',').Select(x => x.Trim()).ToList();
        }

        public IList<string> Technologies
        { get; set; }

        public string Username
        { get; set; }

        public override string ToString()
        {
            var techno = string.Join("; ", this.Technologies);

            return string.Format(PatternToPrint, Username, techno);
        }
    }
}
