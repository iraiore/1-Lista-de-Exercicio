/*A Secretaria de Meio Ambiente que controla o índice de poluição mantém 3 grupos 
de indústrias que são altamente poluentes do meio ambiente. O índice de poluição 
aceitável varia de 0,05 até 0,25. Se o índice sobe para 0,3 as indústrias do 1o grupo 
são intimadas a suspenderem suas atividades, se o índice crescer para 0,4 as industrias 
do 1o e 2o grupo são intimadas a suspenderem suas atividades, se o índice atingir 0,5 
todos os grupos devem ser notificados a paralisarem suas atividades. Algoritmo que 
leia o índice de poluição medido e emita a notificação adequada aos diferentes grupos 
de empresas. */

using System;
namespace atividade5
{
    class Program
    {
        static void Main(string[] args)
        {
            float ind = 0;
            Console.WriteLine("Entre com o índice de poluição: ");
            ind = float.Parse(Console.ReadLine());

            if(ind >= 0.05 && ind <= 0.25)
            {
                Console.WriteLine("Nenhuma das empresas do grupo precisam suspeder suas atividades");
            }else if(ind >= 0.3 && ind < 0.4)
            {
                Console.WriteLine("As empresas do Grupo 1 estao intimadas a suspenderem suas atividades");
            }else if(ind >= 0.4 && ind < 0.5)
            {
                Console.WriteLine("As empresas do Grupo 1 e 2 estao intimadas a suspenderem suas atividades");
            }else if(ind >= 0.5)
            {
                Console.WriteLine("As empresas do Grupo 1, 2 e 3 estao intimadas a suspenderem suas atividades");
            }
        }
    }
}