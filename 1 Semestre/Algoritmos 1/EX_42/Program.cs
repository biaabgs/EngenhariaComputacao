namespace EX_42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
         42. Faca um programa de cadastro. Solicite os seguintes dados:
        Cadastro de Detento
        codigo : integer (maior que zero)
        nome : string (Obrigatorio pelo menos 1 letra)
        condenacao : string (obrigatorio ao menos 5 letras)
        pena : int (entre 1 e 500 anos)
        Ao final do cadastro, exiba os dados:
        Codigo: ______
        Nome: ________
        Condenacao:__________
        Pena:_______
        Pergunte se o usuário deseja cadastrar outro detento ou sair do programa.
         * */

            char resp;

            int codigo, pena;
            string nome, condenacao;

            resp = 'S';
            while (resp == 'S')
            {
                codigo = -1;
                while (codigo < 0)
                {
                    Console.WriteLine("Digite o código ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                }

                nome = "";
                while (nome.Length == 0)
                {
                    Console.WriteLine("Digite o nome: ");
                    nome = Console.ReadLine();
                }

                Console.WriteLine("Digite a condenação: ");
                condenacao = Console.ReadLine();

                while (condenacao.Length < 5)
                {
                    Console.WriteLine("Digite a condenação: ");
                    condenacao = Console.ReadLine();
                }

                Console.WriteLine("Digite a pena entre 1 e 500 anos");
                pena = Convert.ToInt32(Console.ReadLine());

                while (pena < 1 || pena > 500)
                {
                    Console.WriteLine("Digite a pena entre 1 e 500 anos");
                    pena = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine($"Código: {codigo}  - Nome: {nome}  - " +
                    $"Condenação:  {condenacao} - Pena: {pena}");

                Console.Write("Deseja digitar outro condenado (S/N");
                resp = Console.ReadLine().ToUpper()[0];
            }
        }
    }
}

