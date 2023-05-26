using System;

class Program
{
    static void Main() {
    Console.WriteLine("Digiteo Raio do Circulo: ");
    double um = double.Parse(Console.ReadLine());
        areacirc(um);

    }
    
    static void areacirc(double n1){
        double area = 4 * 3.14 * n1 * n1 * n1;
        double area2 = area/3;
        int arredondado = (int) area2;
        Console.WriteLine(area2);
        Console.WriteLine("O valor inteiro aproximado é == " + (arredondado + 1));
    }
}