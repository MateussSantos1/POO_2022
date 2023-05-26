using System;

class Program {
  public static void Main() {
    Console.WriteLine("Digite o nome da primeira pessoa:");
    string nomeum = Console.ReadLine();
    Console.WriteLine("Informe a data da primeira pessoa em --/-- /----");
    string dataum = Console.ReadLine();
    string[] vum = dataum.Split('/');
    int ano = int.Parse(vum[2]);
    Console.WriteLine("Digite o nome da segunda pessoa: ");
    string nomedois = Console.ReadLine();
    Console.WriteLine("Informe a data da primeira pessoa em --/-- /----");
    string datadois = Console.ReadLine();
    string[] vdois = datadois.Split('/');
    int anodois = int.Parse(vdois[2]);
    if (ano > anodois) Console.WriteLine(nomedois + " é o mais velho !!!");
    if (anodois > ano) Console.WriteLine(nomeum + " é o mais velho !!!");
    
  }
}