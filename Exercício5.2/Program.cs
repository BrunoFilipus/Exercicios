namespace Exercício5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeiroNumero, segundoNumero, resultado, operacao;
            
            Console.Write("Digite o primeiro número: ");
            primeiroNumero = Convert.ToInt16(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            segundoNumero = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Qual operação deseja realizar? (0 para +) (1 para -) (2 para *) (3 para /) (4 para sair)");
            operacao = Convert.ToInt16(Console.ReadLine());

            switch (operacao)
            {
                case 0:
                    resultado = primeiroNumero + segundoNumero;
                    Console.WriteLine($"Resultado: {primeiroNumero} + {segundoNumero} = {resultado}");
                    break;

                case 1:
                    resultado = primeiroNumero - segundoNumero;
                    Console.WriteLine($"Resultado: {primeiroNumero} - {segundoNumero} = {resultado}");
                    break;

                case 2:
                    resultado = primeiroNumero * segundoNumero;
                    Console.WriteLine($"Resultado: {primeiroNumero} * {segundoNumero} = {resultado}");
                    break;

                case 3:
                    resultado = primeiroNumero / segundoNumero;
                    Console.WriteLine($"Resultado: {primeiroNumero} / {segundoNumero} = {resultado}");
                    break;

                case 4: break;
            }
        }
    }
}
