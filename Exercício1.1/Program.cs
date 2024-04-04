namespace Exercício1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal alturaCaixa, larguraCaixa, comprimentoCaixa, volumeCaixa;
            
            Console.Write("Digite a altura da caixa: ");
            alturaCaixa = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Agora digite a largura da caixa: ");
            larguraCaixa = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Por fim, digite o comprimento da caixa: ");
            comprimentoCaixa = Convert.ToDecimal(Console.ReadLine());

            volumeCaixa = alturaCaixa * larguraCaixa * comprimentoCaixa;
            Console.WriteLine($"O volume da caixa é {volumeCaixa} unidades cúbicas.");
        }
    }
}
