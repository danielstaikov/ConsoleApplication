using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 10;
            int result = number1 * number2;
            Console.WriteLine("Multiplied = " + result); // няколко начина на изписване на оператора
            Console.WriteLine($"Multiplied = {result}");
            Console.WriteLine("Multiplied = {0}",result); // след "Multiplied" със запетая, може да има изброени много променливи и в скобите указваш, коя променлива да изкара на екрана.
        }
    }
}
