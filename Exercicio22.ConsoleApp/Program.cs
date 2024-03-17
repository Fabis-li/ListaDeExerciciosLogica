namespace Exercicio22.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Programa escreve os números ímpares de 100 à 200");

                int numero = 100;
                int resultado = 0;
               
                while(numero < 200)
                {
                    resultado = numero % 2;
                    if(resultado != 0)
                    {
                        Console.WriteLine(numero);
                        numero++;
                    }
                    else
                    {
                        numero++;
                    }

                }                

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
