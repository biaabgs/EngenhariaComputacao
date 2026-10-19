namespace exercicio51_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[5];
            Int32[] salario = new Int32[5];

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write($"Digite o nome da {i + 1}ª pessoa: ");
                nomes[i] = Console.ReadLine();

                Console.Write($"Informe o salário de {nomes[i]}: ");
                salario[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int n = 0; n < 5; n++)
            {
                Console.WriteLine("{0} - R$ {1}", nomes[n], salario[n]);
            }

            Console.ReadLine();

            // Maior salário
            for (int i = 0; i < nomes.Length; i++)
            {
                if (nomes[i] <)
                {
                    Console.WriteLine($"A pessoa {} tem o maior salário: {salario[i]}");
                }
            }
        }
    }
}
