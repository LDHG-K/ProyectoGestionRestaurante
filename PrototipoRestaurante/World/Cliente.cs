using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoRestaurante.World
{
    class Cliente
    {
        private String nombre;
        private int cedula;
        private int celular;
        private String correo;
        

        public Cliente(String nombre, int cedula, int celular, String correo)
        {
            this.nombre = nombre;
            this.cedula = cedula;
            this.celular = celular;
            this.correo = correo;
          
        }
        
        public String getNombre()
        {
            return nombre;
        }
        public int getCedula()
        {
            return cedula;
        }

        public int getCelular()
        {
            return celular;
        }
        public String getCorreo()
        {
            return correo;
        }

        public void setNombre(String pNombre)
        {
            nombre = pNombre;
        }

        public void setCedula(int pCedula)
        {
            cedula = pCedula;
        }

        public void setCelular(int pCelular)
        {
            celular = pCelular;
        }

        public void setCorreo(String pCorreo)
        {
            correo = pCorreo;
        }

      

        
    }
}
