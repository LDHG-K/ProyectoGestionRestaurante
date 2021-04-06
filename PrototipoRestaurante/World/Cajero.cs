using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoRestaurante.World
{
    class Cajero: Empleado
    {
        static List<Cliente> clientes = new List<Cliente>();

        public Cajero
        (String nombre, int cedula, int celular, String direccion, DateTime fechaDeIngreso, double salario) :
        base(nombre, cedula, celular, direccion, fechaDeIngreso, salario)
        {

        }

        public static void agregarCliente(String nombre, int cedula, int celular, String correo )
        {
            Cliente nuevo = new Cliente(nombre, cedula, celular, correo);
            clientes.Add(nuevo);
        }


        public static Cliente buscarCliente(int pCedula)
        {
            Cliente encontrado = null;

            for (int i = 0; i < clientes.Count; i++)
            {
                if (clientes[i].getCedula() == pCedula)
                {

                    encontrado = clientes[i];

                }
            }
            return encontrado;
        }

        

    }
}
