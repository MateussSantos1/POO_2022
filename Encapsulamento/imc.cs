using System;

class Program {
  public static void Main() {
    /*string s = "Técnico em Informática para Internet";
    s.Split();
    // string.Split() se Split fosse static
    Console.WriteLine("Olá");
    int x = 5;
    int y = 15;
    Console.WriteLine(x);
    Console.WriteLine(y);*/
    Console.WriteLine("Digite aqui a altura:");
    double altura = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite aqui seu peso:");
    double peso = double.Parse(Console.ReadLine());
    IMC a1 = new IMC();
    a1.SetAltura(altura);
    Console.WriteLine(a1);
    Console.WriteLine(a1.GetAltura());
    IMC a2 = new IMC();
    a1.SetPeso(peso);
    Console.WriteLine(a2);
    Console.WriteLine(a1.Peso());
  
  }
}

class IMC {
  private double altura;
  public void SetAltura(double x) {
    if (x > 0 && x < 5) altura = x;
  }
  public double GetAltura() {
    return altura;
  private double peso;
  public void SetPeso(double y) {
    if (x > 0 && x < 300) altura = y;
  }
  public double GetPeso() {
    return peso;
  }
}