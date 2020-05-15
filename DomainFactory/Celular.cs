using System;

namespace DomainFactory
{
    public abstract class Celular
    {
        public string Marca { get; set; }
        public int precio { get; set; }

        public abstract int GetPricio();
    }
}
