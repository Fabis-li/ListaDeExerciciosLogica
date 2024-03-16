namespace Exercicio16.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Calcular aumento e imposto de salário\n");
                Console.WriteLine("Digite o salário inicial do funcionário");
                decimal salarioInicial = Convert.ToDecimal(Console.ReadLine());

                if(salarioInicial <= 0)
                {
                    Console.WriteLine("Favor digitar um salário válido");
                    salarioInicial = Convert.ToDecimal(Console.ReadLine());
                }


                decimal aumento = 0.15M * salarioInicial;

                decimal imposto = 0.08M;                

                decimal salarioAumento = salarioInicial + aumento;
                decimal salarioFinal = salarioAumento - (imposto * salarioInicial);

                Console.WriteLine("O salário inicial é R$: " + salarioInicial + "\n");
                Console.WriteLine("O salário com aumento é R$: " + salarioAumento +  "\n");
                Console.WriteLine("O salário final e de R$: " + salarioFinal + "\n");

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
