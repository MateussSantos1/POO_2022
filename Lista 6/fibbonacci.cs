using System;

class Program
{
    static void Main() {
        int a,b,c,num,x;
        a = 0;
        b = 1;
        c = 0;
        x = 0;
        Console.WriteLine("Digite a quantidade de valores:");
        num = int.Parse(Console.ReadLine());
        while(x != num){
            Console.WriteLine(a);
            c = a+b;
            b=c;
            a=b;
            x +=1;
        }
    }
}
