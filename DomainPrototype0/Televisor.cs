using System;

namespace DomainPrototype
{
    public abstract class Televisor : ICloneable
    {
        public string Modelo { get; set; }
        public string Pulgadas { get; set; }

        public object Clone()
        {
            return this;
        }
    }
}
