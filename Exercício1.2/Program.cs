namespace Exercício1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;

            Console.Write("Digite o primeiro número: ");
            A = Convert.ToInt16(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            B = Convert.ToInt16(Console.ReadLine());
            Console.Write("Digite o terceiro número: ");
            C = Convert.ToInt16(Console.ReadLine());

            string resultado = A + B > C ? "A + B é maior que C" : "A + B é menor que C";
            Console.Write(resultado);
        }
    }
}
