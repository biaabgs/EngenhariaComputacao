namespace exercicio1_laco_encadeados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());

            for(int i = num1; i < num1 * 3; i += 2)
            {
                Console.WriteLine($"Número 1: {i}");
            }

            Console.Write("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            for(int i = num2; i < num2 * 3; i += 2)
            {
                Console.WriteLine($"Número 2: {i}");
            }


            //Usando laços encadeados
            for(int vez = 0; vez < 2; vez++) 
            { 
                Console.Write("Digite um número: ");
                num1 = int.Parse(Console.ReadLine());

                for(int i = num1; i < num1 * 3; i += 2)
                {
                    Console.WriteLine($"Número {vez + 1}: {i}");
                }
            }
        }
    }
}
