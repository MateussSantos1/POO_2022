using System;

class Program
{
    static void Main() {
        int recebe;
        int senha = 2002;
        int recebfinal = 0;
        while(senha != recebfinal){
          Console.WriteLine("Digite uma senha: ");
          recebe = int.Parse(Console.ReadLine());
          recebfinal = recebe;
          if (recebfinal == senha) Console.WriteLine("Senha Correta!!!");
          else Console.WriteLine("Senha Errada!!!");
          Console.WriteLine("Quer continuar??? (s/n)");
          string resp = Console.ReadLine();
            if (resp == "s") senha = senha + 0;
            else if (resp == "n") break;
            else Console.Write("Digite apenas 'n' ou 's' !!!");
        }
    }
}