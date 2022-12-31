using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolucion3.Clases
{
    internal class ProductoMercado
    {
        public string NombreProducto { get; set; }
        public bool Comprado { get; set; }

        public ProductoMercado(string nombreProducto, bool comprado)
        {
            NombreProducto = nombreProducto;
            Comprado = comprado;
        }

        public ProductoMercado(string nombreProducto)
        {
            NombreProducto = nombreProducto;
            Comprado = false;
        }


    }
}
