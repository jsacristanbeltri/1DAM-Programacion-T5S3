//Jorge Sacristan
//Ejercicio109, Mejora Escribircentrado

using System;

class ejercicio109
{
    static void EscribirCentradoYSubrayado(String cadena, char letra='-')
    {
        int posicionInicial = 0;

        posicionInicial = (80 - cadena.Length) / 2;
        for (int i = 0; i < posicionInicial; i++)
            Console.Write(" ");

        Console.WriteLine(cadena);

        for (int x = 0; x < posicionInicial + cadena.Length; x++)
            if (x < posicionInicial)
                Console.Write(" ");
            else
                Console.Write(letra);
    }
    static int Main(string[] args)
    {
        switch (args.Length)
        {
            case 1:
                
                EscribirCentradoYSubrayado(args[0]);
                return 0;
                //break;
            case 2:
                EscribirCentradoYSubrayado(cadena: args[0], letra: Convert.ToChar(args[1]));
                return 0;
                //break;
            default:
                Console.WriteLine("Parametros incorrectos...");
                return 1;
                //break;
        }
    }
}