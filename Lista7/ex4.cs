using System;

class Program
{
    static void Main() {
    Console.WriteLine("Digite a primeira nota: ");
    int um = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a segunda nota: ");
    int dois = int.Parse(Console.ReadLine());
        if (aprov(um,dois) == true) Console.Write("Aprovado !!!");
        else Console.Write("Em prova final !!!");

    }
    
    public static bool aprov(int n1, int n2){
        int media = (n1 +n2)/2;
        if (media >= 60) return true;
        else return false;
        
    }
}