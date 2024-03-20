namespace Exercicio3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular volume de um cilindro\n");
            
            double raio = ObterDadosEntrada("Digite o raio da cilindro");
            
            double altura = ObterDadosEntrada("Digite a altura do cilindro");

            double volume = CalcularVolume(raio, altura);

            ExibirResultado(volume);
        }

        static double ObterDadosEntrada(string texto)
        {
            Console.WriteLine(texto);
            double numeroDigitado = Convert.ToDouble(Console.ReadLine());

            return numeroDigitado;
        }

        static double CalcularVolume(double raio, double altura)
        {
            return Math.PI * (raio * raio) * altura;
        }

        static void ExibirResultado(double volume)
        {
            Console.WriteLine("O Volume do Cilindro é: " + Math.Round(volume, 2));
            Console.ReadLine();
        }
    }
}
