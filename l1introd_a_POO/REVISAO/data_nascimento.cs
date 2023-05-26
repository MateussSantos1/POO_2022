using System;

class Program
{
    static void Main() {
        Console.WriteLine("Digite a sua data de nascimento: ");
        string [] data = Console.ReadLine().Split("/");
        int ano = int.Parse(data[2]);
        int final = 2022 - ano;
        Console.WriteLine("No final de 2022, você terá " + final + " anos !!!!");
    }
}