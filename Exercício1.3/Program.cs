namespace Exercício1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i < 200; i++)
            {
                if (i == 198)
                {
                    Console.Write($"{++i}.");
                    break;
                }
                Console.Write($"{++i}, ");
            }
        }
    }
}
