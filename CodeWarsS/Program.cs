using StringUtility;
using System;

namespace CodeWarsS
{
    class Program
    {
        static void Main(string[] args)
        {
            string v = Converter.CreatePhoneNumber(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 });
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
