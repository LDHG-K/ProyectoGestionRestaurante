using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoRestaurante.World
{
    class Mesero: Empleado
    {
        public Mesero
        (String nombre, int cedula, int celular, String direccion, DateTime fechaDeIngreso, double salario) :
        base(nombre, cedula, celular, direccion, fechaDeIngreso, salario)
        {

        }


    }
}
