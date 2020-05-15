using System;
using System.Collections.Generic;
using System.Text;

namespace DomainFactory
{
    public class Xiaomi : Celular
    {
        public string Marca()
        {
            return "Xiaomi";
        }

        public override int GetPricio()
        {
            return 300;
        }
    }
}
