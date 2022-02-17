using System;
namespace curso
{
    class Program
    {
        static void Main(String[] argos)
        {
            int A, B, PROD;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            PROD = A * B;
            Console.WriteLine("PROD = " + PROD);
        }
    }
}