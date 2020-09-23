using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema4
{
    public enum estadociv { Casado, Soltero, Divorciado };
    public enum tienetitulo { Si, No, SinEspecificar };
    public struct universidad
    {
        public tienetitulo contitulo;
        public string titulo;
        public string nombreuni;
    }
    public struct direccion
    {
        public string calle;
        public int numero;
    }
    class Empleado
    {
        //miembros
        int DNI;
        string nombre;
        string apellido;
        DateTime fechanac;
        direccion direc;
        DateTime fechaingreso;
        universidad datosuni;
        string profesion;
        estadociv estcivil;
        int canthijos;
        public Empleado(int DNIE, string nombreE, string apellidoE, DateTime fechanacE, 
            direccion direcE, DateTime fechaingresoE, universidad datosuniE, string profesionE,
            estadociv estcivilE, int canthijosE)
        {
            DNI1 = DNIE;
            Nombre = nombreE;
            Apellido = apellidoE;
            Fechanac = fechanacE;
            Direc = direcE;
            Fechaingreso = fechaingresoE;
            Datosuni = datosuniE;
            Profesion = profesionE;
            Estcivil = estcivilE;
            Canthijos = canthijosE;
        }

        public int DNI1 { get => DNI; set => DNI = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime Fechanac { get => fechanac; set => fechanac = value; }
        public direccion Direc { get => direc; set => direc = value; }
        public DateTime Fechaingreso { get => fechaingreso; set => fechaingreso = value; }
        public universidad Datosuni { get => datosuni; set => datosuni = value; }
        public string Profesion { get => profesion; set => profesion = value; }
        public estadociv Estcivil { get => estcivil; set => estcivil = value; }
        public int Canthijos { get => canthijos; set => canthijos = value; }

        public int Antiguedad() 
        {
            DateTime zeroTime = new DateTime(1, 1, 1);
            DateTime today = DateTime.Today;
            TimeSpan years = today - Fechaingreso;
            return (zeroTime + years).Year - 1;
        }
        public int Edad()
        {
            DateTime fechaActual = DateTime.Today;
            if (Fechanac > fechaActual)
            {
                Console.WriteLine("La fecha de nacimiento es mayor que la actual.");
                return -1;
            }
            else
            {
                int edad = fechaActual.Year - Fechanac.Year;
                if (Fechanac.Month > fechaActual.Month)
                {
                    --edad;
                }
                else
                {
                    if (Fechanac.Month == fechaActual.Month)
                    {
                        if (Fechanac.Day > fechaActual.Day)
                        {
                            --edad;
                        }
                    }
                }
                return edad;
            }
        }
        public double salario() 
        {
            //Tomo sueldo basico como 50000
            double sueldobasic = 50000;
            double descuento = sueldobasic * 0.15;
            double adicional;
            if (this.Antiguedad() > 20)
            {
                adicional = sueldobasic * 0.25;
            }
            else 
            {
                adicional = sueldobasic * (this.Antiguedad() / 10);
            }
            return (sueldobasic + adicional - descuento);
        }
    }
}
