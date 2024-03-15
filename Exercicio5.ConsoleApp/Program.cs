namespace Exercicio5.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Calculo do volumo da esfera");

                Console.WriteLine("Informe o tamanho do raio");
                double raio = Convert.ToDouble(Console.ReadLine());

                double PI = 3.14;

                double volume = 4 / 3 * PI * (raio * raio * raio);

                Console.WriteLine("O volume da esfera é : " + Math.Round(volume,2));
                Console.WriteLine("Digite S para sair e N para voltar ao inicio");

                String sair = Console.ReadLine();

                if (sair == "S")
                {

                    break;

                }
                if (sair == "N")
                {

                    continue;
                }

                Console.ReadLine();
            }
        }
    }
}
