using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello World!");
        
            double number5 = 10.4;// ondalıklı sayıları tanımlarız.
            decimal number6 = 10.4m;
            char character = 'A';
            bool condition = false;
            byte number4 = 255;//8 bit veri tutar.
            short number3 = 32767; //16 bit yer tutar
            int number1 = 2147483647;// 32 bit yer tutar 
            long number2 = 9223372036854775807;//long int 2 katı veri tutar. 64 bit yer kaplar.
            var number7 = 10;
            number7 = 'A';
            // number7 = "A";
            Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number7 is {0}", number7);
            Console.WriteLine("Character is {0}", (int)character);
            Console.WriteLine((int)Days.Friday);
            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }
}
