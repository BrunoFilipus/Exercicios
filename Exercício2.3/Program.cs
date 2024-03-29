namespace Exercício2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int resultado = 1;

            Console.Write("Digite o número para calcular seu fatorial: ");
            numero = Convert.ToInt16(Console.ReadLine());
            int fatorial = numero;

            do
            {
                resultado *= numero;
                numero--;
            } while (numero >= 2);

            Console.WriteLine($"O resultado de {fatorial}! é = {resultado}.");
        }
    }
}
