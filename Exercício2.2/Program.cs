namespace Exercício2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, troca;

            Console.Write("Digite o primeiro número: ");
            A = Convert.ToInt16(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            B = Convert.ToInt16(Console.ReadLine());
            Console.Write("Digite o terceiro número: ");
            C = Convert.ToInt16(Console.ReadLine());

            if (A < B)
            {
                troca = A;
                A = B;
                B = troca;
            }
            if (A < C)
            {
                troca = C;
                C = A;
                A = troca;
            }
            if (B < C)
            {
                troca = C;
                C = B;
                B = troca;
            }
            Console.WriteLine($"{A}, {B}, {C}.");
        }
    }
}
