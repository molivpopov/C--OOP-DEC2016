namespace MobilePhone
{
    using System;
    using Enums;
    using Common;
    using Contracts;
    public class Battery : IIdentifiable, IPrice, IPrintable
    {
        private const string PatternToPrintRest = "\n"+
            "Battery type:  {0}\n"+
            "Capacity:      {1} mAh\n" +
            "Time Call:     {2} min\n" +
            "Time Standby:  {3} min\n" +
            "Price:         {4} BGN";

        private string model;
        private BatteryType batType;
        private string manifacturer;
        private decimal? price;
        private int? capacity;
        private TimeSpan? timeCall;
        private TimeSpan? timeStandby;

        // mandatory constructor
        public Battery(string model, string manifacturer)
        {
            Validator.ValidateNullName(model);
            this.Model = model;

            Validator.ValidateNullName(manifacturer);
            this.Manifacturer = manifacturer;
        }

        // this constructor construct BatteryType from string and TimSpan from long
        public Battery
            (
            string model, string manifacturer,
            string batteryType, decimal price, int capacity, long timeCall, long timeStandby
            ) : this(model, manifacturer,
                (BatteryType) Validator.ParsEnum(typeof(BatteryType), batteryType),
                price, capacity, new TimeSpan(timeCall), new TimeSpan(timeStandby))
        {

        }

        // this constructor get Types as they are
        public Battery
            (
            string model, string manifacturer,
            BatteryType batteryType, decimal price, int capacity, TimeSpan timeCall, TimeSpan timeStandby
            ) : this(model, manifacturer)
        {

            // not mandatory
            this.batType = batteryType;
            this.Price = price;
            this.Capacity = capacity;
            this.TimeCall = timeCall;
            this.TimeStandby = timeStandby;
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
        public TimeSpan TimeCall
        {
            get
            {
                return this.timeCall ?? default(TimeSpan);
            }
            private set
            {
                this.timeCall = value;
            }
        }
        public TimeSpan TimeStandby
        {
            get
            {
                return this.timeStandby ?? default(TimeSpan);
            }
            private set
            {
                this.timeStandby = value;
            }
        }
        public int Capacity
        {
            get
            {
                return this.capacity ?? default(int);
            }
            private set
            {
                this.capacity = value;
            }
        }
        public BatteryType BatteryType
        {
            get
            {
                return this.batType;
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
        public string ToPrint()
        {
            string toPrint = string.Format(Constants.PatternToPrintMandatory, this.Model, this.Manifacturer);

            if (this.capacity == null)
            {
                return toPrint;
            }
            return toPrint + string.Format(PatternToPrintRest,
                this.BatteryType,
                this.Capacity,
                this.TimeCall.TotalMinutes,
                this.TimeStandby.TotalMinutes,
                this.Price);
        }
    }
}
