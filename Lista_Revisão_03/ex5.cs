using System;

class Program
{
    static void Main() {
        int n = 1;
        int pos = 0;
        Console.WriteLine(n);
        while  (n !=46){
            n = n + pos;
            pos +=1;
            Console.WriteLine(n + pos);
        }
    }
}