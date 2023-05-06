using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4_interfaces.MisInterfaces
{
    internal interface IPersona
    {
        String Nombre { get; }
        int Edad { get; }
        void DecirMinombre();
        void cumplirAños();
    }
}
