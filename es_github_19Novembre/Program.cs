﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_github_19Novembre
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;
            //le due righe di codice seguenti stampano il massimo valore rappresentabile con 32 bit
            // e stampano il relativo complemento a 1 
            Console.WriteLine(a);
            Console.WriteLine(a + 1);
            int b = -128;
            int c = -b;
            Console.WriteLine(Convert.ToString(b, 2));
            Console.WriteLine(Convert.ToString(c, 2));
            int value = 31;
            int somma = value;
            value = ~value + 1; //NOT
            //value=value+1;
            somma = somma + value;
            Console.WriteLine($"{value} e {somma}");
            long number = 55555;
            Console.WriteLine(Convert.ToString(number, 2));
            short number1 = (short)number;
            Console.WriteLine(number1);
            Console.ReadLine();
        }
    }
}
