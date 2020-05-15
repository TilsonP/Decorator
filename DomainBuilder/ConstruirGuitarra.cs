using DomainBuilder;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainBuilder
{
    public abstract class ConstruirGuitarra
    {
        protected Guitarra Guitarra { get; set; }

        public void contruirGuitarra()
        {
            Guitarra = new Guitarra();
        }

        public abstract void BuildCuerdas();
        public abstract void BuildCuerpo();

        public Guitarra GetGuitarra()
        {
            return Guitarra;
        }
    }
}
