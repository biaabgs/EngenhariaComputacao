namespace exercicio7_3108
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x, b, m;

            Console.Write("Digite o valor de b: ");
            b = Convert.ToSingle(Console.ReadLine());

            Console.Write("Digite o valor de m: ");
            m = Convert.ToSingle(Console.ReadLine());

            

            if (m == 0)
            {
                Console.Write("O valor de m não pode ser 0");
            }
            else
            {
                x = b / m;
                Console.WriteLine($"Seu X é: {x:f2}");
            }
        }
    }
}
