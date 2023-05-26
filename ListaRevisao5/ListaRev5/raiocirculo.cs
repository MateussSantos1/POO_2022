using System;

class Program
{
    static void Main() {
    Console.WriteLine("Digiteo Raio do Circulo: ");
    double um = double.Parse(Console.ReadLine());
        areacirc(um);

    }
    
    static void areacirc(double n1){
        double area = 3.14 * n1 * n1;
        Console.WriteLine(area);
    }
}