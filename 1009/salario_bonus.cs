using System;
using System.Globalization;
class URI
{

    static void Main(string[] args) {
        string nome;
        double salario, vendas, total, porcentagem;

        nome = (Console.ReadLine());
        salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) ;
        porcentagem = 15.0 / 100.0;

        total = salario + (porcentagem * vendas);

        Console.WriteLine("TOTAL = R$ " + total.ToString("F2"));   
    }
}