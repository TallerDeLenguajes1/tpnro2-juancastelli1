using System;
using NLog;

namespace Problema2b
{
    class Program
    {
        private static readonly Logger loggeador = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            float a;
            float b;
            Console.WriteLine("Escriba su dividendo");
            try
            {
                loggeador.Info("Se esta por cargar la variable a");
                a = int.Parse(Console.ReadLine());
                loggeador.Info("Se cargo la variable a");
                Console.WriteLine("Escriba su divisor");
                loggeador.Info("Se esta por cargar la variable b");
                b = int.Parse(Console.ReadLine());
                loggeador.Info("Se cargo la variable b");
                Console.WriteLine(DivisionSegura(a, b));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Se intento dividir por cero");
                loggeador.Fatal("Se intento dividir por cero");
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

        private static float DivisionSegura(float m, float n)
        {
            if (n == 0)
            {
                throw new DivideByZeroException();
            }
            return (m / n);
        }
    }
}
