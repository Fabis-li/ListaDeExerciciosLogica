namespace Exercicio2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Converter temperatura gruas Fahrenheit para graus Celsius\n");

            Console.WriteLine("Digite a temperatura em Fahrenheit");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            
            double celsisus = (fahrenheit - 32) * 5 / 9;            

            Console.WriteLine("A temperatura em convertida de Fahrenheit para Celsius é: " + celsisus + " graus");
            Console.ReadLine();

        }
    }
}
