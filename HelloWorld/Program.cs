using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Asif Khan ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("Upper: '{0}'", fullName.ToUpper());
            Console.WriteLine("Lower: '{0}'", fullName.ToLower());


        }
    }
}
