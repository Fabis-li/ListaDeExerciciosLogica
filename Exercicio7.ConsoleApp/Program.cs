namespace Exercicio7.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular Salario Total de Vendedor\n");
            Console.WriteLine("Informe o salario base em reais");
            decimal salarioBase = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe o total das vendas em reais");
            decimal totalVendas = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe o percentual de comissão");
            decimal comissao = Convert.ToDecimal(Console.ReadLine());

            decimal salarioTotal = salarioBase + (totalVendas * comissao / 100);

            Console.WriteLine(" O salario total do vendedor e R$: " + Math.Round(salarioTotal, 2));
            Console.ReadLine();

        }
    }
}
