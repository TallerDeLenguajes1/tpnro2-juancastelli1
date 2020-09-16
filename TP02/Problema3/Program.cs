using System;
using System.Collections.Generic;

namespace TP01
{
    class Program
    {
        private static readonly Logger loggeador = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            int n = 0;
            string nombreA = " ";
            string apellidoA = " ";
            int DNIA = 0;
            List<Tareas> tareasA = new List<Tareas>();
            List<Tareas> tareasReal = new List<Tareas>();
            Console.WriteLine("Ingrese nombre Nuevo Empleado");
            try
            {
                nombreA = Console.ReadLine();
                Console.WriteLine("Ingrese apellido Nuevo Empleado");
                apellidoA = Console.ReadLine();
                Console.WriteLine("Ingrese DNI Nuevo Empleado");
                DNIA = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de Tareas a Cargar");
                n = int.Parse(Console.ReadLine());
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("Error: Se intento cargar otro formato de alguna variable");
                loggeador.Fatal("Se intento cargar otro formato de alguna variable");
                loggeador.Fatal(ex.ToString());
            }
            catch (Exception ex2)
            {
                Console.WriteLine("Error: Error desconocido");
                loggeador.Fatal("Error desconocido");
                loggeador.Fatal(ex2.ToString());
            }     
            int IDT;
            string DESCT;
            int DURT;
            try
            {
                for (int i = 0; i < n; i++)
                {
                    IDT = i;
                    Console.WriteLine("Ingrese Descripcion Tarea " + i + ":");
                    DESCT = Console.ReadLine();
                    Console.WriteLine("Ingrese Duracion Tarea " + i + ":");
                    DURT = int.Parse(Console.ReadLine());
                    while (DURT < 9 | DURT > 100)
                    {
                        Console.WriteLine("No es una duracion valida. Ingrese Otra");
                        DURT = int.Parse(Console.ReadLine());
                    };
                    tareasA.Add(new Tareas(IDT, DESCT, DURT));

                }
            }
            catch (Exception ex2)
            {
                Console.WriteLine("Error: Error desconocido");
                loggeador.Fatal("Error desconocido");
                loggeador.Fatal(ex2.ToString());
            }
            Empleado EmpleadoE = new Empleado(DNIA, nombreA, apellidoA, tareasA, tareasReal);
            Console.WriteLine("Tareas Pendientes:");
            foreach (Tareas T in EmpleadoE.TareasPendientes1)
            {
                T.MostrarTarea();
            }
            for (int h = 0; h < n; h++)
            {
                Console.Write("Tarea "+ h +":" + "\n");
                EmpleadoE.TareasPendientes1[h].MostrarTarea();
                Console.Write("Esta tarea fue realizada?(S/N):");
                if (Console.ReadLine() == "S")
                {
                    EmpleadoE.PasarTarea(EmpleadoE.TareasPendientes1[h].ID1);
                    n--;
                    h--;
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("Tareas Realizadas:");
            foreach (Tareas T in EmpleadoE.TareasRealizadas1)
            {
                T.MostrarTarea();
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("Tareas Pendientes:");
            foreach (Tareas T in EmpleadoE.TareasPendientes1)
            {
                T.MostrarTarea();
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("Elija una palabra para buscar en las tareas Realizadas:");
            string palabra = Console.ReadLine();
            Helper.BusquedaPorPalabra(palabra, EmpleadoE.TareasRealizadas1).MostrarTarea();
            Console.WriteLine("Elija una palabra para buscar en las tareas Pendientes:");
            string palabra1 = Console.ReadLine();
            Helper.BusquedaPorPalabra(palabra1, EmpleadoE.TareasPendientes1).MostrarTarea();
        }
    }
}
