using System;

class Program
{
    static void Main() {
    Console.WriteLine("Digite uma frase : ");
    string s = Console.ReadLine();
        referencia(s);

    }
    
    static string referencia(string s){
        string[] s2 = s.Split(' ');
        int p = s.IndexOf(' ');
        while(p !=-1){
        s = s.Substring(p+1);
        
        p = s.IndexOf(" "); //procura o espaço em determinada posição e o elimina o que vem antes desse espaço na próxima repetição//
      }
      Console.WriteLine(s2[0]);
      Console.WriteLine(s);
      return s;
    }
}