﻿using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            double radio, area;
            radio = Convert.ToDouble(Console.ReadLine());
            area = 3.14159 * (radio * radio);
            Console.WriteLine("A=" + area.ToString("0.0000"));
            Console.ReadKey();
        }
    }
}

