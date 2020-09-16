using System;
using System.Collections.Generic;
using System.Text;

namespace TP01
{
    class Tareas
    {
        private int ID;
        private string Descripcion;
        private int Duracion;

        public int ID1 { get => ID; set => ID = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
        public int Duracion1 { 
            get => Duracion;
            set 
            {
                if (value > 9 & value < 100) 
                {
                    Duracion = value;
                }
                else 
                {
                    Duracion = 10;
                }
            }
        }
        public Tareas() 
        {
            ID = -1;
            Descripcion = " ";
            Duracion = 50;
        }
        public Tareas(int idT, string DescripT, int DurT)
        {
            ID = idT;
            Descripcion = DescripT;
            Duracion1 = DurT;
        }
        public void MostrarTarea() 
        {
            Console.Write("ID:" + ID + "\n");
            Console.Write("Descripcion:" + Descripcion + "\n");
            Console.Write("Duracion:" + Duracion + "\n");
        }
    }
}
