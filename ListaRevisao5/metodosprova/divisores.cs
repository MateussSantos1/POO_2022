using System;

class Program
{
    static void Main() {
    Console.WriteLine("Digiteo KG: ");
    int um = int.Parse(Console.ReadLine());
        mult(um);

    }
    
    static void  mult(int x){
        int num = x;
        int contador = 2;
        while(x < 1000){
            
            x = x +num ;
            contador +=1;
            
        }
        Console.WriteLine("Múltiplos é: " + contador);
    }
}

//tinha trocado num por x
// contador devia iniciar com 2 pois assim incluiria o 1 e o 1000 !!!