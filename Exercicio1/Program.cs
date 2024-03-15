namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Calcular o volume de uma caixa retangular\n");
            
                Console.WriteLine("Digite um comprimento");
                double comprimento = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a largura");
                double largura = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a altura");
                double altura = Convert.ToDouble(Console.ReadLine());

                double volume = comprimento * largura * altura;

                Console.WriteLine("O volume da caixa retangular é: " + volume);
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
