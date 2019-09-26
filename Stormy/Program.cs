using System;

namespace Stormy
{
    class Program
    {
        static void Main(string[] args)
        {
            int windSpeed;

            windSpeed = 156;

            if( windSpeed < 74)
            {
                Console.WriteLine($"Not a hurriance with speed of {windSpeed} mph");
            }
            //else if (windSpeed < 96)
            else if (windSpeed >= 74 && windSpeed <= 95)
            {
                Console.WriteLine($"Category 1 with a speed of {windSpeed} mph");
            }
            //else if (windSpeed < 111)
            else if (windSpeed >= 96 && windSpeed <= 110)
            {
                Console.WriteLine($"Category 2 with a speed of {windSpeed} mph");
            }
            //else if (windSpeed < 131)
            else if (windSpeed >= 111 && windSpeed <= 130)
            {
                Console.WriteLine($"Category 3 with a speed of {windSpeed} mph");
            }
            //else if (windSpeed < 155)
            else if (windSpeed >= 131 && windSpeed <= 155)
            {
                Console.WriteLine($"Category 4 with a speed of {windSpeed} mph");
            }
            else 
            {
                Console.WriteLine($"Category 5 with a speed of {windSpeed} mph");
            }



        }
    }
}
