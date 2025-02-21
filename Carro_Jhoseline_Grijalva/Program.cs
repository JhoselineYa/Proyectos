using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro_Jhoseline_Grijalva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            carro carro = new carro("Toyota", "Corola", "20km/h", "90km/h", 0);
            Console.WriteLine("Descripcion del Coche:");
            Console.WriteLine("Marca:" + carro.Marca);
            Console.WriteLine("Modelo:" + carro.Modelo);
            Console.WriteLine("Velocidad actual:" + carro.Velocidad_actual);
            Console.WriteLine("Velocidad maxima:" + carro.Velocidad_maxima);

            carro.acelera(10);
            Console.WriteLine("El carro acelera:" + carro.Velocidad + "Km/h");
            carro.decelerar(10);
            Console.WriteLine("El carro decelera:" + carro.Velocidad + "Km/h");


            carrofreno carrofreno = new carrofreno("Toyota", "Corola", "20km/h", "90km/h", 0, 0);

            carrofreno.Frenar(0);
            Console.WriteLine("El carro frena:" + carrofreno.Freno + "Km/h");

            Console.ReadKey();
        }
    }
}