using System;

public class MainClass {
  public static void Main(string[] args) {
      int u,d,media ;
    Console.WriteLine("Primeira nota:");
    u = int.Parse(Console.ReadLine());
    Console.WriteLine("Segunda nota:");
    d = int.Parse(Console.ReadLine());
    media = (u+d)/2;
    Console.WriteLine("Média é = " + media);  
  }
}

