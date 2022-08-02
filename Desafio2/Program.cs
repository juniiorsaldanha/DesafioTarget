using System;

namespace Desafio
{
    class Program
    {
        //True se o número é um quadrado perfeito
        static bool QuadradoPerfeito(int x)
        {
            int valor = (int)Math.Sqrt(x); 
            if(valor * valor == x)
                return true; 
            else
                return false; 
        }
        //Regra matemática que: se 5*n*n + 4 ou 5*n*n - 4 for um quadrado perfeito
        //então n é um número de fibonnaci
        static bool Fibonnaci(int n)
        {
            if(QuadradoPerfeito(5 * n * n + 4) || QuadradoPerfeito(5 * n * n - 4))
                return true; 
            else
                return false; 
        }
        static void Main(String[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine(Fibonnaci(x) ? x + " É um numero Fibonnaci" : x + " Não é um numero Fibonnaci"); 
        }
    }
}