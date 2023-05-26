using System;

class Program
{
    static void Main() {
    Console.WriteLine("Comprimento: ");
    double um = double.Parse(Console.ReadLine());
    Console.WriteLine("Largura: ");
    double dois = double.Parse(Console.ReadLine());
    Console.WriteLine("Altura: ");
    double tres = double.Parse(Console.ReadLine());
        volume(um,dois,tres);

    }
    
    static void volume(double n1, double n2, double n3){
        double vol = n1 * n2 * n3 * 1000;
        Console.WriteLine(vol);
    }
}