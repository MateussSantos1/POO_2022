using System;

class Program
{
    static void Main() {
    Console.WriteLine("Digite Um Termo: ");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite Um Segundo Termo: ");
    int n2 = int.Parse(Console.ReadLine());
        MMC(n1,n2);

    }
    static void MMC(int n1, int n2){
        int soma = 0;
        if (n1%2 == 0 && n2%2 == 0) soma +=2;
        if (n1%3 == 0 && n2%3 == 0) soma +=3;
        if (n1%5 == 0 && n2%5 == 0) soma +=5;
        if (n1%7 == 0 && n2%7 == 0) soma +=7;
        if (n1%11 == 0 && n2%11 == 0) soma +=11;
        if (n1%13 == 0 && n2%13 == 0) soma +=13;
        if (n1%17 == 0 && n2%17 == 0) soma +=17;
        if (n1%19 == 0 && n2%19 == 0) soma +=19;
        if (soma >=1) Console.WriteLine("A soma dos MDC's desses números é igual a == " + soma );
        else Console.WriteLine("Esses valores não possuem MDC entre si !!!");
    }
}