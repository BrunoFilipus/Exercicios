namespace Exercício3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal quilometragemInicial, quilometragemFinal, consumoCombustivel, consumoQuilometragem;
            
            Console.Write("Digite a quilometragem inicial: ");
            quilometragemInicial = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite a quilometragem final: ");
            quilometragemFinal = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite o consumo de combustível: ");
            consumoCombustivel = Convert.ToDecimal(Console.ReadLine());

            consumoQuilometragem = consumoCombustivel / (quilometragemFinal - quilometragemInicial);
            Console.WriteLine($"O consumo de combustível por quilômetro é de {consumoQuilometragem} litros/km.");
        }
    }
}
