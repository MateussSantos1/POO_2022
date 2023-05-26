using System;

class Program
{
    static void Main() {
    Console.WriteLine("Digite a altura do retangulo: ");
    double um = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a base do retangulo: ");
    double dois = double.Parse(Console.ReadLine());
        diagonal(um,dois);

    }
    
    static void diagonal(double n1, double n2){
        double diag = (n1*n2)/2;
        Console.WriteLine(diag);
    }
}