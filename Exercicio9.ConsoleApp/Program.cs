namespace Exercicio9.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular Media do aluno\n");
            Console.WriteLine("Digite a nota do aluno");
            double nota = Convert.ToDouble(Console.ReadLine());
                

            double notas = 0;
            double qtdeNotas = 0;
            double resultado = 0;

            while (true)
            {

                Console.WriteLine("Deseja digitar mais uma nota? (s/n)");
                string digitarMaisNotas = Console.ReadLine();
                qtdeNotas++;
                

                if(digitarMaisNotas == "s")
                {                   
                    Console.WriteLine("Digite a nota do aluno");
                    double novaNota = Convert.ToDouble(Console.ReadLine());
                    notas = nota + novaNota;
                    qtdeNotas++;                    
                    
                }

                if(digitarMaisNotas == "n")
                {
                    break;
                }

                if(qtdeNotas > 0)
                {
                    resultado = notas / qtdeNotas;
                    Console.WriteLine(resultado);
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
