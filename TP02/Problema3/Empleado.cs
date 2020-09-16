using System;
using System.Collections.Generic;
using System.Text;

namespace TP01
{
    class Empleado
    {
        private int DNI;
        private string nombre;
        private  string apellido;
        private List<Tareas> TareasPendientes;
        private List<Tareas> TareasRealizadas;
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int DNI1 { get => DNI; set => DNI = value; }
        internal List<Tareas> TareasRealizadas1 { get => TareasRealizadas; set => TareasRealizadas = value; }
        internal List<Tareas> TareasPendientes1 { get => TareasPendientes; set => TareasPendientes = value; }

        public Empleado(int DNIE, string nombreE, string apellidoE, List<Tareas> tareas, List<Tareas> tareasreal)
        {
            DNI = DNIE;
            nombre = nombreE;
            apellido = apellidoE;
            TareasPendientes = tareas;
            TareasRealizadas = tareasreal;
        }
        public void PasarTarea(int id) 
        {
            TareasRealizadas.Add(Helper.BusquedaPorId(id,TareasPendientes));
            TareasPendientes.RemoveAt(Helper.ContarPosicion(id, TareasPendientes));
        }
    }
}
