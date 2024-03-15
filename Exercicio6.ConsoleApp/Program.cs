namespace Exercicio6.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo para converter Celsius para Fahrenheit");
            Console.WriteLine("Digite a temperatura");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (celsius + 32) * 9 / 5;

            Console.WriteLine("A temperatura em graus Fahrenheit é: " + Math.Round(fahrenheit, 2));
            Console.ReadLine();
        }
    }
}
