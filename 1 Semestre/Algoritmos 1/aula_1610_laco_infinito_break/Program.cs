
namespace aula_1610_laco_infinito_break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 numero;

            //digitação com laço infinito (não faz comparação, já é verdadeiro)
            while(true)
            {
                Console.WriteLine("Digite um número (0 para sair): ");
                numero = Int32.Parse(Console.ReadLine());

                //verifica se é zero para parar o laço
                if (numero == 0)
                {
                    break; //interrompe o laço
                }
            }

            //digitação com laço que NÃO é infinito
            do
            {
                Console.WriteLine("Digite um número (-1 para sair): ");
                numero = Int32.Parse(Console.ReadLine());

            } while (numero != -1);
        }
    }
}
