namespace Exercicio5.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo do volumo da esfera");
            Console.WriteLine("Informe o tamanho do raio");
            double raio = Convert.ToDouble(Console.ReadLine());

            double PI = 3.14;

            double volume = 4 / 3 * PI * raio;

            Console.WriteLine("O volume da esfera é : " + Math.Round(volume,2));
            Console.ReadLine();
        }
    }
}
