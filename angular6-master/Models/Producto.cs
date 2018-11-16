using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Montegras.Models
{
    public class Producto
    {
        public int id;
        public String nombre;
        ProductorAsociado PA;
        public int tiempoDeElaboracion;
        CategoriaProducto categoriaProducto;
        public int cantidad;
        public Boolean overstock;
        List<String> imagen;
        public String descripcion;
        public DateTime vencimiento;


    }
}
