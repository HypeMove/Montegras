using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Montegras.Models
{
    public class Combox
    {
        public int id;
        public Boolean disponible;
        ProductorAsociado PA;
        List<Producto> productosCombox;
        Receta recetas;
        ConsumidorResponsable CR;
        public Boolean entregaADomicilio;
        public DateTime fechaEntrega;
        public int semana; //WTF WTF WTF

    }
}
