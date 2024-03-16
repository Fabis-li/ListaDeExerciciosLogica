namespace Exercicio10.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Calcular a média ponderada");

                Console.WriteLine("Digite a primeira nota do aluno");
                double nota1 = Convert.ToDouble(Console.ReadLine());

                if (nota1 < 0)
                {
                    Console.WriteLine("Digite uma nota que seja um número positivo");
                    nota1 = Convert.ToDouble(Console.ReadLine());
                }

                Console.WriteLine("Digite o peso da primeira nota");
                double peso1 = Convert.ToDouble(Console.ReadLine());

                
                 if (peso1 <= 0)
                {
                    Console.WriteLine("Digite um peso maior do que zero");
                    peso1 = Convert.ToDouble(Console.ReadLine());
                }

                Console.WriteLine("Digite a segunda nota do aluno");
                double nota2 = Convert.ToDouble(Console.ReadLine());

                if (nota2 < 0)
                {
                    Console.WriteLine("Digite uma nota que seja um número positivo");
                    nota2 = Convert.ToDouble(Console.ReadLine());
                }

                Console.WriteLine("Digite o peso da segunda nota");
                double peso2 = Convert.ToDouble(Console.ReadLine());

                if (peso2 <= 0)
                {
                    Console.WriteLine("Digite um peso maior do que zero");
                    peso2 = Convert.ToDouble(Console.ReadLine());
                }           
                
                double mediaPonderada = ((peso1 * nota1) + (peso2 * nota2)) / (peso1 + peso2);

                Console.WriteLine("A média ponderada do aluno é : " + mediaPonderada);

                Console.WriteLine("Digite S para sair e N para voltar ao inicio");

                String sair = Console.ReadLine();

                if (sair == "S")
                {

                    break;

                }
                if (sair == "N")
                {
                    Console.Clear();
                    continue;
                }

            }
        }
    }
}
