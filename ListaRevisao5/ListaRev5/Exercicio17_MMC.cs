using System;

class Program
{
    static void Main() {
    Console.WriteLine("Digite Um Valor");
    int um = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite Outro ");
    int dois = int.Parse(Console.ReadLine());
        mmc(um,dois);

    }
    
    static int mmc(int x, int y){
        int m = x;
        while (!(m %x  == 0 && m%y == 0)) m++;
        Console.WriteLine(m + " é o MMC  desses dois valores");
        return m;
    }
}