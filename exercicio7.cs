/*Construa um algoritmo que leia 5 valores inteiros e positivos e: 
Encontre o maior valor 
Encontre o menor valor 
Calcule a média dos números lidos*/
using System;
namespace exercicio7
{
    public class Program
    {
        public static void Main (string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int e = 0;
            int maior = 0;
            int menor = 0;
            float media = 0;
            Console.WriteLine("Entre como o valor 1: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre como o valor 2: ");
            b = int.Parse(Console.ReadLine());
            if(a > b)
            {
                maior = a;
                menor = b;
            }else if(a <= b)
            {
                maior = b;
                menor = a;
            }
            Console.WriteLine("Entre como o valor 3: ");
            c =  int.Parse(Console.ReadLine());
            if(c > maior)
            {
                maior = c;
            }else if(c < menor)
            {
                menor = c;
            }
            Console.WriteLine("Entre como o valor 4: ");
            d =  int.Parse(Console.ReadLine());
            if(d > maior)
            {
                maior = d;
            }else if(d < menor)
            {
                menor = d;
            }
            Console.WriteLine("Entre como o valor 5: ");
            e =  int.Parse(Console.ReadLine());
            if(e > maior)
            {
                maior = e;
            }else if(e < menor)
            {
                menor = e;
            }
            media = (maior+menor)/2;
            Console.WriteLine("maior: "+maior+" "+"menor: "+menor+" media: "+media);
        }
    }
}