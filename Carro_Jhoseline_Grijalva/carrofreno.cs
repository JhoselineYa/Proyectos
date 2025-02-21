
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro_Jhoseline_Grijalva
{
    public class carrofreno : carro
    {
        public carrofreno(string marca, string modelo, string velocidad_maxima, string velocidad_actual, int velocidad, int freno)
            : base(marca, modelo, velocidad_actual, velocidad_maxima, velocidad)
        {
            this.Freno = freno;
        }

        public int Freno;
        public void Frenar(int frenar)
        {
            Console.WriteLine();
            this.Freno = Convert.ToInt32(frenar = 0);
        }

    }
}

