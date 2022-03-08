using System;

namespace ExercicioTres.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cilindro azeite = new Cilindro();
            Console.Write("Informe a altura do cilindro: \n> ");
            azeite.altura = double.Parse(Console.ReadLine());
            Console.Write("Informe o raio do cilindro: \n> ");
            azeite.raio = double.Parse(Console.ReadLine());
            azeite.volume = azeite.CalcularVolume(azeite.altura, azeite.raio);

            Console.WriteLine("O volume do cilindro é de: " + azeite.volume.ToString("#.##") + "m³");
        }
    }
}