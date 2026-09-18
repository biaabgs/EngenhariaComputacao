using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_17
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 17. Faça um programa que solicite 
             * seu nome completo, o CPF , a idade e o salário.
                Após ler todos os valores, exiba:
                A idade.
                O primeiro nome do nome digitado.
                As últimas 3 letras do nome digitado.
                Calcule e exiba o desconto de INSS (11%)
                Exiba o salário final já descontado o INSS
                Exibir o CPF sem o ponto e o traco
             * */

            string nomeCompleto, CPF;
            int idade;
            double salario, inss;

            Console.WriteLine("Digite o nome");
            nomeCompleto = Console.ReadLine();

            Console.WriteLine("Digite o CPF");
            CPF = Console.ReadLine();

            Console.WriteLine("Digite a idade ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o salário");
            salario = double.Parse(Console.ReadLine());

            //A idade.
            Console.WriteLine("Sua idade é {0}", idade);

            //O primeiro nome do nome digitado.
            int posicaoEspaco = nomeCompleto.IndexOf(' ');

            if (posicaoEspaco == -1)
                Console.WriteLine($"Primeiro nome:  {nomeCompleto}");
            else
                Console.WriteLine("Primeiro nome:  {0}", 
                    nomeCompleto.Substring(0, posicaoEspaco));

            //As últimas 3 letras do nome digitado.
            Console.WriteLine("Primeiro nome:  {0}", 
                nomeCompleto.Substring(nomeCompleto.Length - 3, 3));

            //calcula o INSS
            inss = salario * 0.11;

            Console.WriteLine("Inss: {0:f2} ", inss);
            Console.WriteLine($"Salário final: {salario - inss}");

            //Exibir o cpf
            CPF = CPF.Replace(".", "");
            CPF = CPF.Replace("-", "");
            Console.WriteLine("CPF: {0}", CPF);

            Console.ReadLine();
        }
    }
}
