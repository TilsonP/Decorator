using System;

namespace DomainBuilder
{
    public class Cuerpo
    {
        public string Material { get; set; }

        public Cuerpo(string material)
        {
            Material = material;
        }
    }
}
