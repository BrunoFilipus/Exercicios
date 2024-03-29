namespace Exercício1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inicio = 100;

            do
            {
                inicio++;
                Console.Write($"{inicio}, ");
                inicio++;

                if (inicio == 198)
                {
                    inicio++;
                    Console.Write($"{inicio}.");
                    break;
                }
            } while (inicio < 200);
        }
    }
}
