//Jorge Sacristan Beltri
//Ejercicio102 ,version actualizada del programa: 
//almacenar 1000 programas de ordenador. 

using System;

class Ejercicio102
{
    struct versionPrograma
    {
        public byte mesLanzamiento;
        public ushort anyoLanzamiento;
    }

    struct datosPrograma
    {
        public String Nombre;
        public String Descripcion;
        public versionPrograma vPrograma;
    }
    
    static void MostrarMenu()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Añadir datos de un nuevo programa.");
        Console.WriteLine("2. Mostrar los nombres de todos los programas almacenados. ");
        Console.WriteLine("3. Ver todos los datos de un cierto programa. ");
        Console.WriteLine("4. Modificar una ficha. ");
        Console.WriteLine("5. Borrar un cierto dato.");
        Console.WriteLine("T. Salir");
    }
    
    static char PedirOpcion()
    {
        char opcionMenu;
        Console.Write("Seleccione una opcion del menu: ");
        opcionMenu = Convert.ToChar(Console.ReadLine());
        return opcionMenu;
    }


    static ushort Anyadir(datosPrograma[] programas, ushort cantidadProgramas)
    {
        if (cantidadProgramas < 1000)
        { //Si que hay hueco
            Console.Write("Introduzca el nombre:");
            programas[cantidadProgramas].Nombre = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Introduzca la descripcion:");
            programas[cantidadProgramas].Descripcion = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Introduzca el mes de lanzamiento(numero): ");
            programas[cantidadProgramas].vPrograma.mesLanzamiento = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Introduzca el año de lanzamiento: ");
            programas[cantidadProgramas].vPrograma.anyoLanzamiento = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("");
            cantidadProgramas++;
        }
        else
            Console.WriteLine("Maximo de programas alcanzado(1000)!");

        return cantidadProgramas;
    }

    static void MostrarTodos(datosPrograma[] programas, ushort cantidadProgramas)
    {
        for (int x = 0; x < cantidadProgramas; x++)
        {
            Console.WriteLine("{0}: Nombre:{1}", x + 1, programas[x].Nombre);
            if (x % 20 == 0 && x != 0)
            {
                Console.WriteLine("Pulse Intro para continuar....");
                Console.ReadLine();
            }

        }
    }

    static void MostrarDatos(datosPrograma[] programas, ushort cantidadProgramas)
    {
        ushort opcionPrograma = 0;

        if (cantidadProgramas == 0)
            Console.Write("No se han introducido programas por lo que no se puede mostrar ninguno ");
        else
        {
            Console.Write("Que programa desea ver? ");
            opcionPrograma = Convert.ToUInt16(Console.ReadLine());

            if (opcionPrograma <= 0 || opcionPrograma > cantidadProgramas)
                Console.Write("Opcion incorrecta. ");

            else
            {
                Console.WriteLine("Nombre: {0}", programas[opcionPrograma - 1].Nombre);
                Console.WriteLine("Descripcion: {0}", programas[opcionPrograma - 1].Descripcion);
                Console.WriteLine("Mes de lanzamiento: {0}", programas[opcionPrograma - 1].vPrograma.mesLanzamiento);
                Console.WriteLine("Año de lanzamiento: {0}", programas[opcionPrograma - 1].vPrograma.anyoLanzamiento);
            }
        }
    }

    static void ModificarPrograma(datosPrograma[] programas,ushort cantidadProgramas)
    {
        ushort opcionPrograma = 0;

        if (cantidadProgramas == 0)
            Console.Write("No se han introducido programas por lo que no se puede modificar ninguno ");
        else
        {
            Console.Write("Que programa desea modificar? ");
            opcionPrograma = Convert.ToUInt16(Console.ReadLine());

            if (opcionPrograma <= 0 || opcionPrograma > cantidadProgramas)
                Console.Write("Opcion incorrecta. ");

            else
            {
                Console.WriteLine("Nombre: {0}", programas[opcionPrograma - 1].Nombre);
                Console.WriteLine("Descripcion: {0}", programas[opcionPrograma - 1].Descripcion);
                Console.WriteLine("Mes de lanzamiento: {0}", programas[opcionPrograma - 1].vPrograma.mesLanzamiento);
                Console.WriteLine("Año de lanzamiento: {0}", programas[opcionPrograma - 1].vPrograma.anyoLanzamiento);

                Console.Write("Nuevo Nombre:");
                programas[opcionPrograma - 1].Nombre = Console.ReadLine();
                Console.Write("Nueva Descripcion: ");
                programas[opcionPrograma - 1].Descripcion = Console.ReadLine();
                Console.Write("Nuevo Mes de lanzamiento: ");
                programas[opcionPrograma - 1].vPrograma.mesLanzamiento = Convert.ToByte(Console.ReadLine());
                Console.Write("Nuevo Año de lanzamiento: ");
                programas[opcionPrograma - 1].vPrograma.anyoLanzamiento = Convert.ToUInt16(Console.ReadLine());
            }
        }
    }

    static ushort BorrarPrograma(datosPrograma[] programas, ushort cantidadProgramas)
    {
        ushort opcionPrograma = 0;

        if (cantidadProgramas == 0)
        {
            Console.Write("No se han introducido programas por lo que no se puede borrar ninguno ");
            return cantidadProgramas;
        }
            
        else
        {
            Console.Write("Que programa desea borrar? ");
            opcionPrograma = Convert.ToUInt16(Console.ReadLine());

            if (opcionPrograma <= 0 || opcionPrograma > cantidadProgramas)
                Console.Write("Opcion incorrecta. ");

            else
            {
                for (int x = opcionPrograma - 1; x < cantidadProgramas; x++)
                {
                    if (x == cantidadProgramas - 1)
                    {
                        programas[x].Nombre = "";
                        programas[x].Descripcion = "";
                        programas[x].vPrograma.mesLanzamiento = 0;
                        programas[x].vPrograma.anyoLanzamiento = 0;
                    }
                    else
                        programas[x] = programas[x + 1];
                }
            }
            cantidadProgramas--;
            return cantidadProgramas;
        }
        
    }
    static void Main()
    {
        bool salir = false;
        char opcionMenu;
        datosPrograma[] programas = new datosPrograma[1000];
        ushort cantidadProgramas = 0;



        Console.WriteLine("DB PROGRAMAS:");
        while (salir != true)
        {
            MostrarMenu();
            opcionMenu=PedirOpcion();
           
            switch (opcionMenu)
            {
                case '1':
                    cantidadProgramas=Anyadir(programas, cantidadProgramas);
                    break;
                case '2': MostrarTodos(programas, cantidadProgramas); break;
                case '3': MostrarDatos(programas, cantidadProgramas); break;
                case '4': ModificarPrograma(programas, cantidadProgramas); break;
                case '5':
                    cantidadProgramas=BorrarPrograma(programas, cantidadProgramas);
                    break;    
                case 'T':
                    salir = true;
                    break;
            }
        }
        Console.WriteLine("FIN");
    }
}
