using System;

class Program
{
    static void Main() {
        int n = 0;
        int n1 =0;
        int sec =1;
        int num = 0;
        int tabu = 0;
        int y1 =0;
        int xis = 0;
        Console.WriteLine("Digite o número de Tabuadas desejados: ");
        tabu = int.Parse(Console.ReadLine());
        while(n !=tabu || xis != tabu){
            xis +=1;
            n +=1;
            num +=1;
            Console.WriteLine("Tabuada de " + num);
            for(int x = 1 ; x<=10 ; x++){
                y1 +=1;
                Console.WriteLine(sec + " X " + x + " = " + x*sec );
                sec +=1;
                n1 += 1;
            }
            }
        }
    }