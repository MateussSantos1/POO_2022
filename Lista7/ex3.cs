using System;

class Program
{
    static void Main() {
    Console.WriteLine("Digite um valor: ");
    int um = int.Parse(Console.ReadLine());
    Console.WriteLine("Agora digite outro valor: ");
    int dois = int.Parse(Console.ReadLine());
    Console.WriteLine("Agora um último  valor: ");
    int tres = int.Parse(Console.ReadLine());
        maior(um,dois,tres);

    }
    
    static void maior(int n1, int n2, int  n3){
        if (n1>n2 && n1>n3) Console.WriteLine(n1 + " É o maior !!!");
        if (n2 > n1 && n2>n3) Console.WriteLine(n2 + " É o maior !!!");
        if (n3 > n1 && n3>n2) Console.WriteLine(n3 + " É o maior !!!");
        else Console.WriteLine("Os valores informados são iguais !!!");
    }
}