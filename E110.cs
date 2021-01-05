//Jorge Sacristan
//Ejercicio110

using System;

class Ejercicio110
{
    static bool EsPrimo(long numero)
    {
        bool resultado = true;

        for (long i = numero - 1; i > 1 && resultado; i--)
        {
            if (numero % i == 0)
                return false;
        }

        if (numero == 1)
            return false;

        return true;

    }

    static bool EsSemiPrimo(long numero)
    {
        long contadorDivisiones = 0;
        for (long i = 1; i < numero || numero != 1; i++)
        {
            if (EsPrimo(i) && numero % i == 0)
            {
                numero = numero / i;
                contadorDivisiones++;
                i--;
                if (contadorDivisiones == 2)
                    return true;
            }
        }
        
      
        return false;
    }

    static void MostrarSemiprimos(long numero1, long numero2)
    {
        if (numero1 < numero2)
        {
            for (long x = numero1; x <= numero2; x++)
            {
                if (EsSemiPrimo(x))
                {
                    Console.Write("{0}, ", x);
                }
            }
        }
        else
        {
            for (long x = numero2; x <= numero1; x++)
            {
                if (EsSemiPrimo(x))
                {
                    Console.Write("{0}, ", x);
                }
            }
        }
    }


    static void Main(string[] args)
    {
        long numero1, numero2;
        DateTime comienzo = DateTime.Now;

        if (args.Length < 3 || args.Length > 0)
        {
            if(Int64.TryParse(args[0], out numero1)&& Int64.TryParse(args[1], out numero2))
                MostrarSemiprimos(numero1, numero2);
            else
                Console.WriteLine("Numeros no validos");

        }
        else
            Console.WriteLine("Parametros incorrectos...");
        Console.WriteLine("Inserte el 1º numero: ");
       
        /*if (Int64.TryParse(Console.ReadLine(), out numero1))
        {
            Console.WriteLine("Inserte el 2º numero: ");
            if (Int64.TryParse(Console.ReadLine(), out numero2))
            {
                MostrarSemiprimos(numero1, numero2);
            }
            else
                Console.WriteLine("El 2º numero no es un numero valido");
        }
        else
            Console.WriteLine("No 1º numero no es un numero valido");*/

        Console.WriteLine("Tiempo transcurrido: " +
            (DateTime.Now - comienzo));
    }
}