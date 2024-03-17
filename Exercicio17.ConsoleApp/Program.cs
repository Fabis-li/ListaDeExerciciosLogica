namespace Exercicio17.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Calcular se a soma de dois numeros e maior que o terceiro\n");

                Console.WriteLine("Digite um valor para A");
                int A = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite um valor para B");
                int B = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite um valor para C");
                int C = Convert.ToInt32(Console.ReadLine());

                int somaAeB = A + B;

                if(C < somaAeB)
                {
                    Console.WriteLine("A soma de A + B é : " + somaAeB + "\n");
                }
                else
                {
                    Console.WriteLine("A soma de A + B e maior do que C.\n");
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
