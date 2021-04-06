using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoRestaurante.World
{
    class GerenteGen: Empleado
    {
        static List<Proveedor> proveedores = new List<Proveedor>();
        static List<GerentePunto> gerentes = new List<GerentePunto>();
        static List<Restaurante> restaurantes = new List<Restaurante>();
        static double salarioPunto = GerentePunto.calcularSueldos();

        public GerenteGen
        (String nombre, int cedula, int celular, String direccion, DateTime fechaDeIngreso, double salario) :
        base(nombre, cedula, celular, direccion, fechaDeIngreso, salario)
        {


        }


        public static void agregarProveedor(String pNombre, String pDireccion, long pTelefono)
        {
            Proveedor nuevo = new Proveedor(pNombre, pDireccion, pTelefono);
            proveedores.Add(nuevo);
        }

        public static Proveedor buscarProveedor(String pNombre)
        {
            Proveedor encontrado = null;

            for (int i = 0; i < proveedores.Count; i++)
            {
                if (proveedores[i].getNombre() == pNombre)
                {

                    encontrado = proveedores[i];

                }
            }

            return encontrado;
        }

        public static void eliminarProveedor(String pNombre)
        {
            Proveedor eliminar = buscarProveedor(pNombre);
            proveedores.Remove(eliminar);
        }

        public static void contratarGerente(String nombre, int cedula, int celular, String direccion, DateTime fechaDeIngreso, double salario)
        {
            GerentePunto nuevo = new GerentePunto(nombre, cedula, celular, direccion, fechaDeIngreso, salario);
            gerentes.Add(nuevo);
        }

        public static GerentePunto buscarGerente(int pCedula)
        {
            GerentePunto encontrado = null;

            for (int i = 0; i < gerentes.Count; i++)
            {
                if (gerentes[i].getCedula() == pCedula)
                {

                    encontrado = gerentes[i];

                }
            }

            return encontrado;

        }
        public static void despedirGerente(int pCedula)
        {
            GerentePunto eliminar = buscarGerente(pCedula);
            gerentes.Remove(eliminar);
        }


        public static double calcularNomina()
        {

            double sueldoGerentes = 0;
            double total = 0;

            for (int i = 0; i < gerentes.Count; i++)
            {
                if (gerentes[i] != null)
                {

                    sueldoGerentes += gerentes[i].getSalario();

                }
            }

            total = sueldoGerentes + salarioPunto;

            return total;
        }

        public static void agregarRestaurante(int pId, int pTelefono, String direccion, String nombre)
        {
            Restaurante nuevo = new Restaurante(pId,pTelefono, direccion,nombre);
            restaurantes.Add(nuevo);
        }

        public static Restaurante buscarRestaurante(int pId)
        {
            Restaurante encontrado = null;

            for (int i = 0; i < restaurantes.Count; i++)
            {
                if (restaurantes[i].getId() == pId)
                {
                    encontrado = restaurantes[i];
                }
            }

            return encontrado;
        }

        
    }
}
