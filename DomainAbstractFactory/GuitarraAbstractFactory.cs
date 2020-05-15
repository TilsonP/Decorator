using System;
using System.Collections.Generic;
using System.Text;

namespace DomainAbstractFactory
{
    public abstract class GuitarraAbstractFactory
    {
        public abstract Guitarra ArmarGuitarra();
        public abstract Cuerdas PonerCuerdas();
    }
}
