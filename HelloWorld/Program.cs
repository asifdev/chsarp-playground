using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            bool isTired = false;
            char character = 'A';
            string name = "Asif";

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(isTired);
            Console.WriteLine(character);
            Console.WriteLine(name);
            Console.WriteLine("{0} {1}", byte.MaxValue, 'B');

            //try
            //{
            //    string sales = "1234";
            //    byte b = Convert.ToByte(sales);
            //    Console.WriteLine(b);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error Found");
            //}

            var z = 10;
            var y = 3;
            Console.WriteLine(z / y);
            Console.WriteLine((float) z / (float) y);

            byte number1 = 255;

            number1 += 2;

            Console.WriteLine(number1);
            var person = new Person
            {
                FirstName = "Asif",
                LastName = "Khan"
            };
            person.Introduce();

            var numArray = new char[3] { 'a', 'b', 'c' };
            Console.WriteLine(numArray[1]);
        }
    }
}
