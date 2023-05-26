using System;

class Program
{
    static void Main() {
      int[] vetor = new int[4]{ 10, 4, 6, 3 };
      Console.WriteLine(vetor[0]);
      Console.WriteLine(vetor[1]);
      Console.WriteLine(vetor[2]);
      Console.WriteLine(vetor[3]);
      int[] w = { 7, 3, 15, 18};
      int[] z = w;
      z[0] = 10;
      Console.WriteLine(w[0]);
      Console.WriteLine(w[1]);
      Console.WriteLine(w[2]);
      Console.WriteLine(w[3]);
      Console.WriteLine(w.Length);
    }
}