using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInOut
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine(); //Чете от конзолата. Очаква текст.
            
            Console.WriteLine("Hello "+name);

            char z = 'z';
            Console.WriteLine((int)z);
            Console.WriteLine(Convert.ToString(z));// нещо изтървах. трябва да изкара двоичен код на символа "z".
          }
    }
}
