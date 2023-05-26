using System;

class Program
{
    static void Main() {
    Console.WriteLine("---------------------------------------");
    Console.WriteLine("| Preço Por Massa == R$1 - 1Kg        |");
    Console.WriteLine("| Preço Por Distância == R$10 - 1Km   |");
    Console.WriteLine("---------------------------------------");
    Console.WriteLine("       ");
    Console.WriteLine("Digite aqui a Massa a ser carregada:");
    double m = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite aqui a distância: ");
    double d = double.Parse(Console.ReadLine());
        volume(m,d);

    }
    
    static void volume(double n1, double n2){
        double precom =  n1 * 1;
        double precod =  n2 * 10;
        Console.WriteLine(" O Valor Cobrado Para Carregar A Massa é == R$ " + precom);
        Console.WriteLine("    ");
        Console.WriteLine(" O Valor Cobrado Pela Distância Do Destino é == R$ " + precod);
        Console.WriteLine("    ");
        Console.WriteLine(" A soma total é igual  a == R$ " + (precom + precod));
    }
}

/*int dia,mes,ano;
        Console.WriteLine("Digite uma data, nesse formato: 00/00/0000");
        string[] texto = Console.ReadLine().Split("/");
                 dia = int.Parse(texto[0]);
                 mes = int.Parse(texto[1]);
                 ano = int.Parse(texto[2]);
        if (mes == 01) Console.WriteLine(" A data é " + dia + " de janeiro de " + ano) ;
        else if (mes == 02) Console.WriteLine(" A data é " + dia + " de fevereiro de " + ano) ;
        else if (mes == 03) Console.WriteLine(" A data é " + dia + " de março de " + ano) ;
        else if (mes == 04) Console.WriteLine(" A data é " + dia + " de abril de " + ano) ;
        else if (mes == 05) Console.WriteLine(" A data é " + dia + " de maio  de " + ano) ;
        else if (mes == 06) Console.WriteLine(" A data é " + dia + " de junho de " + ano) ;
        else if (mes == 07) Console.WriteLine(" A data é " + dia + " de  julho de " + ano) ;
        else if (mes == 08) Console.WriteLine(" A data é " + dia + " de agosto de " + ano) ;
        else if (mes == 09) Console.WriteLine(" A data é " + dia + " de setembro de " + ano) ;
        else if (mes == 10) Console.WriteLine(" A data é " + dia + " de outubro de " + ano) ;
        else if (mes == 11) Console.WriteLine(" A data é " + dia + " de novembro de " + ano) ;
        else if (mes == 12) Console.WriteLine(" A data é " + dia + " de dezembro de " + ano) ;
        else Console.WriteLine("Nao e uma data valida !!!");