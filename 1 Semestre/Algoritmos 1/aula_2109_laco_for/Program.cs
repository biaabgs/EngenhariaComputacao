namespace aula_2109_laco_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exibindo números de 1 a 10");

            for (int contador = 1; contador <= 10;)
                contador = +1;

            //ou

            for(int contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine($"Contador: {contador}");
            }

            Console.WriteLine("Exibindo números pares de 10 a 30 de 2 em 2");
            for (int contador = 10; contador <= 30; contador += 2)
            {
                Console.WriteLine($"Contador: {contador}");
            }

            Console.WriteLine("Exibindo números de 10 a 0" + "de -1 em -1");
            for(int contador = 10; contador >= 0; contador--)
            {
                Console.WriteLine($"Contador: {contador}");
            }


        }
    }
}
