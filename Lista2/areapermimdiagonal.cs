using System;

public class MainClass {
  public static void Main(string[] args) {
      double b,h,area,perimetro,diagonal ;
    Console.WriteLine("Digite a base do Retângulo::");
    b = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a altura do Retângulo:");
    h = double.Parse(Console.ReadLine());
    area = b*h;;
    perimetro = b + b + h + h;
    diagonal = b*h /2 ;
    Console.WriteLine("Área é = " + area);
    Console.WriteLine("Perímetro é = " + perimetro);
    Console.WriteLine("Diagonal é = " + diagonal);
  }
}

