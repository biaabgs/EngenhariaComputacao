using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_29
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             29. Sabendo-se que o comando Writeline pula de linha após exibir um texto, faça um programa que imprima na
tela um texto informado pelo usuário, letra por letra, cada uma em uma linha. Ex: texto = "vertical"
Ex:
v
e
r
t
i
c
a
l
             * */


            Console.WriteLine("Digite algo: ");
            string palavra = Console.ReadLine();

            for (int contador = 0; contador < palavra.Length; contador++)
            {
                Console.WriteLine(palavra[contador]);
            }

            Console.ReadLine();

        }
    }
}
