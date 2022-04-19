﻿using System;

namespace Trapizoidal_Rule
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            
          
            double a, b, n, h, xn = 0, Ans;
            Console.WriteLine("Please input the lower limit a");
             a = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Please input the upper limit b");
              b = Convert.ToDouble(Console.ReadLine());
              Console.WriteLine("Please input the interval");
             n= Convert.ToDouble(Console.ReadLine());

           
            h = (b - a) / n;
            Ans = Function(a) + Function(b);
            for(int i = 0; i <= n; i++)
            {
                xn = a + i*h;
                Ans += (2 * Function(xn));
            }
            Ans = Ans * (h / 2);
           
            
            Console.WriteLine($"The intregration is {Ans}");
        }
        static double Function(double x)
        {
            return (1/(1+x*x));
        }
    }
}
