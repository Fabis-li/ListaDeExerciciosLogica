namespace Exercicio4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de consumo de combustivel por Km");
            Console.WriteLine("Informe a kilometragem inicial");
            decimal kmInicial = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe a Kilometragem final");
            decimal kmFinal = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe o consumo de combustivel");
            decimal consumoCombustivel = Convert.ToDecimal(Console.ReadLine());

            decimal consumoPorKm = (kmFinal - kmInicial) / consumoCombustivel;

            Console.WriteLine("O consumo de combustivel por km è : " + consumoPorKm + " litros por km rodado");
        }
    }
}
