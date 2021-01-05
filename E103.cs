//Jorge Sacristan Beltri
//ejercicio103, escribir centrado y subrayado.

using System;

class ejercicio103
{
    static int CalcularTamanyoCadenas (String[] cadenas)
    {
        int tamanyoCadenas = 0;
        for (int z = 0; z < cadenas.Length; z++)
        {
            tamanyoCadenas += cadenas[z].Length;
            if (z != 0)
                tamanyoCadenas++;
        }

        
        return tamanyoCadenas;
    }

    static String UnirCadenas (String[] cadenas)
    {
        String cadenaUnida = "";
        for(int i = 0; i < cadenas.Length; i++)
        {
            if (i != 0)
                cadenaUnida += " ";
            cadenaUnida += cadenas[i];
           
        }
        return cadenaUnida;
    }
    static void EscribirCentradoYSubrayado(String[] cadenas)
    {
        int tamanyoCadenas = 0, posicionInicial=0;
        String cadenaUnida = "";

        tamanyoCadenas = CalcularTamanyoCadenas(cadenas);
        cadenaUnida = UnirCadenas(cadenas);
       
        posicionInicial = (80 - tamanyoCadenas) / 2;
        for (int i = 0; i < posicionInicial; i++)
            Console.Write(" ");

        Console.WriteLine(cadenaUnida);

        for (int x = 0; x < posicionInicial+cadenaUnida.Length; x++)
            if(x<posicionInicial)
                Console.Write(" ");
            else
                Console.Write("-");
   
    }
    static void Main(string[] args)
    {
        
        if (args.Length > 0)
        {
            
            EscribirCentradoYSubrayado(args);
        }
        else
        {
            Console.WriteLine("No ha introducido ningun argumento!");
        }
        
    }
}