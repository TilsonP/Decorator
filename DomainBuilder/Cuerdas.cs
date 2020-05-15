using System;
using System.Collections.Generic;
using System.Text;

namespace DomainBuilder
{
    public class Cuerdas
    {
        public string Material { get; set; }
        public int Cantidad { get; set; }

        public Cuerdas(string material, int cantidad)
        {
            Material = material;
            Cantidad = cantidad;
        }
    }
}
