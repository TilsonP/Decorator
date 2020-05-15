using System;

namespace DomainAbstractFactory
{
    public abstract class Cuerdas
    {
        private String Descripcion { get; set; }

        public abstract void PonerCuerdas(Guitarra guitarra);
        protected Cuerdas()
        {

        }
    }
}
