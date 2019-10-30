using System;
namespace HelloWorld
{
    public class speedLimitCheck
    {
        public void checkLimit()
        {
            const int speedLimit = 60;
                Console.WriteLine("Enter speed");
            var speed = int.Parse(Console.ReadLine());

            if (speed < speedLimit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                var demeritPoint = (speed - speedLimit) / 5;

                if (demeritPoint > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine("{0} demerit points", demeritPoint);
                }
            }
        }
    }
}
