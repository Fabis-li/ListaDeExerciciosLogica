namespace Exercicio21.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Lendo 2 valores, se forem iguais soma e for diferente multiplica");
                Console.WriteLine("Digite um valor para A");
                int A = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite um valor para B");
                int B = Convert.ToInt32(Console.ReadLine());

                int soma = A + B;
                int multiplacao = A * B;
                int C = 0;

                if(A == B)
                {
                    C = soma;
                    Console.WriteLine("A e B são iguais, a soma é : " + C + " \n");
                }
                else
                {
                    C = multiplacao;
                    Console.WriteLine("A e B são diferentes, o resultado da multiplicação entre eles é : " + C + " \n");
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
