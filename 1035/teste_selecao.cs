using System;
class Program
{
    static void Main(string[] args)
    {
        string [] vet = Console.ReadLine().Split(' ');
        int a, b, c, d;
        a = int.Parse(vet[0]);
        b = int.Parse(vet[1]);
        c = int.Parse(vet[2]);
        d = int.Parse(vet[3]);

        if (a / 2 == 0 || b > c && d > a || (c + d) > (a + b + c + d)){
              Console.WriteLine("Valores aceitos");
        }
        else
        {
            Console.WriteLine("Valores nao aceitos");
        }
    }
}