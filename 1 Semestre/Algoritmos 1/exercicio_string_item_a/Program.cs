using System.Runtime.Intrinsics.Arm;

namespace exercicio_string_item_a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String email, nome, dominio;
            int arroba;

            Console.Write("Digite um e-mail: ");
            email = Console.ReadLine();

            //descobre a posição do '@'
            arroba = email.IndexOf('@');

            //se '@' não existir, arroba será -1
            if(arroba == -1)
            {
                Console.WriteLine("E-mail inválido");
            }
            else
            {
                nome = email.Substring(0, arroba);
                dominio = email.Substring(arroba + 1);

                if(nome.Length < 3)
                {
                    Console.WriteLine("Nome de usuário curto");
                }
                if(dominio.IndexOf('.') == -1)
                {
                    Console.WriteLine("Domínio inválido");
                }

                //TUDO CERTO :)
                Console.WriteLine($"Usuário: {nome}");
                Console.WriteLine($"Domínio: {dominio}");
                Console.WriteLine($"Primeira Letra: {nome[0]}");

                //e-mail mascarado
                String mascarado = nome[0].ToString() + "***@" + dominio;
                Console.WriteLine($"E-mail mascarado: {mascarado}");
                //ou
                Console.WriteLine($"Mascarado: {nome[0]}***@{dominio}");

                //domínio trocado por exemplo.com
                String novo = nome + "@exemplo.com";
                Console.WriteLine($"Novo e-mail: {novo}");
            }

        }
    }
}
