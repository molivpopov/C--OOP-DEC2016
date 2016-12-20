namespace MobilePhone
{
    using System;
    using Common;
    using Contracts;

    public class Call : IPrintable, IPrice
    {
        private string phoneNumber;
        public Call(DateTime date, string number, TimeSpan duration)
        {
            Validator.ValidateNullName(number);
            this.PhoneNumber = number;
            this.DateOfCall = date;
            this.DurationOfCall = duration;
            this.PriceOfMinuteCall = Constants.DefaultPriceOfMinuteCall;
        }
        public Call(DateTime date, string number, TimeSpan duration, decimal price) : this(date, number, duration)
        {
            this.PriceOfMinuteCall = price;
        }
        public decimal PriceOfMinuteCall { get; private set; }
        public DateTime DateOfCall { get; private set; }
        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            private set
            {
                Validator.ValidatePhoneNumber(value);
                this.phoneNumber = value;
            }
        }
        public TimeSpan DurationOfCall { get; private set; }
        public decimal Price
        {
            get
            {
                var duration = this.DurationOfCall.TotalMinutes;
                duration = duration < 1 ? 1 : duration; // you cannot make call less than 1 minute
                return (decimal) (duration) * this.PriceOfMinuteCall;
            }
        }

        public string ToPrint()
        {
            return string.Format("{0} : {1} : {2} : Price:{3:f2}", this.DateOfCall, this.PhoneNumber, this.DurationOfCall, this.Price);
        }
    }
}
