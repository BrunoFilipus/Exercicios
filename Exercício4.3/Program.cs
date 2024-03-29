namespace Exercício4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inicio = 0;
            ++inicio;
            do
            {
                if (inicio % 3 == 0)
                {
                    Console.Write("Fizz, ");
                }
                else if (inicio % 5 == 0 && inicio != 100)
                {
                    Console.Write("Buzz, ");
                }
                else if (inicio % 3 == 0 && inicio % 5 == 0)
                {
                    Console.Write("FizzBuzz, ");
                }
                else if (inicio == 100 && inicio % 5 == 0)
                {
                    Console.Write("Buzz.");
                    break;
                }
                else
                {
                    Console.Write($"{inicio}, ");
                }
                ++inicio;
            } while (inicio <= 100);
        }
    }
}
