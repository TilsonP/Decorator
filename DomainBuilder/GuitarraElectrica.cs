using System;
using System.Collections.Generic;
using System.Text;

namespace DomainBuilder
{
    public class GuitarraElectrica : ConstruirGuitarra
    {
        public override void BuildCuerdas()
        {
            Guitarra.cuerdas = new Cuerdas(material: "Acero", cantidad: 6);
        }

        public override void BuildCuerpo()
        {
            Guitarra.cuerpo = new Cuerpo(material: "MaderaRoble");
        }
    }
}
