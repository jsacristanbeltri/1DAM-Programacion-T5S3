//Jorge Sacristan Beltri
//ejercicio106, primo circular. 

using System;

class ejercicio106
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

    static String RotarNumero (String numero)
    {
        numero = numero.Substring(1) + numero[0];
        return numero;
    }
    static bool EsPrimoCircular (int n)
    {
        String numero = n.ToString();
        int tamanyoNumero = numero.Length;
        bool resultado = true;

        for(int i=0;i<numero.Length && resultado != false; i++)
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
    
    static void Main(string[] args)
    {
        if (args.Length>0)
        {
            if (EsPrimoCircular(Convert.ToInt32(args[0])))
                Console.Write("{0} es primo circular", Convert.ToInt32(args[0]));
            else
                Console.Write("{0} NO es primo circular", Convert.ToInt32(args[0]));

        }
        else
        {
            if (args.Length == 0)
                Console.WriteLine("No has introducido parametros!");
            else
                Console.WriteLine("Has introducido parametros de mas!");
        }
    }
}