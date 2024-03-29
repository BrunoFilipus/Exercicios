namespace Exercício1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double alturaCaixa;
            double larguraCaixa;
            double comprimentoCaixa;
            double volumeCaixa;

            Console.Write("Digite a altura da caixa: ");
            alturaCaixa = Convert.ToDouble(Console.ReadLine());
            Console.Write("Agora digite a largura da caixa: ");
            larguraCaixa = Convert.ToDouble(Console.ReadLine());
            Console.Write("Por fim, digite o comprimento da caixa: ");
            comprimentoCaixa = Convert.ToDouble(Console.ReadLine());

            volumeCaixa = alturaCaixa * larguraCaixa * comprimentoCaixa;
            Console.WriteLine($"O volume da caixa é {volumeCaixa} unidades cúbicas.");
        }
    }
}
