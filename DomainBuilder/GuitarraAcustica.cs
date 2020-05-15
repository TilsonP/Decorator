using DomainBuilder;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainBuilder
{
    public class GuitarraAcustica : ConstruirGuitarra
    {
        public override void BuildCuerdas()
        {
            Guitarra.cuerdas = new Cuerdas(material: "Nylon", cantidad: 6);
        }

        public override void BuildCuerpo()
        {
            Guitarra.cuerpo = new Cuerpo(material:"MaderaPino");
        }
    }
}
