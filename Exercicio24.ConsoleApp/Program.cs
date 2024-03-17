namespace Exercicio24.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Tabuada\n");

                Console.WriteLine("Digite um numero entre 1 e 10");
                int n = Convert.ToInt32(Console.ReadLine());

                if(n < 0 || n > 10)
                {
                    Console.WriteLine("Digite um número entre 1 e 10");
                    n = Convert.ToInt32(Console.ReadLine());
                }

                int contador = 0;
                int resultado = 0;

                while( contador <= 10)
                {
                    resultado = contador * n;
                    Console.WriteLine(contador + " x " + n + " = " + resultado);                    
                    contador++;
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
