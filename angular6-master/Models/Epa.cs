using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Montegras.Models
{
    public class Epa
    {
        public int id;
        public string nombre;
        public string direccion;
        List<ProductorAsociado> ProductoresEpa;
       
    }
}
