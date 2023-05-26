using System;

class Program
{
    static void Main() {
        Console.WriteLine("Digite a sua data de nascimento: ");
        string [] data = Console.ReadLine().Split("/");
        int ano = int.Parse(data[2]);
        int final = 2022 - ano;
        if ( final >0 && final <=19) Console.WriteLine("Você está na faixa etária:  Jovem");
        if ( final >=0 && final <=59) Console.WriteLine("Você está na faixa etária:  Adulto");
        if ( final >=60) Console.WriteLine("Você está na faixa etária:  Idoso");
    }
}