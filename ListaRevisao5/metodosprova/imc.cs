using System;

class Program
{
    static void Main() {
    Console.WriteLine("Digiteo KG: ");
    double um = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite METROS: ");
    double dois = double.Parse(Console.ReadLine());
        imc(um,dois);

    }
    
    static void imc(double x, double y){
        double quadradoy = y * y;
        double imc = x/quadradoy;
        Console.WriteLine("Seu IMC é: " + imc);
    }
}