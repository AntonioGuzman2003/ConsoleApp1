using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int area = 0;
            int perimetro = 0;
            int altura = 0;

            Persona persona = new Persona
            {
                Name = "Antonio",
                LastName = "Guzman"

            };

            persona.AsignarNombresCompletos();
            Console.WriteLine(persona);

           

            Rectangulo rectangulo = new Rectangulo
            {
                x1 = 0,
                x2 = 8,
                y1 = 0,
                y2 = 8
            };

            area = rectangulo.CalcularArea();
            altura = rectangulo.CalcularAltura();
            perimetro = rectangulo.CalcularPerimetro();

            Console.WriteLine("El area es: ");
            Console.WriteLine(area);

            Console.WriteLine("El perimetro es: ");
            Console.WriteLine(perimetro);


            Console.WriteLine("La altura es: ");
            Console.WriteLine(altura);

           

            Console.WriteLine("Hola mundo");
            Console.Read();
        }
    }
}


