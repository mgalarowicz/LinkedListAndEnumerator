using System;

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
        }
    }
}
