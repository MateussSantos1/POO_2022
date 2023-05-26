using System;

class Program
{
    static void Main() {
    Console.WriteLine("Digite um valor: ");
    int um = int.Parse(Console.ReadLine());
    Console.WriteLine("Agora digite outro valor: ");
    int dois = int.Parse(Console.ReadLine());
        maior(um,dois);

    }
    
    static void maior(int n1, int n2){
        if (n1>n2) Console.WriteLine(n1 + " É o maior !!!");
        if (n2 > n1) Console.WriteLine(n2 + "É o maior !!!");
        if (n1==n2) Console.WriteLine("São iguais!!!");
    }
}