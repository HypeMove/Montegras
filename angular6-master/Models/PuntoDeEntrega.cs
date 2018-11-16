using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Montegras.Models
{
    public class PuntoDeEntrega
    {
        public int id;
        public String direccion;
        public Boolean activo;
        public String nombre;
        public DateTime horario;
        ConsumidorResponsable consumidor;

    }
}
