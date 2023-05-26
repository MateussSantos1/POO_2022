using System;

class Program
{
    static void Main() {
      int limite;
      double divisao;

      limite = int.Parse(Console.ReadLine());
      for (int i=0; i<limite; i++)
        {
            string[] line = Console.ReadLine().Split(" ");
            double X = double.Parse(line[0]);
            double Y = double.Parse(line[1]);
            if (Y == 0) 
            {
               Console.WriteLine("divisao impossivel");
            } 
            else 
            {
                divisao = X / Y; 
                Console.WriteLine(divisao);
        }
    }
}    
