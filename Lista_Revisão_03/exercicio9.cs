using System;

class Program
{
    static void Main() {
        Console.WriteLine("Digite um texto: ");
        string texto = Console.ReadLine();
        int lenght0 = texto.Length;
        int controle = 0;
        while(controle!=lenght0){
            controle +=1;
            Console.Write(controle + " - Brasil ");
            
        }
        
    }
}