using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoRestaurante.World
{
    class Reserva
    {
        private DateTime fecha;
        private int nReserva;
      

        public Reserva(DateTime fecha, int pIdReserva)
        {
            this.fecha = fecha;
            nReserva = pIdReserva;
        }

        public DateTime getFecha()
        {
            return fecha;
        }

        public int getNReserva()
        {
            return nReserva;
        }

        public void setFecha(DateTime pFecha)
        {
            fecha = pFecha;
        }

        public void setNReserva(int pNReserva)
        {
            nReserva = pNReserva;
        }

        

        
    }
}
