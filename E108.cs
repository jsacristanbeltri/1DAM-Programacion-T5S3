//Jorge Sacristan Beltri
//Ejercicio 108

using System;

class ejercicio108
{
    static bool EsPrimo(int numero)
    {
        bool resultado = true;

        for (int i = numero - 1; i > 1; i--)
        {
            if (numero % i == 0)
                resultado = false;
        }

        if (numero == 1)
            resultado = false;

        return resultado;
    }
    static String RotarNumero(String numero)
    {
        numero = numero.Substring(1) + numero[0];
        return numero;
    }
    static bool EsPrimoCircular(int n)
    {
        String numero = n.ToString();
        int tamanyoNumero = numero.Length;
        bool resultado = true;

        for (int i = 0; i < numero.Length && resultado != false; i++)
        {
            if (i == 0)
            { //No roto. 
                resultado = EsPrimo(Convert.ToInt32(numero));
            }
            else
            { //Roto
                numero = RotarNumero(numero);
                resultado = EsPrimo(Convert.ToInt32(numero));
            }
        }
        return resultado;
    }
    static long McdR(long A, long B)
    {
        //Caso base
        if (B == 0)
            return A;
        else//Caso General
        {
            return McdR(B, A % B);
        }
    }
    static void ContarMm(String texto, ref ushort mays, ref ushort mins)
    {
        for (int i = 0; i < texto.Length; i++)
        {
            if ((int)texto[i] >= 97 && (int)texto[i] <= 122)
                mins++;

            if ((int)texto[i] >= 65 && (int)texto[i] < 090)
                mays++;
        }
    }
    static void EscribirCentradoYSubrayado(String cadena)
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
                Console.Write("-");
    }
    static int Main(string[] args)
    {
        ushort mays = 0, mins = 0;
        if (args.Length > 0)
        {
            switch (args[0])
            {
                case "cprime":
                    if (args.Length == 2)
                    {
                        if (EsPrimoCircular(Convert.ToInt32(args[1])))
                            Console.WriteLine("{0} es un primo circular",
                                Convert.ToInt32(args[1]));
                        else
                            Console.WriteLine("{0} no es un primo circular",
                                Convert.ToInt32(args[1]));

                        return 0;
                    }
                    else
                    {
                        Console.WriteLine("Faltan parametros");
                        return 2;
                    }

                    break;
                case "mm":
                    if (args.Length == 2)
                    {
                        ContarMm(args[1], ref mays, ref mins);
                        Console.WriteLine("Mayúsculas: {0}, " +
                            "Minúsculas: {1}", mays, mins);
                        return 0;
                    }
                    else
                    {
                        Console.WriteLine("Faltan parametros");
                        return 2;
                    }
                  
                    break;
                case "centrar":
                    if (args.Length == 2)
                    {
                        EscribirCentradoYSubrayado(args[1]);
                        return 0;
                    }
                    else
                    {
                        Console.WriteLine("Faltan parametros");
                        return 2;
                    }
                    

                    break;
                case "mcd":
                    if (args.Length == 3)
                    {
                        Console.WriteLine("El maximo comun divisor de {0} y" +
                            " {1} es {2}", args[1], args[2],
                        McdR(Convert.ToInt64(args[1]), Convert.ToInt64(args[2])));
                        return 0;
                    }
                    else
                    {
                        Console.WriteLine("Faltan parametros");
                        return 2;
                    }
                  
                    break;
                default:
                    Console.WriteLine("Uso: cprime / mm / centrar / mcd");
                    return 1;
                    break;
            }
        }
        else
        {
            
            Console.WriteLine("Uso: cprime / mm / centrar / mcd");
            return 1;
        }
            

    }
}