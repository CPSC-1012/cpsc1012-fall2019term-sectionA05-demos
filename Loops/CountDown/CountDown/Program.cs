using System;

namespace CountDown
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write the code to count down from 10 seconds to launch off

            // You can System.Threading.Thread.Sleep(1000) 
            // to simulate pause for 1 second
            // You can Console.Beep() to make a beeping sound after each second

            // When the counter reaches zero display a message 
            // 10 9 8 7 6 5 4 3 2 1 
            /// ***** blast off *****
            // and play the C# sound for 5 seconds
            // You can play a frequencey for duration as follows:
            // Console.Beep( frequency, duration );
            // Console.Beep( 277, 1600 );

            Console.Beep(220, 1600);

        }
    }
}
