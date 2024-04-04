using System;

namespace Exercício5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal provaUm, pesoProvaUm, notaUm, provaDois, pesoProvaDois, notaDois, notaFinal;
            
            Console.Write("Digite a nota da primeira prova: ");
            provaUm = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite o peso da primeira prova: ");
            pesoProvaUm = Convert.ToDecimal(Console.ReadLine());
            notaUm = provaUm * pesoProvaUm;
            Console.Write("Digite a nota da segunda prova: ");
            provaDois = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite o peso da segunda prova: ");
            pesoProvaDois = Convert.ToDecimal(Console.ReadLine());
            notaDois = provaDois * pesoProvaDois;

            notaFinal = notaUm + notaDois;
            Console.WriteLine($"A média ponderada do aluno é: {notaFinal}");
        }
    }
}
