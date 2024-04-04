namespace Exercício4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int salarioBase, vendas;
            double salarioFinal;

            Console.Write("Digite o valor do salário base: ");
            salarioBase = Convert.ToInt16(Console.ReadLine());
            Console.Write("Digite o valor das vendas: ");
            vendas = Convert.ToInt16(Console.ReadLine());

            salarioFinal = salarioBase + (vendas * 0.05);
            Console.WriteLine($"O salário total do vendedor é R$ {salarioFinal}.");
        }
    }
}
