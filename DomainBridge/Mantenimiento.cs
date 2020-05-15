using System;

namespace DomainBridge
{
    public abstract class Mantenimiento
    {
        protected double Costo { get; set; }

        public double TrabajoHecho()
        {
            return Costo;
        }
    }
}
