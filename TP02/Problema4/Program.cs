using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Problema4
{
    class Program
    {
        private static readonly Logger loggeador = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            List < Empleado > ListaEmpleados = new List<Empleado>();
            int n;
            Console.Write("Cuantos trabajadores quiere cargar?");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) 
            {
                try
                {
                    Console.Write("Ingrese DNI empleado:");
                    int DNIE = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese nombre empleado:");
                    string nombreE = Console.ReadLine();
                    Console.Write("Ingrese apellido empleado:");
                    string apellidoE = Console.ReadLine();
                    Console.Write("Ingrese fecha de nacimiento empleado:");
                    DateTime fechanacE = DateTime.Parse(Console.ReadLine());
                    direccion direcE;
                    Console.Write("Ingrese calle del empleado:");
                    direcE.calle = Console.ReadLine();
                    Console.Write("Ingrese numero de casa del empleado:");
                    direcE.numero = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese fecha de ingreso empleado:");
                    DateTime fechaingresoE = DateTime.Parse(Console.ReadLine());
                    universidad datosuniE;
                    Console.Write("El empleado tiene titulo?(Si, No):");
                    switch (Console.ReadLine())
                    {
                        case "Si":
                            datosuniE.contitulo = tienetitulo.Si;
                            break;
                        case "No":
                            datosuniE.contitulo = tienetitulo.No;
                            break;
                        default:
                            datosuniE.contitulo = tienetitulo.SinEspecificar;
                            break;
                    }
                    Console.Write("Que Titulo Tiene?:");
                    datosuniE.titulo = Console.ReadLine();
                    Console.Write("Donde Lo Obtuvo?:");
                    datosuniE.nombreuni = Console.ReadLine();
                    Console.Write("Profesion Del Empleado?:");
                    string profesionE = Console.ReadLine();
                    estadociv estcivilE;
                    Console.Write("Elija estado civil:\n1. Soltero\n2. Casado\n3. Divorciado");
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            estcivilE = estadociv.Soltero;
                            break;
                        case 2:
                            estcivilE = estadociv.Casado;
                            break;
                        case 3:
                            estcivilE = estadociv.Divorciado;
                            break;
                        default:
                            estcivilE = estadociv.Soltero;
                            break;
                    }
                    Console.Write("Ingrese Cantidad De Hijos:");
                    int canthijosE = int.Parse(Console.ReadLine());
                    ListaEmpleados.Add(new Empleado(DNIE, nombreE, apellidoE, fechanacE, direcE,
                        fechaingresoE, datosuniE, profesionE, estcivilE, canthijosE));
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
            }
            foreach (Empleado emp in ListaEmpleados) 
            {
                Console.Write("Empleado de DNI:" + emp.DNI1 + "\n");
                Console.Write("Nombre:" + emp.Nombre + "\n");
                Console.Write("Apellido:" + emp.Apellido + "\n");
                Console.Write("Edad:" + emp.Edad() + "\n");
                Console.Write("Antiguedad:" + emp.Antiguedad() + "\n");
                Console.Write("Salario:" + emp.salario() + "\n");
                Console.Write("\n");
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
