namespace Exercício6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int comprimentoTerreno;
            int larguraTerreno;
            int areaTerreno;

            Console.WriteLine("Digite o comprimento do terreno (em metros): ");
            comprimentoTerreno = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite a largura do terreno (em metros): ");
            larguraTerreno = Convert.ToInt16(Console.ReadLine());

            areaTerreno = comprimentoTerreno * larguraTerreno;
            Console.WriteLine($"A área do terreno é de {areaTerreno} metros quadrados.");
        }
    }
}
