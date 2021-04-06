using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoRestaurante.World
{
    class Producto
    {
        private int idProducto;
        private String nombre;
        private double precio;
        private String imagen;

        public Producto(String nombre, int pIdProducto, double precio, String imagen)
        {
            this.nombre = nombre;
            this.idProducto= pIdProducto;
            this.precio = precio;
            this.imagen = imagen;
        }

        public String getNombre()
        {
            return nombre;
        }

        public int getIdProducto()
        {
            return idProducto;
        }

        public double getPrecio()
        {
            return precio;
        }
        public String getImagen()
        {
            return imagen;
        }

        public void setNombre(String pNombre)
        {
            nombre = pNombre;
        }

        public void setIdProducto(int pIdProducto)
        {
            idProducto = pIdProducto;
        }

        public void setPrecio(double pPrecio)
        {
            precio = pPrecio;
        }

        public void setImagen(String pImagen)
        {
            imagen = pImagen;
        }


    }
}
