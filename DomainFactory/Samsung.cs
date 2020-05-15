using System;
using System.Collections.Generic;
using System.Text;

namespace DomainFactory
{
    public class Samsung : Celular
    {
        public string Marca()
        {
            return "Samsung";
        }

        public override int GetPricio()
        {
            return 500;
        }
    }
}
