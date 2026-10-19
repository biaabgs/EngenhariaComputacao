namespace array_aula1910
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando o vetor de idades
            Int32[] idades = new int[6];
            Int32 soma = 0;
            Single media;

            // Lendo as idades 
            for (int i = 0; i < idades.Length; i++) {
                Console.Write($"Digite a {i + 1}ª idade: ");
                idades[i] = Convert.ToInt32(Console.ReadLine());

                // Faz a soma
                soma += idades[i];
            }

            // Calcula a média
            media = soma / idades.Length;

            Console.WriteLine($"Média de idades: {media:f2}");

            // Listando as idades menores que a média
            for (int i = 0; i < idades.Length; i++)
            {
                if (idades[i] < media)
                {
                    Console.WriteLine($"A idade {idades[i]} " + $"é menor que a média");
                }
            }
        }
    }
}
