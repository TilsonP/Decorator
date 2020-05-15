using DomainBridge;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainFacade
{
    public class GuitarraAcustica : Guitarra
    {
        public double Mantenimiento(Mantenimiento mantenimiento)
        {
            return mantenimiento.TrabajoHecho();
        }
    }
}
