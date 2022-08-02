using System;

namespace Desafio
{
    class Program
    {
        static void reverso(string s)
        {
            string aux = "";
            char letra;  
            for(int i = 0; i < s.Length; i++)
            {
                letra = s[i]; 
                aux = letra + aux; 
            }

            Console.WriteLine($"Palavra invertida: " + aux); 
        }
        static void Main(String[] args)
        {
            string s = Console.ReadLine(); 

            Console.WriteLine($"Palavra: {s}"); 

            reverso(s); 
        }
    }
}