using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedListAndEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] {1,2,3};

            foreach (var a in array)
            {
                Console.WriteLine($"A is {a}");
            }

            var enumerator = array.GetEnumerator();
            
            while (enumerator.MoveNext())
            {
                Console.WriteLine($"Enumerator A is {enumerator.Current}");
            }

            var infiniteEnumerable = new MyInfiniteEnumeable();

            enumerator = infiniteEnumerable.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine($"MyEnumerator is {enumerator.Current}");
            }
        }
    }

    public class MyInfiniteEnumeable : IEnumerable<int>
    {
        private int[] mData = new[] {4,5,6};

        public IEnumerator<int> GetEnumerator()
        {
            return new MyInfiniteEnumerator(mData);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class MyInfiniteEnumerator : IEnumerator<int>
    {
        private int[] _values;

        private int _index = -1;

        public MyInfiniteEnumerator(int[] values)
        {
            _values = values;
        }

        public bool MoveNext()
        {
            _index++;

            return _index < _values.Length;
        }

        public void Reset()
        {
            _index = 0;
        }

        public int Current => _values[_index];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }
}
