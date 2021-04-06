using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoRestaurante.World
{
    class Restaurante
    {
        private int id;
        private int telefono;
        private String direccion;
        private String nombre;
       

        public Restaurante(int id, int telefono, String direccion, String nombre)
        {
            this.id = id;
            this.telefono = telefono;
            this.direccion = direccion;
            this.nombre = nombre;
        
        }

        public int getId()
        {
            return id;
        }

        public int getTelefono()
        {
            return telefono;
        }

        public String getDireccion()
        {
            return direccion;
        }
    
        public String getNombre()
        {
            return nombre;
        }

        public void setId(int pId)
        {
            id = pId;
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

    

    }
}
