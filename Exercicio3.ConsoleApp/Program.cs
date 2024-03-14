namespace Exercicio3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular volume de um cilindro\n");

            Console.WriteLine("Digite o raio da cilindro");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a altura do cilindro");
            double altura = Convert.ToDouble(Console.ReadLine());

            double PI = 3.14;

            double volume = PI * (raio * raio) * altura;

            Console.WriteLine("O Volume do Cilindro é: " + Math.Round(volume,2));  
            Console.ReadLine();
        }
    }
}
