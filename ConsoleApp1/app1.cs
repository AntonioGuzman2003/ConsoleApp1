using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class app1
    {
        static void Main(string[] args)
        {
            int area = 0;
            int perimetro = 0;


            Persona persona = new Persona
            {
                Nombres = "Antonio",
                Apellidos = "Guzman"

            };

            persona.AsignarNombresCompletos();
            Console.WriteLine("El nombre es: ");
            Console.WriteLine(persona.AsignarNombresCompletos);

            Rectangulo rectangulo = new Rectangulo();
            rectangulo.Base = 10;
            rectangulo.Altura = 20;

            area = rectangulo.CalcularArea();

            perimetro = rectangulo.CalcularPerimetro();

            Console.WriteLine("El area es: ");
            Console.WriteLine(area);

            Console.WriteLine("El perimetro es: ");
            Console.WriteLine(perimetro);

            Console.WriteLine("Hola mundo");
            Console.Read();
        }
    }
}
