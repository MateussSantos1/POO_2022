using System;

class Program
{
    static void Main() {
    Console.WriteLine("Digite A Distância Percorrida: ");
    double distancia = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite O Tempo Necessário Para Percorrer Essa Distância ( Em Horas) : ");
    double tempo = double.Parse(Console.ReadLine());
        velocidademedia(distancia,tempo);

    }
    
    static void velocidademedia(double n1, double n2){
        double velocidade = n1/n2;
        Console.WriteLine("Velocidade Média é igual a: " + velocidade + " Km/H");
    }
}