using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoRestaurante.World
{
    class MenuRestaurante
    {
        private static List<Plato> platos = new List<Plato>();

        public MenuRestaurante()
        {
            platos = new List<Plato>();
        }

        public static void agregarPlato(String pNombre, String pDescripcion, double pPrecio, int pNPlato, String pImagen)
        {
            Plato nuevo = new Plato(pNombre, pDescripcion, pPrecio, pNPlato, pImagen);
            platos.Add(nuevo);

            //En la interfaz se muestra un MessageBox confirmando que se agregó el plato al menú
        }

        public static Plato buscarPlato(int pNPlato)
        {
            Plato encontrado = null;

            for (int i = 0; i < platos.Count; i++)
            {
                if (platos[i].getNPlato() == pNPlato) 
                {

                    encontrado = platos[i];              

                }
            }

            return encontrado;
        }
        public static void eliminarPlato(int pNPlato)
        {
            Plato eliminar = buscarPlato(pNPlato);
            platos.Remove(eliminar);


        }

        public static List<Plato> darListaPlatos()
        {
            return platos;
        }


    }
}
