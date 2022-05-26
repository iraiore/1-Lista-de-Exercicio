/*Elabore um algoritmo que dada a idade de um nadador classifique-o em uma das 
seguintes categorias: 
Infantil A = 5 a 7 anos
Infantil B = 8 a 11 anos 
Juvenil A = 12 a 13 anos 
Juvenil B = 14 a 17 anos 
Adultos = Maiores de 18 anos*/

using System;
namespace atividade6
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 0;
            Console.WriteLine("Entre com a idade do nadador: ");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine("A classificação do nadador é: Infantil A");
            }else if (idade >= 8 && idade <= 11)
            {
                Console.WriteLine("A classificação do nadador é: Infantil B");
            }else if (idade >= 12 && idade <= 13)
            {
                Console.WriteLine("A classificação do nadador é: Juvenil A");
            }else if (idade >= 14 && idade <= 17)
            {
                Console.WriteLine("A classificação do nadador é: Juvenil B");
            }else
            {
                Console.WriteLine("A classificação do nadador é: Adultos");
            }
        }
    }
}