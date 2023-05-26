using System;

public class MainClass {
  public static void Main(string[] args) {
      double u,d,media ;
    Console.WriteLine("Digite um numero:");
    u = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite outro: ");
    d = double.Parse(Console.ReadLine());
    media = d%2;
    if (media == 0)
    {
    Console.WriteLine("Sao multiplos entre si "); 
    }
    else
    {
    Console.WriteLine("Nao sao multiplos ");
    }
  }
}
