namespace Exercício2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int final = 1;

            Console.Write("Digite um número para calcular seu fatorial: ");
            int numero = Convert.ToInt16(Console.ReadLine());

            for (int i = numero; i > 0; --i)
            {
                final *= i;
            }

            Console.WriteLine($"{numero}! = {final}");
        }
    }
}
