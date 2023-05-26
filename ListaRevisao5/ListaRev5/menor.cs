using System;

class Program
{
    static void Main() {
    Console.WriteLine("Digite um valor: ");
    double um = double.Parse(Console.ReadLine());
    Console.WriteLine("Agora digite outro valor: ");
    double dois = double.Parse(Console.ReadLine());
        maior(um,dois);

    }
    
    static void maior(double n1, double n2){
        if (n1>n2) Console.WriteLine(n1 + " É o maior !!!");
        if (n2 > n1) Console.WriteLine(n2 + " É o maior !!!");
        if(n1==n2) Console.WriteLine("Os valores informados são iguais !!!");
    }
}