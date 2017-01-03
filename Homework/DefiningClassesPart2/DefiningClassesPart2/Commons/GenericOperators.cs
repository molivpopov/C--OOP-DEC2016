namespace Commons.Calculator
{
    public interface ICalculator<T>

    {
        T Add(T a, T b);
        T Sub(T a, T b);
        T Multiply(T a, T b);


    }
    public struct IntCalculator : ICalculator<int>

    {
        public int Add(int a, int b) { return a + b; }
        public int Sub(int a, int b) { return a - b; }
        public int Multiply(int a, int b) { return a * b; }
    }
    public struct FloatCalculator : ICalculator<float>

    {
        public float Add(float a, float b) { return a + b; }
        public float Sub(float a, float b) { return a - b; }
        public float Multiply(float a, float b) { return a * b; }


    }
    public struct DecimalCalculator : ICalculator<decimal>

    {
        public decimal Add(decimal a, decimal b) { return a + b; }
        public decimal Sub(decimal a, decimal b) { return a - b; }
        public decimal Multiply(decimal a, decimal b) { return a * b; }


    }
    public struct ulongCalculator : ICalculator<ulong>

    {
        public ulong Add(ulong a, ulong b) { return a + b; }
        public ulong Sub(ulong a, ulong b) { return a - b; }
        public ulong Multiply(ulong a, ulong b) { return a * b; }


    }
    public struct Number<T, C>
    where C : ICalculator<T>, new()
    {
        // this struct overlap operators +, -, * for some number type
        // this make also, make implicit convertion (casting) between T and Number<T, C>
        private T value;
        public static C calculator = new C();
        private Number(T value)
        {
            this.value = value;
        }
        public static implicit operator Number<T, C>(T a)
        {
            return new Number<T, C>(a);
        }
        public static implicit operator T(Number<T, C> a)
        {
            return a.value;
        }
        public static Number<T, C> operator +(Number<T, C> a, Number<T, C> b)
        {
            return calculator.Add(a.value, b.value);
        }
        public static Number<T, C> operator -(Number<T, C> a, Number<T, C> b)
        {
            return calculator.Sub(a.value, b.value);
        }
        public static Number<T, C> operator *(Number<T, C> a, Number<T, C> b)
        {
            return calculator.Multiply(a.value, b.value);
        }
        //may add other operators /, ...
    }
}
