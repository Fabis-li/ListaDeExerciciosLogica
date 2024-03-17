namespace Exercicio25.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Fatorial");

                Console.WriteLine("Digite um valor");
                int valor = Convert.ToInt32(Console.ReadLine());

                //5 = 5x4x3x2x1 = 120

                int resultado = 1;
                int contador = valor;

                Console.WriteLine(valor + "! = ");

                while(contador > 0)
                {
                    resultado *= contador;
                    Console.WriteLine(contador);
                    if( contador != 1)
                    {
                        Console.WriteLine(" x ");
                    }
                    contador--;                    
                }
                Console.WriteLine(" = " + resultado);

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
