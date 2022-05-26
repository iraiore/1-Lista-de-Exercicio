/*
Desenvolva um algoritmo que:
Leia 4 (quatro) números; 
Calcule o quadrado de cada um; 
Se o valor resultante do quadrado do terceiro for >= 1000, imprima-o e finalize; 
Caso contrário, imprima os valores lidos e seus respectivos quadrados.mais teste 
*/

using System;
namespace atividade3
{
    class Program
    {
        static void Main (string[] args)
        {
            //DECLARAÇÃO DE VARIÁVEIS
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int a_quad = 0;
            int b_quad = 0;
            int c_quad = 0;
            int d_quad = 0;
            //CÓDIGO
            //Sequencia de instrução para o usuario entrar com os dados e serem armazenadas nas variáveis
            Console.WriteLine("Entre como o valor 1: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre como o valor 2: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre como o valor 3: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre como o valor 4: ");
            d = int.Parse(Console.ReadLine());
            a_quad = a*a;
            b_quad = b*b;
            c_quad = c*c;
            d_quad = d*d;

            if (c_quad>=1000)
            {
                Console.WriteLine("o quadrado do valor 3 é: "+c_quad);
            }else
            {
                Console.WriteLine("Os quatro valores de  entrada são: "+a+", "+b+", "+c+", "+d+".");
                a =a*a;
                b =b*b;
                c =c*c;
                d =d*d;
                Console.WriteLine("E seus respectivos quadrados são: "+a_quad+", "+b_quad+", "+c_quad+", "+d_quad+".");
            }
        }
    }
}