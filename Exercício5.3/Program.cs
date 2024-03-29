namespace Exercício5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numerador = 1;
            int resultado;
            do
            {
                for (int i = 1; i <= 10; i++)
                {
                    resultado = i * numerador;
                    Console.WriteLine($"{numerador}x{i}={resultado}");
                }
                numerador++;
                Console.WriteLine();
            } while (numerador <= 10);
        }
    }
}
