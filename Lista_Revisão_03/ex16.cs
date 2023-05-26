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
            int contaa = source.Split('A').Length - 1; 
            Console.WriteLine("A - " + contaa);
            int contaae = source.Split('E').Length - 1; 
            Console.WriteLine("E - " + contaae);
            int contaai = source.Split('I').Length - 1; 
            Console.WriteLine("I - " + contaai);
            int contaao = source.Split("O").Length - 1; 
            Console.WriteLine("O - " + contaao);
            int contaau = source.Split('U').Length - 1; 
            Console.WriteLine("U - " + contaau);
        }
    }
}