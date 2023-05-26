using System;

class Program
{
    static void Main() {
        int num,x,pos,maior,val;
        x = 0;
        pos =0;
        maior = 0;
        Console.WriteLine("Digite a quantidade de valores a serem lidos: ");
        val = int.Parse(Console.ReadLine());
        while(x != val){
            Console.WriteLine("Digite um numero:");
            num = int.Parse(Console.ReadLine());
            x += 1;
            pos += 1;
            if(num>maior) maior = num;
        }
        Console.WriteLine("O maior numero é: " + maior + " e sua posição é: "  + pos);
    }
}