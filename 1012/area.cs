using System;
using System.Globalization;
namespace curso
{
    class program
    {
        static void Main(string[] argos)
        {
            double a, b, c, triangulo, circulo, trapezio, quadrado, retangulo;

            string[] vet;

            vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            triangulo = a * c / 2;
            circulo = 3.14159 * Math.Pow(c, 2);
            trapezio = (a + b) / 2 * c;
            quadrado = Math.Pow(b, 2);
            retangulo = a * b;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3"));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3"));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3"));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3"));

        }
    }
}
