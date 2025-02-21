
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona_Jhoseline_Grijalva
{
    public class Personanadadora : Persona
    {
        public Personanadadora(string ojos, string altura, string peso, string sexo) : base(ojos, altura, peso, sexo)
        {
        }

        public void Nadar()
        {
            Console.WriteLine("Nadando para volver al peso ideal");
            this.Peso = "85";
        }

    }
}