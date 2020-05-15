using System;
using System.Collections.Generic;
using System.Text;

namespace DomainPrototype
{
    public class TelevisorPrototype
    {
        private readonly Dictionary<string, Televisor> _prototypes = new Dictionary<string, Televisor>();

        TelevisorPrototype()
        {
            var televisorUHD24Pulgadas = new TelevisorUHD() { Modelo = "Televisor UHD 24 pulgadas", Pulgadas = "24" };
            var televisorUHD32Pulgadas = new TelevisorUHD() { Modelo = "Televisor UHD 32 pulgadas", Pulgadas = "32" };
            var televisorHD24Pulgadas = new TelevisorHD() { Modelo = "Televisor HD 24 pulgadas", Pulgadas = "24" };
            var televisorHD32Pulgadas = new TelevisorHD() { Modelo = "Televisor HD 32 pulgadas", Pulgadas = "32" };

            _prototypes.Add("TelevisorUHD24Pulgadas", televisorUHD24Pulgadas);
            _prototypes.Add("TelevisorUHD32Pulgadas", televisorUHD32Pulgadas);
            _prototypes.Add("TelevisorHD24Pulgadas", televisorHD24Pulgadas);
            _prototypes.Add("TelevisorHD32Pulgadas", televisorHD32Pulgadas);
        }

        public Televisor Prototype(string range)
        {
            if (_prototypes.TryGetValue(range, out var televisor))
            {
                return (Televisor)televisor.Clone();
            }

            return null;
        }
    }
}
