using System;

class Program {
  public static void Main() {
    Console.WriteLine("Informe uma data no formato dd/mm/aaaa");
    string data = Console.ReadLine();
    Console.WriteLine(data);
    string[] v = data.Split('/');
    int ano = int.Parse(v[2]);
    int final = 2022 - ano;
    if (data[1] ==1) Console.WriteLine("JANEIRO");
  }
}