namespace Exercicio12.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Calcular a área de um terreno\n");

                Console.WriteLine("Digite o comprimento do terreno");
                decimal comprimento = Convert.ToDecimal(Console.ReadLine());

                if(comprimento <= 0)
                {
                    Console.WriteLine("Digite um comprimento maior do zero");
                    comprimento = Convert.ToDecimal(Console.ReadLine());
                }

                Console.WriteLine("Digite a largura do terreno");
                decimal largura = Convert.ToDecimal(Console.ReadLine());

                if(largura <= 0)
                {
                    Console.WriteLine("Digite uma largura maior do que zero");
                    largura = Convert.ToDecimal(Console.ReadLine());
                }

                decimal areaDoTerreno = comprimento * largura;

                Console.WriteLine("A área do terreno é : " + areaDoTerreno.ToString("N") + " metros");

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

            }
        }
    }
}
