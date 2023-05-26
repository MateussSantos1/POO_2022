using System;

class Program
{
    static void Main() {
        double a,b,c,raiz,ac,trap,trapi;
        string[] texto = Console.ReadLine().Split(" ");
                 a = double.Parse(texto[0]);
                 b = double.Parse(texto[1]);
                 c = double.Parse(texto[2]);
            raiz = c*c;
            ac = a*c;
            trap = a+b;
            trapi = (trap*c)/2;
        Console.WriteLine("TRIANGULO =" +  ac/2);
        Console.WriteLine("CIRCULO =" + raiz*3,14 );
        Console.WriteLine("TRAPEZIO=" + trapi);
        Console.WriteLine("QUADRADO =" + b*b);
        Console.WriteLine("RETANGULO="+ a*b);

    }
}