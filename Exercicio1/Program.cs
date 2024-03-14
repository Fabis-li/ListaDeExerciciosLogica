namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
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




        }
    }
}
