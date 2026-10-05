namespace Aula_0510_Laco_WHILE_Validacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //faz a validação da informação do usuário
            //para aceitar somente I ou N

            String origem;

            Console.Write("Informe a Origem (I/N): ");
            //já converte para maiusculo
            origem = Console.ReadLine().ToUpper();

            while (origem != "I" && origem != "N")
            //while (origem != "I" && origem != "N" && origem != "n"
            //    && origem != "i")
            {
                //mensagem de erro
                Console.WriteLine("Informe [I] para Importado " +
                    "ou [N] para Nacional...");

                Console.Write("Informe a Origem (I/N): ");
                origem = Console.ReadLine();
            }

            //dado validado
            if (origem == "I")
                Console.WriteLine("Produto Importado...");
            else
                Console.WriteLine("Produto Nacional...");
        }
    }
}
