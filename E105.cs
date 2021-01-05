//Jorge Sacristan Beltri
//ejercicio105, MCD iterativo y con recursividad. 

using System;

class ejercicio105
{
    static long Mcd(long A, long B)
    {
        long resto = A, cociente = 0, divisor=0, dividendo=0, mCD=0;
        if (A > B)
        {
            dividendo = A;
            divisor = B;
        }
        else
        {
            dividendo = B;
            divisor = A;
        }

        while (resto != 0)
        {
            if (dividendo % divisor == 0)
            {
                mCD = divisor;
                resto = 0;
            }

            else
            {
                resto = dividendo % divisor;
                cociente = dividendo / divisor;
                dividendo = divisor;
                divisor = resto;

            }
        }
        return mCD;
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

    static void Main()
    {
        Console.WriteLine(Mcd(30, 18));

        Console.WriteLine(McdR(30, 18));
    }
}