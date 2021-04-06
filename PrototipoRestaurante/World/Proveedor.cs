using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoRestaurante.World
{
    class Proveedor
    {
        private String nombre;
        private String direccion;
        private long telefono;
        static List<Producto> productos = new List<Producto>();

        public Proveedor(String nombre, String direccion, long telefono)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            productos = new List<Producto>();
        }
        public String getNombre()
        {
            return nombre;
        }
        public long getTelefono()
        {
            return telefono;
        }

        public String getDireccion()
        {
            return direccion;
        }
        public List<Producto> getListaProductos()
        {
            return productos;
        }

        public void setTelefono(int pTelefono)
        {
            telefono = pTelefono;
        }

        public void setDireccion(String pDireccion)
        {
            direccion = pDireccion;
        }

        public void setNombre(String pNombre)
        {
            nombre = pNombre;
        }

       

        public static void agregarProducto(String pNombre, int pId, double pPrecio, String pImagen)
        {
            Producto nuevo = new Producto(pNombre, pId, pPrecio, pImagen);
            productos.Add(nuevo);
        }

        public static Producto buscarProducto(int pIdProducto)
        {
            Producto encontrado = null;

            for (int i = 0; i < productos.Count; i++)
            {
                if (productos[i].getIdProducto() == pIdProducto)
                {

                    encontrado = productos[i];

                }
            }

            return encontrado;
        }

        public static void eliminarProducto(int pIdProducto)
        {
            Producto eliminar = buscarProducto(pIdProducto);
            productos.Remove(eliminar);
        }

    }
}
