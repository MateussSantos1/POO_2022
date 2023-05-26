using System;

public class MainClass {
  public static void Main(string[] args) {
      int u;
    Console.WriteLine("Digite um numero:");
    u = int.Parse(Console.ReadLine());
    if (u == 61) Console.WriteLine("Brasilia"); 
    else if (u == 71)Console.WriteLine("Salvador");
    else if (u==11)Console.WriteLine("Sao Paulo");
    else if (u==21)Console.WriteLine("Rio de Janeiro");
    else if (u==32) Console.WriteLine("Juiz de Fora");
    else if(u==19)Console.WriteLine("Campinas");
    else if(u == 84) Console.Write("Rio Grande do Norte");
    else Console.WriteLine("DDD não encontrado!");
  }
}