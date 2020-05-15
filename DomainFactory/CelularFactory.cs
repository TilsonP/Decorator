using System;
using System.Collections.Generic;
using System.Text;

namespace DomainFactory
{
    public class CelularFactory : ICelularFactory
    {
        public Celular CrearCelular(int precio)
        {
            switch (precio)
            {
                case 300:
                    return new Xiaomi();
                case 500:
                    return new Samsung();
                case 800:
                    return new IPhone(); 
            }

            return null;
        }
    }
}
