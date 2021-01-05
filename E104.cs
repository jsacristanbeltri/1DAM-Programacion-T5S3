//Jorge Sacristan
//ejercicio104, Funcion contar Mayusculas.

using System;

class ejercicio104
{
    static void ContarMm (String texto, ref ushort mays, ref ushort mins)
    {
        for(int i = 0; i < texto.Length; i++)
        {
            if ((int)texto[i]>=97 && (int)texto[i]<=122)
            {
                Console.WriteLine("Ascii de {0} es {1}", texto[i], (int)texto[i]);
                mins++;
            }
            if ((int)texto[i] >= 65 && (int)texto[i] < 090)
            {
                Console.WriteLine("Ascii de {0} es {1}", texto[i], (int)texto[i]);
                mays++;
            }
        }
    }

    static string UnirTextos(String[] cadenas)
    {
        String cadenaUnida = "";

        
            for (int i = 0; i < cadenas.Length; i++)
            {
                if (i != 0)
                    cadenaUnida += " ";

                cadenaUnida += cadenas[i];
            }

            return cadenaUnida;
    }
    static void Main(string[] args)
    {
        ushort mays = 0, mins = 0;
        string cadenaUnida = "";

        if (args.Length > 0)
        {
            cadenaUnida = UnirTextos(args);
            ContarMm(cadenaUnida, ref mays, ref mins);
            Console.WriteLine("Mayúsculas: " + mays + ", minúsculas: " + mins);
        }
        else
            Console.WriteLine("No ha introducido parametros!");
    }
}