using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Rectangulo
    {
        public int Base { get; set; }

        public int Altura { get; set; }

        public int Perimetro { get; set; }

        public int Area { get; set; }

        public double x1 { get; set; }
        public double x2 { get; set; }

        public double y1 { get; set; }

        public double y2 { get; set; } 
        
        public int CalcularArea()
        {
            return Base * Altura;
        }

        public int CalcularBase()
        {
            return Area / Altura;
        }

        public int CalcularAltura()
        {
            return Area / Base;
        }
        public int CalcularPerimetro()
        {
            return 2 * (Base + Altura);
        }
    }
}
