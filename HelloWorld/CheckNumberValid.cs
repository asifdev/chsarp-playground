using System;

namespace HelloWorld
{
    public class ChackNumberValid
    {
        public void validity()
        {
            var input = Convert.ToInt32(Console.ReadLine());
           
            if (input <= 10) {
                Console.WriteLine("Valid!");
            }
            else
            {
                Console.WriteLine("Invalid!");
            }
            
        }

        public void findMax()
        {
            Console.WriteLine("Enter first number:");
            var firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            var secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else
            {
                Console.WriteLine(secondNumber);
            }
        }

        public void checkDimension()
        {
            Console.WriteLine("Enter Length:");
            var length = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Width");
            var width = int.Parse(Console.ReadLine());

            if (length > width)
            {
                Console.WriteLine("Potrait");
            }
            else
            {
                Console.WriteLine("Landscape");
            }
        }
    }
}
