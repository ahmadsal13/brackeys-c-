﻿using System;

namespace brackeys_c_
{
    class Program
    {
        static void Main(string[] args)
        {
          int num01;
          int num02;

          Console.Write("Input a number: ");
          num01 = Convert.ToInt32( Console.ReadLine());

          Console.Write("Input a number: ");
          num02 = Convert.ToInt32( Console.ReadLine());

          int result = num01 * num02;
          Console.WriteLine("The result is " + result);
            // Wait before closing 
            Console.ReadKey();
        }
    }
}