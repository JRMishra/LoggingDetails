using System;
using NLog;

namespace NLogProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logging Program");

            AddNumber sumOfTwo = new AddNumber();
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int ans = sumOfTwo.Sum(a, b);
            Console.WriteLine("sum : "+ans);

            return;
        }
    }
}
