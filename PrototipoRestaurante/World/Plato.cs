using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoRestaurante.World
{
    class Plato
    {
        private String nombre;
        private String descripcion;
        private double precio;
        private int nPlato;
        private String imagen;


        public Plato(String nombre, String descripcion, double precio, int nPlato, String imagen)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
            this.nPlato = nPlato;
            this.imagen = imagen;

        }

        public String getNombre()
        {
            return nombre;
        }

        public String getDescripcion()
        {
            return descripcion;
        }

        public double getPrecio()
        {
            return precio;
        }

        public int getNPlato()
        {
            return nPlato;
        }

        public String getImagen()
        {
            return imagen;
        }

        public void setNombre(String pNombre)
        {
            nombre = pNombre;
        }

        public void setDescripcion(String pDescripcion)
        {
            nombre = pDescripcion;
        }

        public void setPrecio(double pPrecio)
        {
            precio = pPrecio;
        }
        public void setNPlato(int pNPlato)
        {
            nPlato = pNPlato; ;
        }

        public void setImagen(String pImagen)
        {
            imagen= pImagen;
        }


    }

}
