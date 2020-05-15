using System;
using System.Collections.Generic;
using System.Text;

namespace DomainFactory
{
    public interface ICelularFactory
    {
        Celular CrearCelular(int precio);
    }
}
