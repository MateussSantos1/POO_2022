using System;

class Program
{
    static void Main() {
        int n = -1;
        Console.WriteLine(n);
        while(n !=-30){
            n = n-1;
            if (n%3 == 0) Console.WriteLine(n);
            else  Console.WriteLine(n * -1);
        }
    }
}