namespace Exercicio23.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Somar os numeros ímpares que são multiplos de 3\n");

                int numero = 1;
                int soma = 0;

                while(numero < 500)
                {                    
                    if(numero % 2 != 0 && numero % 3 == 0)
                    {
                        Console.WriteLine(soma);
                        soma += numero;
                    }
                    numero++;                 
                }
               
                Console.ReadLine(); 

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
