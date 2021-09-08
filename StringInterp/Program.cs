using System;

namespace StringInterp
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = DateTime.Now;
            // 1.January 22, 2019
            System.Console.WriteLine($"1.{d:MMMM} {d:dd}, {d:yyyy}");
            // 2.2019.01.22
            System.Console.WriteLine($"2.{d:yyyy}.{d:MM}.{d:dd}");
            // 3.Day 22 of January, 2019
            System.Console.WriteLine($"3.Day {d:dd} of {d:MMMM}, {d:yyyy}");
            // 4.Year: 2019, Month: 01, Day: 22
            System.Console.WriteLine($"4.Year:{d:yyyy},Month:{d:MM},Day:{d:dd}");
            // 5.            Tuesday (10 spaces)
            System.Console.WriteLine($"5.          {d:dddd}");
            // 6.     11:01 PM             Tuesday (3 spaces before, 10 spaces between)
            System.Console.WriteLine($"6.   {d:hh}:{d:mm} {d:tt}          {d:dddd}");
            // 7.h:11, m:01, s:27
            System.Console.WriteLine($"7.h:{d:hh}, m:{d:mm}, s:{d:ss}");
            // 8.2019.01.22.11.01.27
            System.Console.WriteLine($"8.{d:yyyy}.{d:MM}.{d:dd}.{d:hh}.{d:mm}.{d:ss}");

            var pi = Math.PI;
            System.Console.WriteLine($"1.{pi:C}");
            System.Console.WriteLine($"2.{pi,10:N3}");
        }
    }
}
