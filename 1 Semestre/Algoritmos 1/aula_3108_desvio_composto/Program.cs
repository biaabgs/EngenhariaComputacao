namespace aula_3108_desvio_composto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criar variáveis
            float imc, altura, peso;

            // Entrada de dados
            Console.Write("Digite sua altura: ");
            altura = Convert.ToSingle(Console.ReadLine());

            Console.Write("Digite seu peso: ");
            peso = float.Parse(Console.ReadLine());

            //Cálculos
            imc = Convert.ToSingle(peso / Math.Pow(altura, 2));
            //ou (mesma coisa)
            imc = (float)(peso / Math.Pow(altura, 2));

            // O f2 significa que será formatado com 2 casas decimais
            Console.WriteLine($"Seu IMC é: {imc:f2}");

            //Testando
            if (imc > 30) 
            {
                Console.Write("Você está acima do peso!");
            }
            else
            {
                Console.Write("Seu peso está normal!");
            }
        }
    }
}
