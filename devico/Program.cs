using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devico
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int temp = -52; /*rand.Next(-100, 100);*/

            switch (temp)
            {
                case int n when (n <= -50  || n <= -1):
                    Console.WriteLine("It’s super cold today. Be sure you dressed well!");
                    break;
                case int n when (n <= -0 || n <= 10):
                    Console.WriteLine("It’s windy outside, but we are sure you will enjoy your day!");
                    break;
                case int n when (n <= 11 || n <= 30):
                    Console.WriteLine("It’s time for the outdoor walking!");
                    break;
                default:
                    Console.WriteLine("Please re-check results in 5 mins.");
                    break;
            }
        }
    }
}
