/*
Elabore algoritmo que leia as variáveis C e N, respectivamente código e número de 
horas trabalhadas de um operário. E calcule o salário sabendo-se que ele ganha R$ 
10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de 
pagamento armazenando-o na variável E, caso contrário zerar tal variável. A hora 
excedente de trabalho vale R$ 20,00. No final do processamento imprimir o salário 
total e o salário excedente
*/
using System;
namespace atividade2
{
    class Program
    {
        static void Main (string[] args)
        {
        //DECLARAÇÃO DE VARIÁVEIS
        int C = 0;//codigo do trabalhador
        int N = 0;//numero de horas trabalhadas pelos operador
        int E = 0;//variavel para armazernar o excesso de pagamento com hora excedente
        int SHN = 0;// salario com horas normais
        int ST = 0;//variavel para armazenar o salario total e excedente do funcionário
        //CODIGO
        Console.WriteLine("Entre como o código e o numero de horas trabalhadas do operador: ");
        C = int.Parse(Console.ReadLine());//atribuindo o codido a variavel C
        N = Convert.ToInt32(Console.ReadLine());//atribuindo o codido a variavel N
        
        if(N>50)
        {
            SHN = 50*10;
            E  = (N-50)*20;
            ST = SHN+E;
            Console.WriteLine("O salário do operário  "+C+" é: R$ "+SHN+". O salário excedente é: R$: "+E+". O salário total do colaborador é: R$ "+ST);
        }else
        {
            SHN = 50*10;
            Console.WriteLine("Não houve salário excedente. O salário do colaborador, refernte a horas normais é: R$: "+SHN);
        }
        }
    }
}