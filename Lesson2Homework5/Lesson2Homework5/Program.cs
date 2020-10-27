using System;

namespace Lesson2Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            int R = 3;
            int h = 4;
            double V = pi * (R * R) * h;
            double S = 2 * pi * R * (R + h);
            Console.WriteLine($"V={V}\t S={S}");
        }
    }
}
