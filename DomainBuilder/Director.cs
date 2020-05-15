using System;
using System.Collections.Generic;
using System.Text;

namespace DomainBuilder
{
    public class Director
    {
        private ConstruirGuitarra _construirGuitarra;

        public Director(ConstruirGuitarra construirGuitarra)
        {
            _construirGuitarra = construirGuitarra;
        }

        public void ConstruirGuitarra()
        {
            _construirGuitarra.contruirGuitarra();
            _construirGuitarra.BuildCuerdas();
            _construirGuitarra.BuildCuerpo();
        }

        public Guitarra GetGuitarra()
        {
            return _construirGuitarra.GetGuitarra();
        }
    }
}
