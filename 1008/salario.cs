using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        int funcionario, hours;
        double salary, total;

        funcionario = int.Parse(Console.ReadLine());
        hours = int.Parse(Console.ReadLine());
        salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        total = hours * salary; 

        Console.WriteLine("NUMBER = " + funcionario);
        Console.WriteLine("SALARY = U$ " + total.ToString("F2"));




    }

}