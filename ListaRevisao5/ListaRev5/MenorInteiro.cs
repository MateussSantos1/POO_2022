using System;

class Program
{
    static void Main() {
    Console.WriteLine("Digite um valor : ");
    double um = double.Parse(Console.ReadLine());
        testaint(um);

    }
    
    static void testaint(double n1){
        int x = (int) n1;
        
        if (x == n1) Console.WriteLine("O valor inteiro mais próximo é == " + x);
        else Console.WriteLine(" O valor inteiro mais próximo é == " + (x+1));
    }
}