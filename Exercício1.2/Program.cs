namespace Exercício1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeiroValor;
            int segundoValor;
            int terceiroValor;
            int primeiroSegundo;

            Console.Write("Digite o primeiro número: ");
            primeiroValor = Convert.ToInt16(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            segundoValor = Convert.ToInt16(Console.ReadLine());
            Console.Write("Digite o terceiro número: ");
            terceiroValor = Convert.ToInt16(Console.ReadLine());
            primeiroSegundo = primeiroValor + segundoValor;

            if (primeiroSegundo < terceiroValor)
            {
                Console.WriteLine($"A soma de {primeiroValor} + {segundoValor} não é maior que {terceiroValor}");
            }
            else
            {
                Console.WriteLine($"A soma de {primeiroValor} + {segundoValor} é maior que {terceiroValor}");
            }
        }
    }
}
