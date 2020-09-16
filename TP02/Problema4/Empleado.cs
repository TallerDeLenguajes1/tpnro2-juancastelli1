using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema4
{
    class Empleado
    {
        int DNI;
        string nombre;
        string apellido;
        DateTime fechanac;
        struct direccion 
        {
            string calle;
            int numero;
        }
        DateTime fechaingreso;
        string profesion;
        enum estadociv {Casado,Soltero,Divorciado};
        int canthijos;
        struct universidad 
        {
            enum tienetitulo {Si,No};
            string titulo;
            string nombreuni;
        }
        int Antiguedad() 
        {
            DateTime zeroTime = new DateTime(1, 1, 1);
            DateTime today = DateTime.Today;
            TimeSpan years = today - fechaingreso;
            return (zeroTime + years).Year - 1;
        }
        int Edad()
        {
            DateTime fechaActual = DateTime.Today;
            if (fechanac > fechaActual)
            {
                Console.WriteLine("La fecha de nacimiento es mayor que la actual.");
                return -1;
            }
            else
            {
                int edad = fechaActual.Year - fechanac.Year;
                if (fechanac.Month > fechaActual.Month)
                {
                    --edad;
                }
                else
                {
                    if (fechanac.Month == fechaActual.Month)
                    {
                        if (fechanac.Day > fechaActual.Day)
                        {
                            --edad;
                        }
                    }
                }
                return edad;
            }
        }
    }
}
