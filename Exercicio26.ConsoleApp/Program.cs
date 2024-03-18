namespace Exercicio26.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Imprimir a sequência Fibonacci");

                Console.WriteLine("Digite um número");
                int numero = Convert.ToInt32(Console.ReadLine());

                int primeiroNumero = 0;
                int segundoNumero = 1;
                int terceiroNumero = 0;

                Console.WriteLine(", " + segundoNumero);

                while(terceiroNumero <= numero)
                {
                    terceiroNumero = primeiroNumero + segundoNumero;

                    if(terceiroNumero <= numero)
                    {
                        Console.WriteLine(", " +  terceiroNumero);
                    }
                    primeiroNumero = segundoNumero;
                    segundoNumero = terceiroNumero;
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
