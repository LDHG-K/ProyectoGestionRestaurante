
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoRestaurante.World
{
    class Empleado
    {
        protected String nombre;
        protected int cedula;
        protected int celular;
        protected String dirección;
        protected DateTime fechaDeIngreso;
        protected double salario;

       public Empleado(String nombre, int cedula, int celular, String dirección, DateTime fechaDeIngreso, double salario)
        {
            this.nombre = nombre;
            this.cedula = cedula;
            this.celular = celular;
            this.dirección = dirección;
            this.fechaDeIngreso = fechaDeIngreso;
            this.salario = salario;
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
        public String getDireccion()
        {
            return dirección;
        }

        public DateTime getFechaDeIngreso()
        {
            return fechaDeIngreso;
        }

        public double getSalario()
        {
            return salario;
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
            celular= pCelular;
        }
        public void setDireccion(String pDireccion)
        {
            dirección = pDireccion;
        }
        public void setFechaDeIngreso(DateTime pFechaDeIngreso)
        {
            fechaDeIngreso = pFechaDeIngreso;
        }
        public void setSalario(int pSalario)
        {
            salario = pSalario;
        }

    }
}
