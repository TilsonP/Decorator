using System;
using System.Collections.Generic;
using System.Text;

namespace DomainAbstractFactory
{
    public class EnsamblarGuitarra
    {
        public EnsamblarGuitarra(GuitarraAbstractFactory factory)
        {
            Cuerdas cuerda = factory.PonerCuerdas();
            Guitarra guitarra = factory.ArmarGuitarra();
            cuerda.PonerCuerdas(guitarra);
        }
    }
}
