using System;

class Program
{
    static void Main() {
        int n = 0;
        int soma = 0;
        int somacontrol = 0;
        while(n <=30 ){
             n += 1;
          Console.WriteLine(n);
            soma += n;
            somacontrol +=1;
            if(somacontrol == 3){
                Console.WriteLine("++" + soma);
                soma = 0;
                somacontrol = 0;
            }
        }
    }
}

//ou3x-3, pos x somado com x-a somado com x-2//