namespace Exercicio18.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Ordenar valores decrescente\n");

                Console.WriteLine("Digite o primeiro valor");
                int valor1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o segundo valor");
                int valor2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o terceiro valor");
                int valor3 = Convert.ToInt32(Console.ReadLine());                

                if(valor2 == valor1 || valor2 == valor3)
                {
                    Console.WriteLine("Digite o segundo valor");
                    valor2 = Convert.ToInt32(Console.ReadLine());
                }
                if(valor3 == valor1)
                {
                    Console.WriteLine("Digite o terceiro valor");
                    valor3 = Convert.ToInt32(Console.ReadLine());
                }

                int maior, meio, menor;

                if (valor1 > valor2 && valor1 > valor3)
                {
                    maior = valor1;
                    meio = (valor2 > valor3) ? valor2 : valor3;
                    menor = (valor2 < valor3) ? valor2 : valor3;
                }
                else if(valor2 > valor1 && valor2 > valor3)
                {
                    maior = valor2;
                    meio = (valor1 > valor3) ? valor1 : valor3;
                    menor = (valor1 < valor3) ? valor1 : valor3;
                }
                else
                {
                    maior = valor3;
                    meio = (valor1 > valor2) ? valor1 : valor2;
                    menor = (valor1 < valor2) ? valor1 : valor2;
                }

                Console.WriteLine("Os valores em ordem decrescente: " + maior +  ", " + meio+ ", " + menor + "\n");

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
