using System;

namespace Exercício5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double provaUm;
            double notaUm;
            double provaDois;
            double notaDois;
            double notaFinal;

            Console.Write("Digite a nota da primeira prova: ");
            provaUm = Convert.ToDouble(Console.ReadLine());
            notaUm = provaUm * 0.4;
            Console.Write("Digite a nota da segunda prova: ");
            provaDois = Convert.ToDouble(Console.ReadLine());
            notaDois = provaDois * 0.6;

            notaFinal = notaUm + notaDois;
            Console.WriteLine($"A média ponderada do aluno é: {notaFinal}");
        }
    }
}
