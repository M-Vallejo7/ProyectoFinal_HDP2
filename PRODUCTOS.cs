using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login._1
{
    class PRODUCTOS
    {
         public string nombre { get; set; }
        public string precio { get; set; }
        public string cantidad { get; set; }

        public PRODUCTOS(string _nombre, string _precio, string _cantidad)
        {
            nombre = _nombre;
            precio = _precio;
            cantidad = _cantidad;
        }
    }
}
