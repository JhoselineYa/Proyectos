using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenador_Jhoseline_grijalva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ordenador ordenador = new Ordenador("Samsung", "intel Core !13", "150Mb", "HDD", 100);
            Console.WriteLine("Descripción del Ordenador: ");
            Console.WriteLine("Marca: " + ordenador.Marca);
            Console.WriteLine("Procesador: " + ordenador.Procesador);
            Console.WriteLine("Memoria: " + ordenador.Memoria);
            Console.WriteLine("Disco duro: " + ordenador.Disco_duro);

            ordenador.mayor_capacidad(100);
            Console.WriteLine("La capacidad incremento: " + ordenador.Capacidad + "Gb mas");
            ordenador.menor_capacidad(100);
            Console.WriteLine("La capacidad reduce: " + ordenador.Capacidad + "Gb menos");

            Console.ReadKey();
        }
    }
}
