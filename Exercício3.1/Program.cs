namespace Exercício3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double quilometragemInicial;
            double quilometragemFinal;
            double consumoCombustivel;
            double consumoQuilometragem;

            Console.Write("Digite a quilometragem inicial: ");
            quilometragemInicial = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a quilometragem final: ");
            quilometragemFinal = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o consumo de combustível: ");
            consumoCombustivel = Convert.ToDouble(Console.ReadLine());

            consumoQuilometragem = consumoCombustivel / (quilometragemFinal - quilometragemInicial);
            Console.WriteLine($"O consumo de combustível por quilômetro é de {consumoQuilometragem} litros/km.");
        }
    }
}
