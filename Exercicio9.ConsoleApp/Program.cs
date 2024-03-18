namespace Exercicio9.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular Media do aluno\n");
            Console.WriteLine("Digite a nota do aluno");
            double nota = Convert.ToDouble(Console.ReadLine());
                

            double notas = nota;
            double qtdeNotas = 0;
            double resultado = 0;

            while (true)
            {
                Console.WriteLine("Deseja digitar mais uma nota? (s/n)");
                string digitarMaisNotas = Console.ReadLine();
                qtdeNotas++;
                
                while(digitarMaisNotas == "s" )
                {
                    Console.WriteLine("Digite a nota do aluno");
                    double novaNota = Convert.ToDouble(Console.ReadLine());
                    notas += novaNota;
                    qtdeNotas += 1;
                    Console.WriteLine("Digitar mais notas? (s/n)");
                    digitarMaisNotas = Console.ReadLine();

                }                

                if(digitarMaisNotas == "n" && qtdeNotas > 0)
                {
                    resultado = notas / qtdeNotas;
                    Console.WriteLine(resultado);
                    //break;
                }

               // if(qtdeNotas > 0)
                //{
                //}

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
