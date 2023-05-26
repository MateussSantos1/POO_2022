using System;

class Program {
  public static void Main() {
    Console.WriteLine("Informe uma data no formato dd/mm/aaaa");
    string data = Console.ReadLine();
    Console.WriteLine(data);
    string[] v = data.Split('/');
    int mes = int.Parse(v[1]);
    if (mes == 1) Console.WriteLine("Janeiro");
    if (mes == 2) Console.WriteLine("Fevereiro");
    if (mes == 3) Console.WriteLine("Março");
    if (mes == 4) Console.WriteLine("Abril");
    if (mes == 5) Console.WriteLine("Maio");
    if (mes == 6) Console.WriteLine("Junho");
    if (mes == 7) Console.WriteLine("Julho");
    if (mes == 8) Console.WriteLine("Agosto");
    if (mes == 9) Console.WriteLine("Setembro");
    if (mes == 10) Console.WriteLine("Outubro");
    if (mes == 11) Console.WriteLine("Novembro");
    if (mes == 12) Console.WriteLine("Dezembro");
  }
}