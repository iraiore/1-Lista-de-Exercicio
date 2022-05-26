/*Faça um algoritmo que leia um número inteiro e mostre uma mensagem indicando 
se este número é par ou impar, e se é positivo ou negativo.*/

using System;
namespace atividade4
{
    class Program
    {
        static void Main (string[] args)
        {
            int num = 0;
            Console.WriteLine("Entre com o valor: ");
            num = Convert.ToInt32(Console.ReadLine());
            
            if(num % 2 == 0 && num >= 0)
             {
                Console.WriteLine("O número "+num+" é par positivo");
             }else if(num % 2 == 0 && num < 0)
                    {
                        Console.WriteLine("O número "+num+" é par negativo");
                    }else if(num % 2 != 0 && num < 0)
                            {
                        Console.WriteLine("O número "+num+" é impar negativo");
                            }else if(num % 2 != 1 && num >= 0)
                                    {
                                        Console.WriteLine("O número "+num+" é impar positivo");
                                    }
        
        }
    }
}