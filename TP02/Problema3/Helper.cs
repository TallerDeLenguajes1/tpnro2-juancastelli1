using System;
using System.Collections.Generic;
using System.Text;

namespace TP01
{
    static class Helper
    {
        public static Tareas BusquedaPorId(int idTarea, List<Tareas> listatarea)
        {
            foreach (Tareas tarea in listatarea) 
            {
                if (tarea.ID1 == idTarea) 
                {
                    return tarea;
                }
            }
            Console.WriteLine("No Se Encontro la Tarea");
            return new Tareas();
        }
        public static int ContarPosicion(int idTarea, List<Tareas> listatarea)
        {
            int t = 0;
            foreach (Tareas tarea in listatarea)
            {
                if (tarea.ID1 == idTarea)
                {
                    return t;
                }
                t++;
            }
            return -1;
        }
        public static Tareas BusquedaPorPalabra(string palabra, List<Tareas> listatarea)
        {
            foreach (Tareas tarea in listatarea)
            {
                if (tarea.Descripcion1.Contains(palabra))
                {
                    return tarea;
                }
            }
            Console.WriteLine("No Se Encontro la Tarea");
            return new Tareas();
        }
    }
}
