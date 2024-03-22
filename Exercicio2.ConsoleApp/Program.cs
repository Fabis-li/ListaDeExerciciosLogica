namespace Exercicio2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Converter temperatura gruas Fahrenheit para graus Celsius\n");

            double fahrenheit = ObterFahrenheit("Digite a temperatura em Fahrenheit");

            double celsisus = CalculoCelsius(fahrenheit);

            ExibirResultado(celsisus);
        }


        static double ObterFahrenheit(string texto)
        {
            Console.WriteLine(texto);
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            return fahrenheit;
        }

        static double CalculoCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
        static void ExibirResultado(double celsisus)
        {
            Console.WriteLine("A temperatura em convertida de Fahrenheit para Celsius é: " + Math.Round(celsisus,1) + " graus");
            Console.ReadLine();
        }
    }
}
