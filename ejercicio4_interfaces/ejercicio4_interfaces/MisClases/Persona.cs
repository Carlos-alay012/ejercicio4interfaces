using ejercicio4_interfaces.MisInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4_interfaces.MisClases
{
    internal class Persona : IPersona
    {
        public string Nombre {get;}
        public int Edad {get;}
        int contador;

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
            int contador = 0;
        }
        public void cumplirAños()
        {
            contador++;
            Console.WriteLine($"\tAhora tienes {Edad}", Edad+contador);
        }

        public void DecirMinombre()
        {
            Console.WriteLine($"\tMi nombre es {Nombre}");
        }
    }
}
