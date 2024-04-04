namespace Exercício3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeiro = 0, segundo = 1, troca;

            Console.Write("Digite um limite para a sequência: ");
            int limite = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; primeiro <= limite; i++)
            {
                Console.Write($"{primeiro}, ");
                troca = segundo;
                segundo += primeiro;
                primeiro = troca;
            }
        }
    }
}
