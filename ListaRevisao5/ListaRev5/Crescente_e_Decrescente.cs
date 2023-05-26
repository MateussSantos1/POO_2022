using System;

class Program
{
    static void Main() {
    Console.WriteLine("Digite um valor: ");
    double um = double.Parse(Console.ReadLine());
    Console.WriteLine("Agora digite outro valor: ");
    double dois = double.Parse(Console.ReadLine());
    Console.WriteLine("Agora digite um último valor: ");
    double tres = double.Parse(Console.ReadLine());
        ordenar(um,dois,tres);

    }
    
    static void ordenar(double n1, double n2,double n3){
        double maior = 0;
        double menor = 0;
        double meio = 0;
        if (n1>n2 && n1 >n3) maior = n1;
        if (n1<n2 && n1 <n3) menor = n1;
        if( n1>n2 && n3>n1)  meio = n1;
        if( n1>n3 && n2>n1)  meio = n1;
        
        if (n2>n3 && n2 >n1) maior = n2;
        if (n2<n1 && n2 <n3) menor = n2;
        if( n2>n3 && n1>n2)  meio = n2;
        if( n3>n2 && n1>n3)  meio = n2;
        
        if (n3>n2 && n3 >n1) maior = n3;
        if (n3<n2 && n3 <n1) menor = n1;
        if( n3>n2 && n1>n3)  meio = n3;
        if( n2>n3 && n3>n1)  meio = n3;
        Console.WriteLine("VALORES EM ORDEM DECRESCENTE == " + maior +" , " + meio + " , " + menor);
    }
}