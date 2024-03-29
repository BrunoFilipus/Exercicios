namespace Exercício2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double farenheitTemp;
            double celsiusTemp;

            Console.Write("Digite a temperatura em Fahrenheit: ");
            farenheitTemp = Convert.ToDouble(Console.ReadLine());

            celsiusTemp = (farenheitTemp - 32) * 5 / 9;
            Console.WriteLine($"A temperatura em Celsius é: {celsiusTemp}");
        }
    }
}
