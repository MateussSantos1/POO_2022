using System;

class Program
{
    static void Main() {
        Console.WriteLine("Digite um texto: ");
        string[] texto = Console.ReadLine().Split(" ");
        int lenght0 = texto[0].Length;
        int lenght1 = texto[1].Length;
        int lenght2 = texto[2].Length;
        int lenght3 = texto[3].Length;
        int lenght4 = texto[4].Length;
        Console.Write(lenght0 + " " + lenght1 + " " + lenght2 + " " + lenght3 + " " + (lenght4) + " ");
    }
}