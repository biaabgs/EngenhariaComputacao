
namespace aula_1610_laco_com_continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa que irá contar quantas vogais existem em uma frase

            String frase;
            int qtd = 0;

            Console.WriteLine("Digite uma frase: ");
            frase = Console.ReadLine().ToUpper();

            //Varre a palavra toda USANDO CONTINUE
            for (int p = 0; p < frase.Length; p++)
            {
                if (frase[p] != 'A' && frase[p] != 'E' && frase[p] != 'I' && frase[p] != 'O' && frase[p] != 'U')
                {
                    continue; //volta para o for
                }

                qtd++;
            }

            Console.WriteLine($"Total de vogais: {qtd}");

            qtd = 0;
            //Varre a palavra toda sem usar CONTINUE
            for (int p = 0; p < frase.Length; p++)
            {
                if (frase[p] == 'A' || frase[p] == 'E' || frase[p] == 'I' || frase[p] == 'O' || frase[p] == 'U')
                {
                    qtd++;
                }
            }

            Console.WriteLine($"Total de vogais: {qtd}");
        }
    }
}
