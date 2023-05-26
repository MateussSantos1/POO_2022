using System;

class Program
{
    static void Main() {
        string nome = Console.ReadLine();
        double salario = double.Parse(Console.ReadLine());
        double lucro = double.Parse(Console.ReadLine());
        double total = salario + lucro * 0.15;
        Console.WriteLine($"TOTAL = R$ {total:f2} ");
        
    }
}