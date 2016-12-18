namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using Common;
    using Contracts;
    using Enums;
    using System.Linq;
    public class GSM : IPrice, IIdentifiable
    {
        private const string PatternToPrintFull = Constants.PatternToPrintMandatory + "\n" +
            "This IPhone4S? {6}\n" +
            "Price:         {2} BGN\n" +
            "Color:         {3}\n\n" +
            "------Display--------\n" +
            "{4}\n\n" +
            "------Battery--------\n" +
            "{5}";

        private string model;
        private string manifacturer;
        private static bool iphone4S;

        public GSM(string model, string manifacturer)
        {
            Validator.ValidateNullName(model);
            this.Model = model;

            Validator.ValidateNullName(manifacturer);
            this.Manifacturer = manifacturer;

            this.CallHistory = new List<Call>();

        }
        public GSM(string model, string manifacturer, Display display, Battery battery, Color color, decimal price) : this(model, manifacturer)
        {
            this.ColorGSM = color;
            this.Display = display;
            this.Battery = battery;
            this.Price = price + display.Price + battery.Price;

            // this is a real iphone - when have all proparty
            iphone4S = this.Manifacturer == "Apple" && this.Model == "IPhone4S";
        }

        public ICollection<Call> CallHistory { get; private set; }
        public static bool IPhone4S { get; }
        public Display Display { get; set; }
        public Battery Battery { get; set; }
        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                Validator.ValidateNames(value);
                Validator.ValidateLenghtOfName(value);
                this.model = value;
            }
        }
        public string Manifacturer
        {
            get
            {
                return this.manifacturer;
            }
            private set
            {
                Validator.ValidateNames(value);
                Validator.ValidateLenghtOfName(value);
                this.manifacturer = value;
            }
        }
        public Color ColorGSM { get; set; }
        public decimal Price { get; set; }

        public void AddCall(Call call)
        {
            this.CallHistory.Add(call);
        }
        public bool RemoveCall(Call call)
        {
            if (this.CallHistory.Count == 0)
            {
                throw new ArgumentNullException(Constants.HaveNothingToDelete);
            }

            return this.CallHistory.Remove(call);
        }
        public void ClearHistory()
        {
            this.CallHistory = new List<Call>();
        }
        public decimal TotalCallsPrice()
        {
            return this.CallHistory.Sum(x => x.Price);
        }

        // this methode return string - calls from history from date to date
        public string PrintHistory(DateTime fromDate, DateTime toDate)
        {
            string res = "";
            this.CallHistory
                  .ToList()
                  .FindAll(x => fromDate <= x.DateOfCall && x.DateOfCall <= toDate)
                  .ForEach(x => res += x.ToPrint() + "\n");
            return res;
        }
        public override string ToString()
        {

            return string.Format(PatternToPrintFull,
                Model,
                Manifacturer,
                Price,
                ColorGSM,
                Display.ToPrint(),
                Battery.ToPrint(),
                IPhone4S);
        }
    }
}
