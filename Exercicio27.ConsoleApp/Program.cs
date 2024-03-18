namespace Exercicio27.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("FizzBuzz");
                Console.WriteLine("Imprimindo números na tela");

                int inicial = 1;
                int limite = 100;

                while(inicial<=limite)
                {
                    //Console.WriteLine(inicial);
                    //inicial++;
                    if(inicial % 3 == 0 && inicial % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if ( inicial % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (inicial % 5 == 0)
                    {
                        Console.WriteLine("Buzz");

                    }
                    else
                    {
                        Console.WriteLine(inicial);
                    }
                    inicial++;
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
