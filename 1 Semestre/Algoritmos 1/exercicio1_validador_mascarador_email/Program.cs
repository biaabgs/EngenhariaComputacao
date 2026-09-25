namespace exercicio1_validador_mascarador_email
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string email;

            Console.WriteLine("Digite seu e-mail: ");
            email = Console.ReadLine();

            if (email.IndexOf('@') == -1 )
            {
                Console.WriteLine("E-mail inválido, deve conter @");

            }
        }
    }
}
