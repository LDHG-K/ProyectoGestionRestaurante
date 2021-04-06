using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoRestaurante.World
{
    class GerentePunto: Empleado
    {
        static List<Mesero> meseros = new List<Mesero>();
        static List<Cajero> cajero = new List<Cajero>();
        static List<Reserva> reservas = new List<Reserva>();


        public GerentePunto
        (String nombre, int cedula, int celular, String direccion, DateTime fechaDeIngreso, double salario) :
        base(nombre, cedula, celular, direccion, fechaDeIngreso, salario)
        {


        }

        public static void contratarMesero(String nombre, int cedula, int celular, String direccion, DateTime fechaDeIngreso, double salario)
        {
            Mesero nuevo = new Mesero(nombre, cedula, celular, direccion, fechaDeIngreso, salario);
            meseros.Add(nuevo);
        }

        public static void contratarCajero(String nombre, int cedula, int celular, String direccion, DateTime fechaDeIngreso, double salario)
        {
            
                Cajero nuevo = new Cajero(nombre, cedula, celular, direccion, fechaDeIngreso, salario);
                cajero.Add(nuevo);
            
           
        }


        public static Mesero buscarMesero(int pCedula)
        {
            Mesero encontrado = null;

            for (int i = 0; i < meseros.Count; i++)
            {
                if (meseros[i].getCedula() == pCedula)
                {

                    encontrado = meseros[i];

                }
            }

            return encontrado;


        }


        public static Cajero buscarCajero(int pCedula)
        {
            Cajero encontrado = null;

            for (int i = 0; i < cajero.Count; i++)
            {
                if (cajero[i].getCedula() == pCedula)
                {

                    encontrado = cajero[i];

                }
            }

            return encontrado;


        }

        public static void despedirMesero(int pCedula)
        {
            Mesero eliminar = buscarMesero(pCedula);
            meseros.Remove(eliminar);
        }

        public static void despedirCajero(int pCedula)
        {
            Cajero eliminar = buscarCajero(pCedula);
            cajero.Remove(eliminar);
        }



        public static void crearReserva(DateTime pFecha, int pIdReserva)
        {
            Reserva nueva = new Reserva(pFecha, pIdReserva);
            reservas.Add(nueva);

        }

        public static Reserva buscarReserva(int pIdReserva)
        {

            Reserva encontrado = null;

            for (int i = 0; i < reservas.Count; i++)
            {
                if (reservas[i].getNReserva() == pIdReserva)
                {

                    encontrado = reservas[i];

                }
            }

            return encontrado;
        }

        

        public static void elimarReserva(int pIdReserva)
        {
            Reserva eliminar = buscarReserva(pIdReserva);
            reservas.Remove(eliminar);

        }

        public static double calcularSueldos()
        {
            double sueldoMeseros = 0;
            double sueldoCajeros = 0;
            double total = 0;

            for (int i = 0; i < meseros.Count; i++)
            {
                 if(meseros[i] != null)
                {
                    sueldoMeseros += meseros[i].getSalario();
                }   

            }

            for (int i = 0; i < cajero.Count; i++)
            {
                if (cajero[i] != null)
                {
                    sueldoCajeros += cajero[i].getSalario();
                }

            }

            total = sueldoMeseros + sueldoCajeros;

            return total;
        }



    }
}
