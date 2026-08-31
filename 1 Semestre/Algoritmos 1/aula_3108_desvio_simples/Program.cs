namespace aula_3108_desvio_simples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criação da constante
            const float VALOR_HORA = 19.50f;

            //Cria as variáveis
            Int32 horas_trabalhadas;
            Single salario, desconto;

            //Entrada de dados
            Console.Write("Quantas horas foram trabalhadas?");
            horas_trabalhadas = Int32.Parse(Console.ReadLine());

            salario = horas_trabalhadas * VALOR_HORA;

            //verificações
            if(salario > 2500)
            {
                desconto = salario * 0.25f;
                Console.WriteLine($"Desconto = {desconto:f2}");
                //Equivale a: salario = salario - desconto;
                salario -= desconto;
            }
        }
    }
}
