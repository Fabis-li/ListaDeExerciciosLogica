namespace Exercicio28.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Tabuada em coluna");

                int numero = 1;

                while(numero <= 10)
                {
                    int numero2 = 1;

                    while( numero2 <= 10)
                    {
                        int resultado = numero * numero2;

                        Console.WriteLine(numero + " x " + numero2 + " = " + resultado);

                        numero2++;

                        if(numero == 11)
                        {
                            Console.WriteLine();
                        }
                    }
                    numero++;
                }
                Console.ReadLine();
            }
        }
    }
}
