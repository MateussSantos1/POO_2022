using System;

public class MainClass {
  public static void Main(string[] args) {
      double u,d,media,sla ;
    Console.WriteLine(" ");
    u = double.Parse(Console.ReadLine());
    media = (4.0/3) *  3.14 * (u * u * u);
    sla = Math.Round(media,3);
    Console.WriteLine("VOLUME = " + sla);  
  }
}
