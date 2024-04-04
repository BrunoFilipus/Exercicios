namespace Exercício3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, imc;

            Console.Write("Digite o seu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a sua altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            imc = peso / (altura * 2);

            string saida = imc < 18.5 ? "Magreza" : imc < 24.9 ? "Normal" : imc < 29.9 ? "Sobrepeso" : imc < 39.9 ? "Obesidade" : "Obesidade grave";

            Console.WriteLine($"IMC = {imc} ({saida}).");
        }
    }
}
