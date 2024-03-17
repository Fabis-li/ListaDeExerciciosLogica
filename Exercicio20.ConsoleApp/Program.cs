namespace Exercicio20.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Par ou Ímpar\n");
                Console.WriteLine("Digite um número");
                int numero = Convert.ToInt32(Console.ReadLine());

                int resto = numero % 2;

                if(resto == 0 )
                {
                    Console.WriteLine("O número digita é par.\n");
                }
                else
                {
                    Console.WriteLine("O número digitado é ímpar.\n");
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
