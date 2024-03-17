namespace Exercicio19.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Calculo de IMC\n");

                Console.WriteLine("Digite o seu peso");
                double peso = Convert.ToDouble(Console.ReadLine());

                if(peso <=0)
                {
                    Console.WriteLine("Digito um peso válido");
                    peso = Convert.ToDouble(Console.ReadLine());
                }

                Console.WriteLine("Digite sua altura");
                double altura = Convert.ToDouble(Console.ReadLine());

                if(altura <=0)
                {
                    Console.WriteLine("Digite uma altura válida");
                    altura = Convert.ToDouble(Console.ReadLine());
                }

                double IMC = peso / Math.Pow(altura, 2);

                if (IMC < 18.5)
                {
                    Console.WriteLine("Seu IMC é :" + Math.Round(IMC, 2));
                    Console.WriteLine("Você está abaixo do peso.\n");                    
                }
                else if (IMC >= 18.5 && IMC <= 25)
                {
                    Console.WriteLine("Seu IMC é :" + Math.Round(IMC, 2));
                    Console.WriteLine("Você está no peso normal.\n");
                    
                }
                else if (IMC > 25 && IMC <= 30)
                {
                    Console.WriteLine("Seu IMC é :" + Math.Round(IMC, 2));
                    Console.WriteLine("Você está acima do peso.\n");
                    
                }
                else
                {
                    Console.WriteLine("Seu IMC é :" + Math.Round(IMC, 2));
                    Console.WriteLine("Você está obeso.\n");
                    
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
