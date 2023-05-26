using System;

class Program
{
    static void Main() {
        //string s = "Técnico Em Informática Para Internet";
      Console.WriteLine("Digite uma frase: ");
        string s = Console.ReadLine();
        int p = s.IndexOf(' ');
      while(p !=-1){
        s = s.Substring(p+1);
        
        p = s.IndexOf(" "); //procura o espaço em determinada posição e o elimina o que vem antes desse espaço na próxima repetição//
      }
      Console.WriteLine(s);
    }
}

//v.Lenght CONTA A QUANTIDADE DE PALAVRAS