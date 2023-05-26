using System;

class Program
{
    static void Main() {
        double a,b;
        string[] texto = Console.ReadLine().Split(" ");
                 a = double.Parse(texto[0]);
                 b = double.Parse(texto[1]);
        if (a>=0 && a<=432 && b>=0 && b <=432)
        {
            Console.WriteLine("Dentro");   
        }
        else
        {
            Console.WriteLine("Fora");

    }
  }
}