namespace MyGeneric
{
    using System;
    using System.Diagnostics;

    [DebuggerDisplay("Count = {Count}")]
    public class MyList<T>
        where T : IComparable
    {
        private const string separator = ", ";
        private int initCount;
        private T[] list;
        private int count;

        public MyList()
        {
            this.initCount = 2;
            Capacity = this.initCount;
            Count = 0;
            this.list = new T[Capacity];
        }

        // accessing element by index
        public T this[int index]
        {
            get
            {
                if (index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }
                return this.list[index];
            }
            set
            {
                if (index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }
                this.list[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }
            private set
            {
                this.count = value;
                if (this.count >= Capacity)
                {
                    Capacity *= 2;
                    var temp = new T[Capacity];
                    for (int i = 0; i < this.count; i++)
                    {
                        temp[i] = list[i];
                    }
                    list = temp;
                }
            }
        }
        public int Capacity { get; private set; }

        public void Add(T element)
        {
            list[Count] = element;
            Count++;
        }
        public bool RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                return false;
            }

            for (int i = index; i < Count - 1; i++)
            {
                this.list[i] = this.list[i + 1];
            }

            this.list[Count - 1] = default(T);
            Count--;
            return true;
        }
        public bool InsertAt(int index, T item)
        {
            if (index < 0 || index >= Count)
            {
                return false;
            }

            for (int i = Count++; i > index; i--)
            {
                this.list[i] = this.list[i - 1];
            }

            this.list[index] = item;

            return true;
        }

        // return index of element item, if not exist return -1
        public int Find(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (this.list[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }
        public void Clear()
        {
            Count = 0;
            this.list = new T[this.initCount];
        }

        //find the maximal item in the array
        public T Max()
        {
            T max = this.list[0];
            for (int i = 1; i < Count; i++)
            {
                if (max.CompareTo(this.list[i]) < 0)
                {
                    max = list[i];
                }
            }
            return max;
        }

        //find the minimal item in the array
        public T Min()
        {
            T min = this.list[0];
            for (int i = 1; i < Count; i++)
            {
                if (min.CompareTo(this.list[i]) > 0)
                {
                    min = list[i];
                }
            }
            return min;
        }
        public override string ToString()
        {
            string res = "";
            for (int i = 0; i < Count; i++)
            {
                res += this.list[i];
                if (i < Count - 1) { res += separator; }
            }
            return res;
        }

    }
}
