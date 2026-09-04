namespace exercicio_dia_da_semana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 semana;

            Console.WriteLine("Digite um número que corresponda ao da semana (1 a 7): ");
            semana = int.Parse(Console.ReadLine());

            if (semana < 7) {
                Console.WriteLine("O número é inválido (deve ser entre 1 e 7)");

                if (semana >= 1)
                {

                    if (semana == 1)
                    {
                        Console.WriteLine("O dia da semana é: domingo");
                    }
                    if (semana == 2)
                    {
                        Console.WriteLine("O dia da semana é: segunda");
                    }
                    if (semana == 3)
                    {
                        Console.WriteLine("O dia da semana é: terça");
                    }
                    if (semana == 4)
                    {
                        Console.WriteLine("O dia da semana é: quarta");
                    }
                    if (semana == 5)
                    {
                        Console.WriteLine("O dia da semana é: quinta");
                    }
                    if (semana == 6)
                    {
                        Console.WriteLine("O dia da semana é: sexta");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    else
                    {
                        Console.WriteLine("O dia da semana é: sábado");
                    }
                }
            }
        }
    }
}
