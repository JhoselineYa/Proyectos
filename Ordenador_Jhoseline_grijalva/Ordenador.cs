using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenador_Jhoseline_grijalva
{
    public class Ordenador
    {
        public Ordenador(string marca, string procesador, string memoria, string disco_duro, int capacidad)
        {
            this.Marca = marca;
            this.Procesador = procesador;
            this.Memoria = memoria;
            this.Disco_duro = disco_duro;
        }

        public string Marca;
        public string Procesador;
        public string Memoria;
        public string Disco_duro;
        public int Capacidad;

        public void mayor_capacidad(int M_capacidad)
        {
            Console.WriteLine("La capacidad incremento: " + M_capacidad + "Gb mas");
            this.Capacidad = Convert.ToInt32(M_capacidad + 100);
        }

        public void menor_capacidad(int m_capacidad)
        {
            Console.WriteLine("La capacidad reduce: " + m_capacidad + "Gb menos");
            this.Capacidad = Convert.ToInt32(m_capacidad + (-100));
        }
    }
}