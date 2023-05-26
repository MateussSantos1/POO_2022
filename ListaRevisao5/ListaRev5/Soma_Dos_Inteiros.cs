using System;

class Program
{
    static void Main() {
    Console.WriteLine("Digite o início do intervalo: ");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o Fim do intervalo: ");
    int n2 = int.Parse(Console.ReadLine());
        antsuc(n1,n2);

    }
    static void antsuc(int n1, int n2){
        int inicio = n1;
        int soma = 0;
        while(inicio!=n2){
            soma =  soma + inicio;
            inicio +=1;
        }
         soma = soma + n2;
        if (n2>n1) Console.WriteLine("A soma dos valores desse intervalo é igual a == " + soma );
        if ( n1 == n2) Console.WriteLine("Ops!!! O Valor NÃO PODE SER *IGUAL* ao Valor Inicial !!! ");
        if (n2<n1) Console.WriteLine("Ops!!! O Valor INICIAL não pode ser *MAIOR* que o Valor FInal");
    }
}