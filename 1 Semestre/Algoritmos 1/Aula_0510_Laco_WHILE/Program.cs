namespace Aula_0510_Laco_WHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //contar de 1 a 10 com for
            for(int c=1; c <= 10; c++)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("=======================");

            //contar de 1000 a 1010 com while
            int cont = 1000;
            while (cont <= 1010)
            {
                Console.WriteLine(cont);
                //faz o incremento
                cont++;
            }
        }
    }
}
