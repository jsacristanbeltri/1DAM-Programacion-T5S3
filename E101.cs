//Jorge Sacristan Beltri
//ejercicio101 , multiplicar valores pasados por linea de comandos. 

using System;

class ejercicio101
{
   
    static int Multiplicar (int numeroBase, int repeticiones)
    {
        //Caso Base
        if (repeticiones == 0)
            return 0;

        //Caso General
        return numeroBase + Multiplicar(numeroBase, repeticiones - 1);
    }
    
    
    static int Main(string[] args)
    {
        int resultado = 0;
        if (args.Length == 0)
        {
            Console.WriteLine("No ha indicado ningun parametro!");
            return 1;
        }
        else
        {
            if (args.Length < 2)
            {
                Console.WriteLine("No ha introducido los dos parametros necesarios!");
                return 1;
            }
            else
            {
                Console.WriteLine("Resultado: {0}", Multiplicar(Convert.ToInt32(args[0]), Convert.ToInt32(args[1])));

                return 0;
            }
                
        }
           
    }
}

