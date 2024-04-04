namespace Exercício2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal farenheitTemp, celsiusTemp;
            
            Console.Write("Digite a temperatura em Fahrenheit: ");
            farenheitTemp = Convert.ToDecimal(Console.ReadLine());

            celsiusTemp = (farenheitTemp - 32) * 5 / 9;
            Console.WriteLine($"A temperatura em Celsius é: {celsiusTemp} Cº.");
        }
    }
}
