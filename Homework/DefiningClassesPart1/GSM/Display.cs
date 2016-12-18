namespace MobilePhone
{
    using Enums;
    using Common;
    using Contracts;
    public class Display : IIdentifiable, IPrice, IPrintable
    {
        private const string PatternToPrintRest = "\n"+
            "diagonal size: {2:f2}\"\n"+
            "Colors:        {1}\n"+
            "price:         {0} BGN";

        string manifacturer;
        string model;
        decimal? price;

        // mandatory constructor
        public Display(string model, string manifacturer)
        {
            Validator.ValidateNullName(model);
            this.Model = model;

            Validator.ValidateNullName(manifacturer);
            this.Manifacturer = manifacturer;
        }

        // this constructor get Types as they are
        public Display
            (
            string model, string manifacturer,
            DisplayType displayType, decimal price, float size, int colors
            ) : this(model, manifacturer)
        {
            this.DisplayType = displayType;
            this.Price = price;
            this.SizeInCm = size;
            this.Colors = colors;
        }

        // this constructor construct DisplayType from string
        public Display
            (string model, string manifacturer, string displayType, decimal price, float size, int colors)
            : this
            (model, manifacturer, (DisplayType) Validator.ParsEnum(typeof(DisplayType), displayType), price, size, colors)
        {

        }
        public DisplayType DisplayType { get; private set; }
        public int? Colors { get; private set; }
        public float? SizeInCm { get; private set; }
        public float SizeInInches
        {
            get
            {
                return (this.SizeInCm ?? default(float)) / Constants.CmPerInches;
            }
        }
        public decimal Price
        {
            get
            {
                return this.price ?? default(decimal);
            }
            private set
            {
                this.price = value;
            }
        }

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

        public string ToPrint()
        {
            string toPrint = string.Format(Constants.PatternToPrintMandatory, this.Model, this.Manifacturer);

            if (this.price == null)
            {
                return toPrint;
            }

            return toPrint + string.Format(PatternToPrintRest, this.Price, this.Colors, this.SizeInInches);
        }
    }
}