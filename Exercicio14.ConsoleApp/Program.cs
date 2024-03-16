using System.Globalization;
using System.Runtime.CompilerServices;

namespace Exercicio14.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Calcular dias de vida\n");

                Console.WriteLine("Digite o seu nome");
                string nome = Console.ReadLine();

                if(string.IsNullOrWhiteSpace(nome))
                {
                    Console.WriteLine("Digite apenas letras");
                    Console.WriteLine("Digite o seu nome");
                    nome = Console.ReadLine();
                }                

                Console.WriteLine("Digite a sua idade");
                string idade = Console.ReadLine();

                if(!int.TryParse(idade, out _))
                {
                    Console.WriteLine("Insira uma idade válida");
                    Console.WriteLine("Digite sua idade");
                    idade = Console.ReadLine();
                }

                int diasDeVida = Convert.ToInt32(idade) * 365;

                Console.WriteLine(nome.ToUpper() + " ,VOCÊ JA VIVEU " + diasDeVida + " DIAS.\n");
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
