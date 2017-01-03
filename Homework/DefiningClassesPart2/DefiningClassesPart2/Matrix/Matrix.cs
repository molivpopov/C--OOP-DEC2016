namespace Matrix
{
    using System;
    using Commons;
    using Commons.Calculator;

    [Version(name:"D.Popov", version = 4.5)]
    public class Matrix<T, C>
    where T : new()
    where C : ICalculator<T>, new()

    {
        private const string PatternToPrint = "This mattrix have {0} rows, {1} colones, filled with {2} and this mattrix is:{3}";
        public Matrix(T[,] matrix)
        {
            var type = typeof(T);

            // this type list is not all numbers type, but it is enough
            if (
                type != typeof(int) &&
                type != typeof(float) &&
                type != typeof(decimal) &&
                type != typeof(ulong)
                )
            {
                throw new TypeAccessException(Constants.WrongType);
            }

            this.MatrixProp = matrix;
            this.RowRange = matrix.GetUpperBound(0) + 1;
            this.ColRange = matrix.GetUpperBound(1) + 1;
        }

        public T this[int row, int col]
        {
            get
            {
                // this validation is same like original, but not ever
                if (row >= this.RowRange || col >= this.ColRange || row < 0 || col < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                return this.MatrixProp[row, col];
            }
            set
            {
                // must validate
                this.MatrixProp[row, col] = value;
            }
        }
        public static Matrix<T, C> operator +(Matrix<T, C> a, Matrix<T, C> b)
        {
            // chek if a and b mattrix have the same size
            if (a.ColRange != b.ColRange || a.RowRange != b.RowRange)
            {
                throw new ArgumentException(Constants.SameSize);
            }

            // calculator.Add is simple addition between two numbers of type T
            return ExecutOperator(a, b, Number<T, C>.calculator.Add);
        }
        public static Matrix<T, C> operator -(Matrix<T, C> a, Matrix<T, C> b)
        {
            // chek if a and b mattrix have the same size
            if (a.ColRange != b.ColRange || a.RowRange != b.RowRange)
            {
                throw new ArgumentException(Constants.SameSize);
            }

            // action
            // calculator.Sub is simple subtraction between two numbers of type T
            return ExecutOperator(a, b, Number<T, C>.calculator.Sub);

        }
        public static Matrix<T, C> operator *(Matrix<T, C> a, Matrix<T, C> b)
        {
            // chek if a and b mattrix have the same size
            if (a.ColRange != b.ColRange || a.RowRange != b.RowRange)
            {
                throw new ArgumentException(Constants.SameSize);
            }

            // action
            // calculator.Multiply is simple product between two numbers of type T
            return ExecutOperator(a, b, Number<T, C>.calculator.Multiply);
        }
        public static bool operator true(Matrix<T, C> a)
        {
            for (int i = 0; i < a.RowRange; i++)
            {
                for (int j = 0; j < a.ColRange; j++)
                {
                    if (default(T).Equals((T) a.MatrixProp[i, j]))
                    {
                        return true;
                    }
                }

            }
            return false;
        }
        public static bool operator false(Matrix<T, C> a)
        {
            if (a) return true;

            return false;
        }

        public T[,] MatrixProp { get; private set; }
        public int RowRange { get; private set; }
        public int ColRange { get; private set; }
        private static Matrix<T, C> ExecutOperator(Matrix<T, C> a, Matrix<T, C> b, Func<T, T, T> matOperator)
        {
            var row = a.RowRange;
            var col = a.ColRange;
            var res = new Matrix<T, C>(new T[row, col]);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    res.MatrixProp[i, j] = matOperator((Number<T, C>) a.MatrixProp[i, j], (Number<T, C>) b.MatrixProp[i, j]);
                }

            }
            return res;
        }

        public override string ToString()
        {
            string volume = this ? "full" : "empty";
            return string.Format(PatternToPrint, RowRange, ColRange, typeof(T).Name, volume);
        }

    }
}
