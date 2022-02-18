using System;
using System.Globalization;
class URI
{
    static void Main(string[] args)
    {
        int km;
        double lt, total;
        km = int.Parse(Console.ReadLine());
        lt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        total = km / lt;
        Console.WriteLine(total.ToString("F3") + " km/l");

        

    }
}
