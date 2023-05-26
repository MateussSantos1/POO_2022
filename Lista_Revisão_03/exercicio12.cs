using System;

class Program
{
    static void Main() {
        Console.WriteLine("Digite um texto: ");
        string[] texto = Console.ReadLine().Split(" ");
        int lenght0 = texto.Length;
        Console.Write(lenght0);
    }
}