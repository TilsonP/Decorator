using System;
using System.Collections.Generic;
using System.Text;

namespace DomainFactory
{
    public class IPhone : Celular
    {
        public string Marca()
        {
            return "Iphone";
        }

        public override int GetPricio()
        {
            return 800;
        }
    }
}
