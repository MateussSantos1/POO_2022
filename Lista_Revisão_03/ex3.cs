using System;

class Program
{
    static void Main() {
        int n = -1;
        Console.WriteLine(1);
        while(n !=-11){
          
            n = n-1;
            if(n%2 ==0) Console.WriteLine(n);
            else Console.WriteLine(n * -1);
        }
    }
}