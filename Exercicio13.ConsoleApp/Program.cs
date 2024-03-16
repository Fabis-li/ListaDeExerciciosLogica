namespace Exercicio13.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Calcular Vendas diarias de paes e broas\n");

                Console.WriteLine("Digite a quantidade de pães vendidos");
                decimal qtdePaes = Convert.ToDecimal(Console.ReadLine());

                if(qtdePaes < 0)
                {
                    Console.WriteLine("Digite a quantidade de pães vendidas no dia");
                    qtdePaes = Convert.ToDecimal(Console.ReadLine());
                }

                Console.WriteLine("Insira o preço do pão");
                decimal precoPao = Convert.ToDecimal(Console.ReadLine());

                if(precoPao < 0)
                {
                    Console.WriteLine("Houve um erro, favor inserir o valor correto");
                    precoPao= Convert.ToDecimal(Console.ReadLine());
                }

                Console.WriteLine("Digite a quantidade de broas vendidas");
                decimal qtdeBroas = Convert.ToDecimal(Console.ReadLine());

                if(qtdeBroas < 0)
                {
                    Console.WriteLine("Digite a quantidade de broas vendidas no dia");
                    qtdeBroas = Convert.ToDecimal(Console.ReadLine());
                }

                Console.WriteLine("Insira o preço da Broa");
                decimal precoBroa = Convert.ToDecimal(Console.ReadLine());

                if (precoBroa < 0)
                {
                    Console.WriteLine("Houve um erro, favor inserir o valor correto");
                    precoBroa = Convert.ToDecimal(Console.ReadLine());
                }
                
                decimal valorPaes = qtdePaes * precoPao;                
                decimal valorBroas = qtdeBroas * precoBroa;
                decimal arrecadacao = valorPaes + valorBroas;
                decimal poupanca = 0.1M * arrecadacao;

                Console.WriteLine("Venda total de Paes em reais R$: " + valorPaes);
                Console.WriteLine("Venda Total de Boras em reais R$: " + valorBroas);
                Console.WriteLine("A padaria teve uma arrecadação de : R$ " + Math.Round(arrecadacao, 2).ToString("C"));
                Console.WriteLine("O valor à guardar na poupança é de : R$ " + poupanca.ToString("C") + "\n");

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
