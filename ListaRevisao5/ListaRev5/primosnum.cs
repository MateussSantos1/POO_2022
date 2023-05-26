using System;

class Program
{
    static void Main() {
    Console.WriteLine("Digite um número:  ");
    int n1 = int.Parse(Console.ReadLine());
        primos( n1);

    }
    
    static void primos(int x){
        int verifica = 0;
        int divisores = 0;
        while(verifica <=x){
            verifica +=1;
            if (x%verifica == 0) divisores +=1;
            
        }
        if (divisores == 2) Console.WriteLine(x + " é um número primo !!! ");
        else Console.WriteLine(x + " NÃO é um número primo !!! ");
    }
}