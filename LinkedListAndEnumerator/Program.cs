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

            //foreach (var i in infiniteEnumerable)
            //{
            //    Console.WriteLine($"I is {i}");
            //}

            enumerator = infiniteEnumerable.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine($"Enumerator A is {enumerator.Current}");
            }
        }
    }

    public class MyInfiniteEnumeable : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            return new MyInfiniteEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class MyInfiniteEnumerator : IEnumerator<int>
    {
        public bool MoveNext()
        {
            Current++;

            return true;
        }

        public void Reset()
        {
            Current = 0;
        }

        public int Current { get; private set; } = 0;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }
}
