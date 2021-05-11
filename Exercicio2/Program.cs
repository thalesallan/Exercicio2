using System;
using System.Globalization;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa PrimeiroFuncionario, SegundoFuncionario;
            PrimeiroFuncionario = new Pessoa();
            SegundoFuncionario = new Pessoa();

            Console.WriteLine("Dados do Primeiro Funcionario:");
            Console.Write("Nome: ");
            PrimeiroFuncionario.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            PrimeiroFuncionario.Salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Dados do Segundo Funcionario");
            Console.Write("Nome: ");
            SegundoFuncionario.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            SegundoFuncionario.Salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("---------------------------------");
            float MediaSalarial;
            MediaSalarial = (PrimeiroFuncionario.Salario + SegundoFuncionario.Salario) / 2;
            Console.WriteLine("Salário Médio = " + MediaSalarial.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
