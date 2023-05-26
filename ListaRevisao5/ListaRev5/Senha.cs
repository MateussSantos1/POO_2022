using System;

class Program
{
    static void Main() {
    Console.WriteLine("Digite uma Frase Com 5 Palavras");
    string frase = Console.ReadLine(); 
    senha(frase);
    }
    
    static void senha(string frase){
        string[] palavras = frase.Split(' '); 
        int totalPalavras1 = palavras[0].Length;
        int totalPalavras2 = palavras[1].Length;
        int totalPalavras3 = palavras[2].Length;
        int totalPalavras4 = palavras[3].Length;
        int totalPalavras5 = palavras[4].Length;
        Console.WriteLine("SENHA:")
        Console.WriteLine(totalPalavras1);
        Console.WriteLine(totalPalavras2);
        Console.WriteLine(totalPalavras3);
        Console.WriteLine(totalPalavras4);
        Console.WriteLine(totalPalavras5);
    }
}