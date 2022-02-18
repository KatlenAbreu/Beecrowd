using System;

class URI
{

    static void Main(string[] args)
    {
        double raio, volume;
       
        raio = double.Parse(Console.ReadLine());
        volume = 4.0 * Math.PI * Math.Pow (raio, 3.0) /3 ;
        Console.WriteLine("VOLUME = " + volume.ToString("0.000"));


    }
    
}
