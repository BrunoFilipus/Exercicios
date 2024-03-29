namespace Exercício2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeiroValor;
            int segundoValor;
            int terceiroValor;

            Console.Write("Digite o primeiro número: ");
            primeiroValor = Convert.ToInt16(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            segundoValor = Convert.ToInt16(Console.ReadLine());
            Console.Write("Digite o terceiro número: ");
            terceiroValor = Convert.ToInt16(Console.ReadLine());

            if (primeiroValor > segundoValor && primeiroValor > terceiroValor && segundoValor > terceiroValor)
            {
                Console.WriteLine($"Os números em ordem decrescente são: {primeiroValor}, {segundoValor} e {terceiroValor}");
            }
            else if (primeiroValor > segundoValor && primeiroValor > terceiroValor && segundoValor < terceiroValor)
            {
                Console.WriteLine($"Os números em ordem decrescente são: {primeiroValor}, {terceiroValor} e {segundoValor}");
            }
            else if (primeiroValor < segundoValor && primeiroValor > terceiroValor)
            {
                Console.WriteLine($"Os números em ordem decrescente são: {segundoValor}, {primeiroValor} e {terceiroValor}");
            }
            else if (primeiroValor < segundoValor && primeiroValor < terceiroValor && segundoValor > terceiroValor)
            {
                Console.WriteLine($"Os números em ordem decrescente são: {segundoValor}, {terceiroValor} e {primeiroValor}");
            }
            else if (primeiroValor < segundoValor && primeiroValor < terceiroValor && segundoValor < terceiroValor)
            {
                Console.WriteLine($"Os números em ordem decrescente são: {terceiroValor}, {segundoValor} e {primeiroValor}");
            }
            else
            {
                Console.WriteLine($"Os números em ordem decrescente são: {terceiroValor}, {primeiroValor} e {segundoValor}");
            }
        }
    }
}
