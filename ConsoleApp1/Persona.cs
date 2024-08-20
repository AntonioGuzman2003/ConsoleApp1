using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Persona
    { 
        public Persona() { }
        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public string NombresCompletos { get; set; }

        public void AsignarNombresCompletos()
        {
            NombresCompletos = Nombre + " " + Apellidos;
        }
    
    }
}
