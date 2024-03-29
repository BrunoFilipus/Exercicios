namespace Exercício3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limite;
            int resultado = 1;
            int primeiroNumero = 0;
            int segundoNumero = 1;

            Console.Write("Digite o limite para a sequência de Fibonacci: ");
            limite = Convert.ToInt16(Console.ReadLine());
            Console.Write("0, ");

            do
            {
                if (resultado == limite)
                {
                    Console.WriteLine($"{resultado}.");
                    break;
                }
                Console.Write($"{resultado}, ");
                resultado = primeiroNumero + segundoNumero;
                primeiroNumero = segundoNumero;
                segundoNumero = resultado;

            } while (resultado <= limite);
        }
    }
}
