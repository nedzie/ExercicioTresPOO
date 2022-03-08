using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTres.ConsoleApp
{
    internal class Cilindro
    {
        public double altura;
        public double raio;
        public double volume;

        const double pi = 3.14;

        public double CalcularVolume(double altura, double raio)
        {
            volume = pi * (raio * raio)  * altura;
            return volume;
        }
    }
}
