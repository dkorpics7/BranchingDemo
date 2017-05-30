using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //assign numbers from 1 to 100 as FIZZ if multiple of 3, BUZZ for multiples of 5, and FIZZBUZZ for multiples of both

            for (int num = 1; num<201; num++)
            {
                if (num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine("\r\n!!!!! FIZZBUZZ !!!!!");
                }
                else if (num % 3 == 0)
                {
                    Console.WriteLine("\r\n!!!!! FIZZ !!!!!");
                }
                else if (num % 5 == 0)
                {
                    Console.WriteLine("\r\n!!!!! BUZZ !!!!!");
                }
                else
                {
                    Console.WriteLine(num);
                }
            }
            Console.ReadLine();
            }
    }
}
