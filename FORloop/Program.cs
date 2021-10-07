using System;

namespace FORloop
{
    class Program
    {
        static void Main(string[] args)
        {
            //i will not skateboard in the halls.

            string message = "i will not skateboard in the halls.".ToUpper();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{ i+1} i will not skateboard in the halls.".ToUpper());
            }
        }
    }
}
