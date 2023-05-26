using System;

class Program
{
    static void Main() {
        Console.WriteLine("Digite sua data de nascimento no formato dia/mes/ano");
        string [] entrada = Console.ReadLine().Split("/");
        data( string entrada);

    }
    
    static void data(string texto){
        int dia,mes,ano;
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
    }
}