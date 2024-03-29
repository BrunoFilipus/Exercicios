namespace Exercício3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso;
            double altura;
            double imc;

            Console.Write("Digite seu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite sua altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            imc = peso / (altura * 2);

            if (imc < 18.5)
            {
                Console.WriteLine($"Seu IMC é {imc} e está classificado como magreza.");
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine($"Seu IMC é {imc} e está classificado como normal.");
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine($"Seu IMC é {imc} e está classificado como sobrepeso.");
            }
            else if (imc >= 30 && imc <= 39.9)
            {
                Console.WriteLine($"Seu IMC é {imc} e está classificado como obesidade.");
            }
            else
            {
                Console.WriteLine($"Seu IMC é {imc} e está classificado como obseidade grave.");
            }
        }
    }
}
