using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Array
            var array = new[] { 1, 6, 3, 4, 5, 2 };

            //Length
            Console.WriteLine(array.Length);
            Console.WriteLine(Array.IndexOf(array, 3));


            Array.Clear(array, 0, 2);
            Array.Reverse(array);
            Array.Sort(array);
            var arrayClone = new int[5];

            Array.Copy(array, arrayClone, 5);


            foreach (var elem in arrayClone)
            {
                Console.WriteLine(elem);
            }
            */

            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach(var num in numbers)
            {
                Console.WriteLine(num);
            }

            var now = DateTime.Now;
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());


        }
    }
}
