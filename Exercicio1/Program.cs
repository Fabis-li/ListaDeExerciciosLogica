namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Calcular o volume de uma caixa retangular\n");

                double comprimento = ObterNumeroDouble("Digite um comprimento");

                double largura = ObterNumeroDouble("Digite uma largura");

                double altura = ObterNumeroDouble("Digite um altura");

                double volume = CalcularVolume(comprimento, largura, altura);

                ExibirResultado(volume);

               string opcao = MenuSair();

                if (OpcaoSelecionada(opcao));
                {
                    break;
                }
                if (OpcaoContinuar(opcao)) ;
                {
                    Console.Clear();
                    continue;
                }

            }

            static double ObterNumeroDouble(string texto)
            {
                Console.WriteLine(texto);

                double numeroDigitado = Convert.ToDouble(Console.ReadLine());

                return numeroDigitado;
            }

            static double CalcularVolume(double comprimento, double largura, double altura)
            {
                return comprimento * largura * altura;
            }

            static void ExibirResultado(double volume)
            {
                Console.WriteLine("O volume da caixa retangular é: " + volume);
                Console.ReadLine();
            }

            static string MenuSair()
            {
                Console.WriteLine("Digite S para sair e N para voltar ao inicio");
                string opcao = Console.ReadLine();
                return opcao;
            }

            static bool OpcaoSelecionada(string opcao)
            {
                bool opcaoSelecionada = opcao == "S" || opcao == "s";
                return opcaoSelecionada;
            }

            static bool OpcaoContinuar(string opcao)
            {
                bool opcaoSelecionada = opcao == "N" || opcao == "s";                
                return opcaoSelecionada;
            }
        }        
    }
}
