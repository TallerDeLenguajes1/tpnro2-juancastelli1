using System;
using NLog;
using NLog.Fluent;

namespace TP02
{
    class Program
    {
        private static readonly Logger loggeador = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Escriba un numero entero:");
            try
            {
                loggeador.Info("Se esta por cargar la variable");
                n = int.Parse(Console.ReadLine());
                loggeador.Info("Se cargo la variable");
                Console.WriteLine(n * n);
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("Error: Se intento cargar otro formato de variable");
                loggeador.Fatal("Se intento cargar otro formato de variable");
                loggeador.Fatal(ex.ToString());
            }
            catch (Exception ex2) 
            {
                Console.WriteLine("Error: Error desconocido");
                loggeador.Fatal("Error desconocido");
                loggeador.Fatal(ex2.ToString());
            }
            loggeador.Info("Finalizo el programa");
        }
    }
}
