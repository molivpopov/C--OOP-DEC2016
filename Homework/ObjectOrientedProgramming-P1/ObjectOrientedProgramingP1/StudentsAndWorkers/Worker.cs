namespace StudentsAndWorkers
{
    using SchoolClasses.Contracts;
    using SchoolClasses.Commons;
    public class Worker : Human
    {
        private const int WorkDaysInWeek = 5;
        private const int WorkHoursPerDayDefault = 8;
        public Worker(string firstName, string lastName, decimal salary) : base(firstName, lastName)
        {
            Validator.RealSalary(salary);
            WeekSalary = salary;
            WorkHoursPerDay = WorkHoursPerDayDefault;
        }
        public Worker(string firstName, string lastName, decimal salary, int workHoursPerDay) : this(firstName, lastName, salary)
        {
            WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary { get; private set; }
        public int WorkHoursPerDay { get; private set; }
        public decimal MoneyPerHour()
        {
            return WeekSalary / WorkHoursPerDay / WorkDaysInWeek;
        }

        public override string ToString()
        {
            var type = " (" + this.GetType().Name.ToString() + ")";
            return base.ToString() + type + string.Format(", week salary:{0}", WeekSalary);
        }
    }
}
