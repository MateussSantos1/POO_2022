using System;
using System.Linq;

namespace get_first_char_of_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase: ");
            string entrada = Console.ReadLine();
            string source = entrada.ToUpper();
            int c1 = source.Split("0").Length - 1; 
            //source split lenght verifica a quantidade desse caractere no código!!! obs colocar -1 em todos os finai  smp!!!
            int c2 = source.Split('1').Length - 1; 
            int c3 = source.Split('2').Length - 1; 
            int c4 = source.Split('3').Length - 1; 
            int c5 = source.Split("4").Length - 1; 
            int c6 = source.Split('5').Length - 1; 
            int c7 = source.Split("6").Length - 1; 
            int c8 = source.Split("7").Length - 1; 
            int c9 = source.Split("8").Length - 1; 
            int c0 = source.Split("9").Length - 1; 
            int soma = (c1*0) + (c2*1) + (c3*2) + (c4*3) + (c5*4) + (c6*5) + (c7*6) + (c8*7) + (c9*8) + (c0*9);
            Console.WriteLine("Soma da quantidade de numeros = " + soma);
        }
    }
}