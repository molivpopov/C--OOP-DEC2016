namespace Test
{
    using System;
    using MobilePhone.Common;
    using MobilePhone.Enums;
    using MobilePhone;
    using System.Linq;
    class Program
    {
        static void Main()
        {
            // Model must be one word, containing latin Alpabet and/or decimal digits
            // Manifacturer must be one word, containing latin Alpabet and/or decimal digits
            // all allowed type of Battry are stored in enum BatteryType
            // all allowed type of Display are stored in enum DisplayType
            // all allowed Color of gsm's are stored in enum Color

            long ticks = Constants.OneSecond; // number ticks in one second

            // test of GSM    
            var battery = new Battery("UB16", "Hitachi", "LiIon", 12, 2000, (ticks * 30 * 60), (ticks * 300 * 60));
            var display = new Display("BigTouchscreen", "Sony");//, DisplayType.LCD, 33, 12.5f, 65536);
            var gsm = new GSM("B15", "Catarpilar", display, battery, Color.Gold, 555);
            Console.WriteLine(gsm);
            Console.WriteLine();

            // test of call
            var call = new Call(new DateTime(2016, 12, 19, 16, 12, 15), "+359 2 729291", new TimeSpan(ticks * 60));
            Console.WriteLine(call.ToPrint());
            Console.WriteLine();

            // Generate Call history
            var secondRandom = new Random();
            var dateRanodom = new Random(100);
            for (int i = 0; i < 20; i++) // 20 calls
            {
                call = new Call(
                    new DateTime(2016, 12, secondRandom.Next(3, 25), dateRanodom.Next(0,24), dateRanodom.Next(0,60), 15),
                    "+359 2 729291",
                    new TimeSpan(ticks * secondRandom.Next(1, 200)));
                gsm.AddCall(call);
            }

            // print all Call History from startDate to endDate
            DateTime startDate = new DateTime(2016,12,2);
            DateTime endDate = new DateTime(2016, 12, 26);
            Console.WriteLine(gsm.PrintHistory(startDate, endDate));
            Console.WriteLine();

            // print All Price
            Console.WriteLine("Total price:{0:f2}",gsm.TotalCallsPrice());

            // find the longest call
            var maxDuration = gsm.CallHistory.Max(x => x.DurationOfCall);
            var p = gsm.CallHistory.ToList().Find(x => x.DurationOfCall == maxDuration);
            gsm.RemoveCall(p);
            Console.WriteLine("Total price when remove the longest call ({1}sec) price:{0:f2}", gsm.TotalCallsPrice(), maxDuration.TotalSeconds);
            Console.WriteLine();

            // fully remove
            gsm.ClearHistory();
            Console.WriteLine("count of element in history when clear history: {0}", gsm.CallHistory.Count);

        }
    }
}
