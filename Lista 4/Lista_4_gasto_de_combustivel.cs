using System;

public class MainClass {
  public static void Main(string[] args) {
      double u,d,media, casastres ;
    Console.WriteLine(" ");
    u = double.Parse(Console.ReadLine());
    Console.WriteLine(" ");
    d = double.Parse(Console.ReadLine());
    media = (u*d)/12;
    casastres = Math.Round(media,3);
    Console.WriteLine("Consumo Total é = " + casastres);  
  }
}
