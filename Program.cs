using System;

namespace MemeToNervoso
{
    class Program
    {
        static void Main(string[] args)
{       
    string fraseDigitada, fraseMemeEstouNervoso;

    Console.Write("Usuario, o que pensa sobre mim? ");
    fraseDigitada = Console.ReadLine();

    fraseMemeEstouNervoso = $"{fraseDigitada}...NÃO PERA. \n estou nervoso";

    Console.WriteLine(fraseMemeEstouNervoso);
}
    }
}