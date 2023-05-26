using System;

class Program
{
    static void Main() {
        Console.WriteLine("Digite uma frase: ");
        string nome = Console.ReadLine();
         while (nome.IndexOf("  ") >= 0)
                       nome = nome.Replace("  ", " ");
                       Console.WriteLine("Texto Otimizado = " + nome);
                       
    }
    
}
