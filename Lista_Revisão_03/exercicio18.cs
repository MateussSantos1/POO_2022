using System;

class Program
{
    static void Main() {
        Console.WriteLine("Digite um texto: ");
        string[] texto = Console.ReadLine().Split(",");
        int n1 = Convert.ToInt32(texto[0]);
        int n2 = Convert.ToInt32(texto[1]);
        int n3 = Convert.ToInt32(texto[2]);
        int n4 = Convert.ToInt32(texto[3]);
        int n5 = Convert.ToInt32(texto[4]);
        int soma = n1 + n2 + n3 + n4 +n5;
        Console.Write("Soma = " + soma);
    }
}