using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Montegras.Models
{
    public class ProductorAsociado : Usuario
    {
        Epa epa;
        List<Producto> productos;
        List<string> imagen;
        public string descripcion;
        Contrato contrato;
        List<ConsumidorResponsable> consumidores;
        
        //Lista circular, pero eso no se define acá
        
    }
}
