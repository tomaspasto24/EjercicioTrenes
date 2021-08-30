//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            /// <summary>
            /// 100 trenes
            /// </summary>
            Train[] almacenTrenes = new Train[100];
            for(int i=0;i<100;i++)
            {
                almacenTrenes[i] = new Train("Tren " + (i+1).ToString());
            }
            Console.WriteLine($"Número de trenes: {almacenTrenes[0].Count}");

            /// <summary>
            /// 10.000.000 trenes
            /// </summary>
            Train[] almacenTrenes2 = new Train[10000000];
            for(int j=0;j<10000000;j++)
            {
                almacenTrenes2[j] = new Train("Tren " + (j+1).ToString());
            }
            Console.WriteLine($"Número de trenes: {almacenTrenes2[0].Count}");

            /// <summary>
            /// Punto 8 y 9
            /// </summary>
            Train t1 = new Train("Last Train To London");
            Train t2 = new Train("Last Train To London");
            Train t3 = new Train("Runaway Train");

            if(t1 != t2 && t2 != t3)
            {
                Console.WriteLine("T1 y T2 son variables que comparten atributos y valores, esto las hace semejantes pero no iguales porque poseen distinta dirección de memoria.");
            }
        }
    }
}